namespace WinFormsApp1
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            label1 = new Label();
            NameGame = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(499, 187);
            label1.TabIndex = 2;
            label1.Text = resources.GetString("label1.Text");
            // 
            // NameGame
            // 
            NameGame.AutoSize = true;
            NameGame.BackColor = Color.Aquamarine;
            NameGame.Font = new Font("Nirmala UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            NameGame.ForeColor = Color.DeepPink;
            NameGame.Location = new Point(87, 21);
            NameGame.Name = "NameGame";
            NameGame.Size = new Size(339, 50);
            NameGame.TabIndex = 3;
            NameGame.Text = "I LIKE TO MOVE IT";
            NameGame.Click += NameGame_Click;
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(515, 319);
            Controls.Add(NameGame);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Help";
            Text = "Help";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label NameGame;
    }
}