using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Drawing2D;
using System.Threading;

namespace RollTheBall
{

    public static class Game
    {
        public static Thread Gameloop;

        private static int Moves = 0;
        public static int CurrentLvl = 0;

        private static Point CurrMousePos = new Point(), CurrBlockPos = new Point();
        private static Block TempBlock = new Block(true, 0, 0, 0);
        private static List<Point> CurrBlocksLocations = new List<Point>();
        private static List<Point> Resetpositions = new List<Point>();
        private static List<List<Point>> UndoHistory = new List<List<Point>>();
        private static List<Level> Levels = new List<Level>();
        public static Level Active_level;

        static Game()
        {
            FileStream read = new FileStream("Levels.txt", FileMode.Open);
            StreamReader sread = new StreamReader(read);

            Levels.Clear();
            while (!sread.EndOfStream)
            {
                List<Block> Blocks = new List<Block>();
                Dictionary<Point, Images> WinCondition = new Dictionary<Point, Images>();

                int LevelNumber = Convert.ToInt32(sread.ReadLine());
                int BestMoves = Convert.ToInt32(sread.ReadLine());

                while (true)
                {
                    string[] numbers = new string[5];
                    numbers = sread.ReadLine().Split(' ');
                    if (numbers[0] == "@")
                        break;


                    Block block = new Block(Convert.ToBoolean(int.Parse(numbers[0])), int.Parse(numbers[1]) * 75,
                                                              int.Parse(numbers[2]) * 75, (Images)int.Parse(numbers[3]));
                    Blocks.Add(block);

                }

                while (true)
                {
                    string[] numbers = new string[5];
                    numbers = sread.ReadLine().Split(' ');
                    if (numbers[0] == "@")
                        break;

                    WinCondition.Add(new Point(int.Parse(numbers[0]) * 75, int.Parse(numbers[1]) * 75), (Images)int.Parse(numbers[2]));
                }

                Level lvl = new Level(LevelNumber, BestMoves, Blocks, WinCondition);
                Levels.Add(lvl);
            }
            read.Close();
        }
        public static void BuildLevel(Panel Playground)
        {
            Active_level = Levels[CurrentLvl - 1];
            foreach (Block _Block in Active_level.Blocks)
            {
                Playground.Controls.Add(_Block);
                CurrBlocksLocations.Add(_Block.Location);
                Resetpositions.Add(_Block.Location);
            }
        }
        public static void Update(Panel Playground, Label Moves_count)
        {
            lock (new object())
            {

                foreach (Block _Block in Playground.Controls)
                {
                    _Block.MouseDown += (senderblock, mouse) =>
                    {
                        TempBlock = (Block)senderblock;
                        CurrMousePos = mouse.Location;
                        CurrBlockPos = TempBlock.Location;

                    };
                    _Block.MouseMove += (senderblock, mouse) =>
                    {
                        TempBlock = (Block)senderblock;
                        if (mouse.Button == MouseButtons.Left && TempBlock.Movable)
                        {
                            TempBlock.Left += mouse.X - CurrMousePos.X;
                            TempBlock.Top += mouse.Y - CurrMousePos.Y;
                        }
                    };
                    _Block.MouseUp += (senderblock, mouse) =>
                    {
                        TempBlock = (Block)senderblock;
                        if (TempBlock.Top < Playground.Top - 20 || TempBlock.Left < Playground.Left - 20 ||
                            TempBlock.Right > Playground.Right + 20 || TempBlock.Bottom > Playground.Bottom + 20)
                            TempBlock.Location = CurrBlockPos;

                        int changeY = Math.Max(CurrBlockPos.Y, TempBlock.Location.Y) - Math.Min(CurrBlockPos.Y, TempBlock.Location.Y);
                        int changeX = Math.Max(CurrBlockPos.X, TempBlock.Location.X) - Math.Min(CurrBlockPos.X, TempBlock.Location.X);

                        Point TempPoint = CurrBlockPos;

                        if (changeX > changeY && changeX < 150 && changeX > 40)
                        {
                            if (CurrBlockPos.X - TempBlock.Location.X > 0)
                            {
                                if (CheckLeft(CurrBlockPos))
                                {
                                    SavePosToHistory();
                                    TempPoint.X -= 75;
                                    TempBlock.Location = TempPoint;
                                    Moves++;
                                }
                                else
                                {
                                    TempBlock.Location = CurrBlockPos;
                                    return;
                                }
                            }
                            else
                            {
                                if (CheckRight(CurrBlockPos))
                                {
                                    SavePosToHistory();
                                    TempPoint.X += 75;
                                    TempBlock.Location = TempPoint;
                                    Moves++;
                                }
                                else
                                {
                                    TempBlock.Location = CurrBlockPos;
                                    return;
                                }
                            }

                            foreach (Block xBlock in Playground.Controls)
                            {
                                CurrBlocksLocations.Add(xBlock.Location);
                            }
                        }
                        else if (changeX < changeY && changeY < 150 && changeY > 40)
                        {
                            if (CurrBlockPos.Y - TempBlock.Location.Y > 0)
                            {
                                if (CheckUp(CurrBlockPos))
                                {
                                    SavePosToHistory();
                                    TempPoint.Y -= 75;
                                    TempBlock.Location = TempPoint;
                                    Moves++;
                                }
                                else
                                {
                                    TempBlock.Location = CurrBlockPos;
                                    return;
                                }
                            }
                            else
                            {
                                if (CheckDown(CurrBlockPos))
                                {
                                    SavePosToHistory();
                                    TempPoint.Y += 75;
                                    TempBlock.Location = TempPoint;
                                    Moves++;
                                }
                                else
                                {
                                    TempBlock.Location = CurrBlockPos;
                                    return;
                                }
                            }
                            foreach (Block xBlock in Playground.Controls)
                            {
                                CurrBlocksLocations.Add(xBlock.Location);
                            }
                        }
                        else
                        {
                            TempBlock.Location = CurrBlockPos;
                        }

                        if (CheckWin(Playground))
                        {
                            Moves_count.Text = Moves.ToString();

                            if (Active_level.BestMoves == Moves)
                                MessageBox.Show("You Won!\n\nPerfect Score");
                            else
                                MessageBox.Show("You Won!\n\nTry Doing It In Less Moves ?!");

                            Thread.Sleep(1750);
                            Application.Exit();
                        }

                        Moves_count.Text = Moves.ToString();
                    };
                }

            }
        }
        private static void SavePosToHistory()
        {
            List<Point> SingleUndo = new List<Point>();
            foreach (Point x in CurrBlocksLocations)
            {
                SingleUndo.Add(x);
            }
            UndoHistory.Add(SingleUndo);

            CurrBlocksLocations.Clear();
        }
        private static bool CheckUp(Point P)
        {
            P.Y -= 75;
            foreach (Point P2 in CurrBlocksLocations)
            {
                if (P == P2)
                    return false;
            }
            return true;
        }
        private static bool CheckDown(Point P)
        {
            P.Y += 75;
            foreach (Point P2 in CurrBlocksLocations)
            {
                if (P == P2)
                    return false;
            }
            return true;
        }
        private static bool CheckRight(Point P)
        {
            P.X += 75;
            foreach (Point P2 in CurrBlocksLocations)
            {
                if (P == P2)
                    return false;
            }
            return true;
        }
        private static bool CheckLeft(Point P)
        {
            P.X -= 75;
            foreach (Point P2 in CurrBlocksLocations)
            {
                if (P == P2)
                    return false;
            }
            return true;
        }
        private static bool CheckWin(Panel Playground)
        {
            foreach (KeyValuePair<Point, Images> CheckPoint in Active_level.WinCondition)
            {
                foreach (Block _Block in Playground.Controls)
                {
                    if (!CurrBlocksLocations.Contains(CheckPoint.Key))
                        return false;
                    if (_Block.Location == CheckPoint.Key && _Block.BackgroundImageNum != CheckPoint.Value)
                        return false;
                }
            }
            return true;
        }
        public static void Reset()
        {
            Moves = 0;
            UndoHistory.Clear();
            int i = 0;
            foreach (Block _Block in Active_level.Blocks)
            {
                _Block.Location = Resetpositions[i];
                i++;
            }
            CurrBlocksLocations.Clear();
        }
        public static void Undo(Label Moves_count)
        {
            if (Moves > 0)
            {
                List<Point> SingleUndo = UndoHistory[Moves - 1];
                UndoHistory.Remove(SingleUndo);
                int i = 0;
                foreach (Block _Block in Active_level.Blocks)
                {
                    _Block.Location = SingleUndo[i];
                    i++;
                }
                CurrBlocksLocations.Clear();
                CurrBlocksLocations = SingleUndo;
            }
            Moves--;
            if (Moves < 0)
                Moves = 0;

            Moves_count.Text = Moves.ToString();

        }
    }
}
