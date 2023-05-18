namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Ball = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            Settings = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            pauseToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            Customize = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            circle = new ToolStripMenuItem();
            square = new ToolStripMenuItem();
            triangle = new ToolStripMenuItem();
            StarTool = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            objectToolStripMenuItem = new ToolStripMenuItem();
            borderToolStripMenuItem = new ToolStripMenuItem();
            backgroundToolStripMenuItem = new ToolStripMenuItem();
            speedToolStripMenuItem = new ToolStripMenuItem();
            slowlyToolStripMenuItem = new ToolStripMenuItem();
            normalToolStripMenuItem = new ToolStripMenuItem();
            fastToolStripMenuItem = new ToolStripMenuItem();
            Help = new ToolStripMenuItem();
            forUsToolStripMenuItem = new ToolStripMenuItem();
            colorBackground = new ColorDialog();
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            colorBody = new ColorDialog();
            colorBorder = new ColorDialog();
            heartToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)Ball).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Ball
            // 
            Ball.BackColor = SystemColors.ActiveCaptionText;
            Ball.Location = new Point(630, -126);
            Ball.Name = "Ball";
            Ball.Size = new Size(30, 30);
            Ball.TabIndex = 0;
            Ball.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Aquamarine;
            menuStrip1.Items.AddRange(new ToolStripItem[] { Settings, Customize, Help, forUsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(595, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // Settings
            // 
            Settings.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, pauseToolStripMenuItem, exitToolStripMenuItem });
            Settings.ForeColor = SystemColors.ActiveCaptionText;
            Settings.Name = "Settings";
            Settings.Size = new Size(95, 20);
            Settings.Text = "Game &Settings";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(135, 22);
            newGameToolStripMenuItem.Text = "Start  &Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // pauseToolStripMenuItem
            // 
            pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            pauseToolStripMenuItem.Size = new Size(135, 22);
            pauseToolStripMenuItem.Text = "&Pause";
            pauseToolStripMenuItem.Click += pauseToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(135, 22);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Customize
            // 
            Customize.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, optionsToolStripMenuItem, speedToolStripMenuItem });
            Customize.ForeColor = SystemColors.ActiveCaptionText;
            Customize.Name = "Customize";
            Customize.Size = new Size(75, 20);
            Customize.Text = "&Customize";
            Customize.Click += toolsToolStripMenuItem_Click;
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { circle, square, triangle, StarTool, heartToolStripMenuItem });
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(180, 22);
            customizeToolStripMenuItem.Text = "&Type";
            // 
            // circle
            // 
            circle.Name = "circle";
            circle.Size = new Size(180, 22);
            circle.Text = "Circle";
            circle.Click += elipseToolStripMenuItem_Click;
            // 
            // square
            // 
            square.Name = "square";
            square.Size = new Size(180, 22);
            square.Text = "Square";
            square.Click += square_Click;
            // 
            // triangle
            // 
            triangle.Name = "triangle";
            triangle.Size = new Size(180, 22);
            triangle.Text = "Triangle";
            triangle.Click += triangle_Click;
            // 
            // StarTool
            // 
            StarTool.Name = "StarTool";
            StarTool.Size = new Size(180, 22);
            StarTool.Text = "Star";
            StarTool.Click += StarTool_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { objectToolStripMenuItem, borderToolStripMenuItem, backgroundToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(180, 22);
            optionsToolStripMenuItem.Text = "&Color";
            // 
            // objectToolStripMenuItem
            // 
            objectToolStripMenuItem.Name = "objectToolStripMenuItem";
            objectToolStripMenuItem.Size = new Size(138, 22);
            objectToolStripMenuItem.Text = "Object";
            objectToolStripMenuItem.Click += objectToolStripMenuItem_Click;
            // 
            // borderToolStripMenuItem
            // 
            borderToolStripMenuItem.Name = "borderToolStripMenuItem";
            borderToolStripMenuItem.Size = new Size(138, 22);
            borderToolStripMenuItem.Text = "Border";
            borderToolStripMenuItem.Click += borderToolStripMenuItem_Click;
            // 
            // backgroundToolStripMenuItem
            // 
            backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            backgroundToolStripMenuItem.Size = new Size(138, 22);
            backgroundToolStripMenuItem.Text = "Background";
            backgroundToolStripMenuItem.Click += backgroundToolStripMenuItem_Click;
            // 
            // speedToolStripMenuItem
            // 
            speedToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { slowlyToolStripMenuItem, normalToolStripMenuItem, fastToolStripMenuItem });
            speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            speedToolStripMenuItem.Size = new Size(180, 22);
            speedToolStripMenuItem.Text = "Spee&d";
            speedToolStripMenuItem.Click += speedToolStripMenuItem_Click;
            // 
            // slowlyToolStripMenuItem
            // 
            slowlyToolStripMenuItem.Name = "slowlyToolStripMenuItem";
            slowlyToolStripMenuItem.Size = new Size(114, 22);
            slowlyToolStripMenuItem.Text = "Slow";
            slowlyToolStripMenuItem.Click += slowlyToolStripMenuItem_Click;
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(114, 22);
            normalToolStripMenuItem.Text = "Normal";
            normalToolStripMenuItem.Click += normalToolStripMenuItem_Click;
            // 
            // fastToolStripMenuItem
            // 
            fastToolStripMenuItem.Name = "fastToolStripMenuItem";
            fastToolStripMenuItem.Size = new Size(114, 22);
            fastToolStripMenuItem.Text = "Fast";
            fastToolStripMenuItem.Click += fastToolStripMenuItem_Click;
            // 
            // Help
            // 
            Help.ForeColor = SystemColors.ActiveCaptionText;
            Help.Name = "Help";
            Help.Size = new Size(44, 20);
            Help.Text = "&Help";
            Help.Click += Help_Click;
            // 
            // forUsToolStripMenuItem
            // 
            forUsToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            forUsToolStripMenuItem.Name = "forUsToolStripMenuItem";
            forUsToolStripMenuItem.Size = new Size(52, 20);
            forUsToolStripMenuItem.Text = "&For Us";
            forUsToolStripMenuItem.Click += forUsToolStripMenuItem_Click;
            // 
            // heartToolStripMenuItem
            // 
            heartToolStripMenuItem.Name = "heartToolStripMenuItem";
            heartToolStripMenuItem.Size = new Size(180, 22);
            heartToolStripMenuItem.Text = "Heart";
            heartToolStripMenuItem.Click += heartToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(595, 480);
            Controls.Add(Ball);
            Controls.Add(menuStrip1);
            ForeColor = Color.DeepPink;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "I like to move it";
            Load += Form1_Load;
            Paint += Block_Paint;
            ((System.ComponentModel.ISupportInitialize)Ball).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Ball;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Customize;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem Help;
        private ToolStripMenuItem objectToolStripMenuItem;
        private ToolStripMenuItem borderToolStripMenuItem;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private ToolStripMenuItem speedToolStripMenuItem;
        private ColorDialog colorBackground;
        private ToolStripMenuItem slowlyToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem fastToolStripMenuItem;
        private ToolStripMenuItem circle;
        private ToolStripMenuItem Settings;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem forUsToolStripMenuItem;
        private ToolStripMenuItem square;
        private ToolStripMenuItem triangle;
        private ToolStripMenuItem StarTool;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private ColorDialog colorBody;
        private ColorDialog colorBorder;
        private ToolStripMenuItem heartToolStripMenuItem;
    }
}