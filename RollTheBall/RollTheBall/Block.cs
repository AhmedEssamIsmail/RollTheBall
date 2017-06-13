using System.Windows.Forms;

namespace RollTheBall
{
    public class Block : Button
    {
        public bool Movable;
        public Images BackgroundImageNum;
        public Block(bool Movable, int x, int y, Images BackgroundImageNum)
        {
            FlatStyle = FlatStyle.Popup;
            BackgroundImageLayout = ImageLayout.Stretch;
            Cursor = Cursors.Hand;

            if (!Movable)
                Enabled = false;

            Width = 75;
            Height = 75;
            Top = y;
            Left = x;
            Text = "";
            this.Movable = Movable;
            this.BackgroundImageNum = BackgroundImageNum;

            switch (BackgroundImageNum)
            {
                case Images.StartUp:
                    BackgroundImage = Properties.Resources.StartUp;
                    break;
                case Images.StartDown:
                    BackgroundImage = Properties.Resources.StartDown;
                    break;
                case Images.StartLeft:
                    BackgroundImage = Properties.Resources.StartLeft;
                    break;
                case Images.StartRight:
                    BackgroundImage = Properties.Resources.StartRight;
                    break;
                case Images.FinishUp:
                    BackgroundImage = Properties.Resources.FinishUp;
                    break;
                case Images.FinishRight:
                    BackgroundImage = Properties.Resources.FinishRight;
                    break;
                case Images.FinishLeft:
                    BackgroundImage = Properties.Resources.FinishLeft;
                    break;
                case Images.FinishDown:
                    BackgroundImage = Properties.Resources.FinishDown;
                    break;
                case Images.Curve1:
                    BackgroundImage = Properties.Resources.Curve1;
                    break;
                case Images.Curve2:
                    BackgroundImage = Properties.Resources.Curve2;
                    break;
                case Images.Curve3:
                    BackgroundImage = Properties.Resources.Curve3;
                    break;
                case Images.Curve4:
                    BackgroundImage = Properties.Resources.Curve4;
                    break;
                case Images.Curve1Fixed:
                    BackgroundImage = Properties.Resources.Curve1Fixed;
                    break;
                case Images.Curve2Fixed:
                    BackgroundImage = Properties.Resources.Curve2Fixed;
                    break;
                case Images.Curve3Fixed:
                    BackgroundImage = Properties.Resources.Curve3Fixed;
                    break;
                case Images.Curve4Fixed:
                    BackgroundImage = Properties.Resources.Curve4Fixed;
                    break;
                case Images.LineH:
                    BackgroundImage = Properties.Resources.LineH;
                    break;
                case Images.LineHFixed:
                    BackgroundImage = Properties.Resources.LineHFixed;
                    break;
                case Images.LineV:
                    BackgroundImage = Properties.Resources.LineV;
                    break;
                case Images.LineVFixed:
                    BackgroundImage = Properties.Resources.LineVFixed;
                    break;
                case Images.Empty:
                    BackgroundImage = Properties.Resources.Empty;
                    break;
            }
        }
    }
}
