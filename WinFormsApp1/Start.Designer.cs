namespace WinFormsApp1
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameGame = new Label();
            startGame = new Button();
            SuspendLayout();
            // 
            // NameGame
            // 
            NameGame.AutoSize = true;
            NameGame.BackColor = Color.Aquamarine;
            NameGame.Font = new Font("Nirmala UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            NameGame.ForeColor = Color.DeepPink;
            NameGame.Location = new Point(19, 64);
            NameGame.Name = "NameGame";
            NameGame.Size = new Size(339, 50);
            NameGame.TabIndex = 0;
            NameGame.Text = "I LIKE TO MOVE IT";
            NameGame.Click += NameGame_Click;
            // 
            // startGame
            // 
            startGame.BackColor = Color.DeepPink;
            startGame.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            startGame.ForeColor = Color.Aquamarine;
            startGame.Location = new Point(113, 175);
            startGame.Name = "startGame";
            startGame.Size = new Size(141, 70);
            startGame.TabIndex = 1;
            startGame.Text = "START";
            startGame.UseVisualStyleBackColor = false;
            startGame.Click += startGame_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(370, 308);
            Controls.Add(startGame);
            Controls.Add(NameGame);
            Name = "Start";
            Text = "I like to move it";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameGame;
        private Button startGame;
    }
}