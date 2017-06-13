using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace RollTheBall
{
    public class Level
    {
        private int LevelNumber;
        public int BestMoves;
        public List <Block> Blocks = new List<Block>();
        public Dictionary<Point, Images> WinCondition = new Dictionary<Point, Images>();

        public Level(int LevelNumber, int BestMoves, List<Block> Blocks, Dictionary<Point, Images> WinCondition)
        {
            this.LevelNumber = LevelNumber;
            this.BestMoves = BestMoves;
            this.Blocks = Blocks;
            this.WinCondition = WinCondition;
        }
    }
}
