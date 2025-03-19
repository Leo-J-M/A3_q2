namespace A3_q2
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
            label1 = new Label();
            txtGues = new TextBox();
            btnNewGame = new Button();
            label2 = new Label();
            label3 = new Label();
            txtWon = new TextBox();
            txtAtempts = new TextBox();
            btnGues = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 92);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter your gues (0-1000): ";
            // 
            // txtGues
            // 
            txtGues.Location = new Point(180, 89);
            txtGues.Name = "txtGues";
            txtGues.Size = new Size(100, 23);
            txtGues.TabIndex = 1;
            txtGues.TextAlign = HorizontalAlignment.Right;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(205, 23);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(75, 23);
            btnNewGame.TabIndex = 2;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 27);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Games won";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 61);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Atempts left";
            // 
            // txtWon
            // 
            txtWon.Location = new Point(108, 24);
            txtWon.Name = "txtWon";
            txtWon.ReadOnly = true;
            txtWon.Size = new Size(66, 23);
            txtWon.TabIndex = 5;
            txtWon.Text = "0";
            txtWon.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAtempts
            // 
            txtAtempts.Location = new Point(108, 58);
            txtAtempts.Name = "txtAtempts";
            txtAtempts.ReadOnly = true;
            txtAtempts.Size = new Size(66, 23);
            txtAtempts.TabIndex = 6;
            txtAtempts.Text = "10";
            txtAtempts.TextAlign = HorizontalAlignment.Right;
            // 
            // btnGues
            // 
            btnGues.Location = new Point(33, 129);
            btnGues.Name = "btnGues";
            btnGues.Size = new Size(247, 23);
            btnGues.TabIndex = 7;
            btnGues.Text = "Gues";
            btnGues.UseVisualStyleBackColor = true;
            btnGues.Click += btnGues_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 224);
            Controls.Add(btnGues);
            Controls.Add(txtAtempts);
            Controls.Add(txtWon);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnNewGame);
            Controls.Add(txtGues);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtGues;
        private Button btnNewGame;
        private Label label2;
        private Label label3;
        private TextBox txtWon;
        private TextBox txtAtempts;
        private Button btnGues;
    }
}
