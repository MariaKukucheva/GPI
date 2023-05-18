namespace WinFormsApp1
{
    partial class author
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepPink;
            label1.Location = new Point(30, 39);
            label1.Name = "label1";
            label1.Size = new Size(295, 32);
            label1.TabIndex = 0;
            label1.Text = "Автор: Мария Кукучева";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(88, 94);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 2;
            label2.Text = "1 курс СТД";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 141);
            label3.Name = "label3";
            label3.Size = new Size(264, 30);
            label3.TabIndex = 3;
            label3.Text = "ПУ \"Паисий Хилендарски\"";
            // 
            // author
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(342, 218);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "author";
            Text = "author";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
    }
}