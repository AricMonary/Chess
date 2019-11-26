namespace Chess
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;

    public partial class ChessForm : Form
    {
        private ChessBoard board = new ChessBoard();

        public ChessForm()
        {
            this.InitializeComponent();
            this.ResetChessBoard("d", "l");
        }

        private void ChessForm_Load(object sender, EventArgs e)
        {
            string apppath = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        }

        private void ResetChessBoard(string topColor, string bottomColor)
        {
            string apppath = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "PieceSprites/");

            // Top
            this.A8.Image = Image.FromFile(apppath + "r" + topColor + ".png");
            this.H8.Image = Image.FromFile(apppath + "r" + topColor + ".png");
            this.B8.Image = Image.FromFile(apppath + "n" + topColor + ".png");
            this.G8.Image = Image.FromFile(apppath + "n" + topColor + ".png");
            this.C8.Image = Image.FromFile(apppath + "b" + topColor + ".png");
            this.F8.Image = Image.FromFile(apppath + "b" + topColor + ".png");
            if (topColor.Equals("d") && bottomColor.Equals("l"))
            {
                this.D8.Image = Image.FromFile(apppath + "q" + topColor + ".png");
                this.E8.Image = Image.FromFile(apppath + "k" + topColor + ".png");
            }
            else
            {
                this.D8.Image = Image.FromFile(apppath + "k" + topColor + ".png");
                this.E8.Image = Image.FromFile(apppath + "q" + topColor + ".png");
            }

            this.A7.Image = Image.FromFile(apppath + "p" + topColor + ".png");
            this.B7.Image = Image.FromFile(apppath + "p" + topColor + ".png");
            this.C7.Image = Image.FromFile(apppath + "p" + topColor + ".png");
            this.D7.Image = Image.FromFile(apppath + "p" + topColor + ".png");
            this.E7.Image = Image.FromFile(apppath + "p" + topColor + ".png");
            this.F7.Image = Image.FromFile(apppath + "p" + topColor + ".png");
            this.G7.Image = Image.FromFile(apppath + "p" + topColor + ".png");
            this.H7.Image = Image.FromFile(apppath + "p" + topColor + ".png");

            // Bottom
            this.A1.Image = Image.FromFile(apppath + "r" + bottomColor + ".png");
            this.H1.Image = Image.FromFile(apppath + "r" + bottomColor + ".png");
            this.B1.Image = Image.FromFile(apppath + "n" + bottomColor + ".png");
            this.G1.Image = Image.FromFile(apppath + "n" + bottomColor + ".png");
            this.C1.Image = Image.FromFile(apppath + "b" + bottomColor + ".png");
            this.F1.Image = Image.FromFile(apppath + "b" + bottomColor + ".png");
            if (topColor.Equals("d") && bottomColor.Equals("l"))
            {
                this.D1.Image = Image.FromFile(apppath + "q" + bottomColor + ".png");
                this.E1.Image = Image.FromFile(apppath + "k" + bottomColor + ".png");
            }
            else
            {
                this.D1.Image = Image.FromFile(apppath + "k" + bottomColor + ".png");
                this.E1.Image = Image.FromFile(apppath + "q" + bottomColor + ".png");
            }

            this.A2.Image = Image.FromFile(apppath + "p" + bottomColor + ".png");
            this.B2.Image = Image.FromFile(apppath + "p" + bottomColor + ".png");
            this.C2.Image = Image.FromFile(apppath + "p" + bottomColor + ".png");
            this.D2.Image = Image.FromFile(apppath + "p" + bottomColor + ".png");
            this.E2.Image = Image.FromFile(apppath + "p" + bottomColor + ".png");
            this.F2.Image = Image.FromFile(apppath + "p" + bottomColor + ".png");
            this.G2.Image = Image.FromFile(apppath + "p" + bottomColor + ".png");
            this.H2.Image = Image.FromFile(apppath + "p" + bottomColor + ".png");
        }
    }
}
