using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //Item(50,50)
        private int x = 50;
        private int y = 50;

        // size of the circle
        private int size = 30;

        // Item(50 + MoveX,50 + MoveY)
        private int MoveX = 1;
        private int MoveY = 1;

        private int speed;

        public int body = 1;

        private Color shapeColor = Color.DeepPink;
        private Color BorderColor = Color.Black;

        public Form1()
        {
            InitializeComponent();// enable the timer
            speed = 10; 
            
            this.SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint,
                true);
            this.UpdateStyles();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // move item
            x += MoveX * speed / 5;
            y += MoveY * speed / 5;

            if (x > ClientSize.Width - 30 || x < 0)
            {
                MoveX = -MoveX;
            }
            if (y > ClientSize.Height - 30 || y < 25)
            {
                MoveY = -MoveY;
            }

            Invalidate();
        }
        //--------------------- speed -----------------------------------------------
        private void slowlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speed = 5;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speed = 10;
        }

        private void fastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speed = 80;
        }

        //------------------ Color ---------------------------------------------------
        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog BackgroundColor = new ColorDialog();
            if (colorBackground.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorBackground.Color;
            }
        }

        private void borderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog Border = new ColorDialog();
            if (Border.ShowDialog() == DialogResult.OK)
            {
                BorderColor = Border.Color;
                Invalidate(); // this will trigger the Paint event
            }
        }

        private void objectToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                shapeColor = colorDialog1.Color;
                Invalidate(); // this will trigger the Paint event
            }
        }
        //---------------------------- Main -----------------------------------------------------

        private void Block_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(BorderColor, 3);
            SolidBrush brush = new SolidBrush(shapeColor);

            if (body == 1)
            {
                g.DrawEllipse(pen, x, y, size, size);
                g.FillEllipse(brush, x, y, size, size);
            }
            else if (body == 2)
            {
                g.DrawRectangle(pen, x, y, size, size);
                g.FillRectangle(brush, x, y, size, size);
            }
            else if (body == 3)
            {
                Point p1 = new Point(0 + x, 30 + y);
                Point p2 = new Point(15 + x, 0 + y);
                Point p3 = new Point(30 + x, 30 + y);
                Point[] triangle = { p1, p2, p3 };

                g.DrawPolygon(pen, triangle);
                g.FillPolygon(brush, triangle);
            }
            else if (body == 4)
            {
                Point p1 = new Point(0 + x, 12 + y);
                Point p2 = new Point(10 + x, 12 + y);
                Point p3 = new Point(15 + x, 0 + y);
                Point p4 = new Point(20 + x, 12 + y);
                Point p5 = new Point(30 + x, 12 + y);
                Point p6 = new Point(22 + x, 19 + y);
                Point p7 = new Point(25 + x, 30 + y);
                Point p8 = new Point(15 + x, 25 + y);
                Point p9 = new Point(5 + x, 30 + y);
                Point p10 = new Point(8 + x, 19 + y);
                Point[] star = { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 };

                g.DrawPolygon(pen, star);
                g.FillPolygon(brush, star);
            }
            else if (body == 5)
            {
                Point p1 = new Point(0 + x, 5 + y);
                Point p2 = new Point(3 + x, 0 + y);
                Point p3 = new Point(10 + x, 0 + y);
                Point p4 = new Point(15 + x, 7 + y);
                Point p5 = new Point(20 + x, 0 + y);
                Point p6 = new Point(27 + x, 0 + y);
                Point p7 = new Point(30 + x, 5 + y);
                Point p8 = new Point(30 + x, 15 + y);
                Point p9 = new Point(15 + x, 30 + y);
                Point p10 = new Point(0 + x, 15 + y);
                Point[] heart = { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10};

                g.DrawPolygon(pen, heart);
                g.FillPolygon(brush, heart);
            }
        }

        //----------------------- menu ----------------------------------------------

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //------------------- for other form -----------------------------------------
        private void forUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            author author = new author();
            author.Show();
        }
        private void Help_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
        //-------------- click button of shape -------------------------------
        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            body = 1;
            Invalidate();
        }

        private void square_Click(object sender, EventArgs e)
        {
            body = 2;
            Invalidate();
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            body = 3;
            Invalidate();
        }
        private void StarTool_Click(object sender, EventArgs e)
        {
            body = 4;
            Invalidate();
        }
        private void heartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            body = 5;
            Invalidate();
        }
        private void speedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        { }

       
    }
}