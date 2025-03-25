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
        private void InitializeComponent() {
            label1 = new Label();
            txtGues = new TextBox();
            btnNewGame = new Button();
            label2 = new Label();
            label3 = new Label();
            txtWon = new TextBox();
            txtAtempts = new TextBox();
            btnGues = new Button();
            txtAnsw = new TextBox();
            listViewGuesses = new ListView();
            columnHeader1 = new ColumnHeader();
            checkBoxShow = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(33, 202);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(265, 30);
            label1.TabIndex = 0;
            label1.Text = "Enter your gues (0-1000): ";
            // 
            // txtGues
            // 
            txtGues.Font = new Font("Segoe UI", 11F);
            txtGues.Location = new Point(303, 199);
            txtGues.Margin = new Padding(4, 5, 4, 5);
            txtGues.Name = "txtGues";
            txtGues.Size = new Size(141, 37);
            txtGues.TabIndex = 1;
            txtGues.TextAlign = HorizontalAlignment.Center;
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new Font("Segoe UI", 11F);
            btnNewGame.Location = new Point(292, 47);
            btnNewGame.Margin = new Padding(4, 5, 4, 5);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(152, 38);
            btnNewGame.TabIndex = 2;
            btnNewGame.Text = "N&ew Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(33, 54);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 30);
            label2.TabIndex = 3;
            label2.Text = "Games won";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(33, 127);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 30);
            label3.TabIndex = 4;
            label3.Text = "Atempts left";
            // 
            // txtWon
            // 
            txtWon.Font = new Font("Segoe UI", 11F);
            txtWon.Location = new Point(172, 48);
            txtWon.Margin = new Padding(4, 5, 4, 5);
            txtWon.Name = "txtWon";
            txtWon.ReadOnly = true;
            txtWon.Size = new Size(93, 37);
            txtWon.TabIndex = 5;
            txtWon.Text = "0";
            txtWon.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAtempts
            // 
            txtAtempts.Font = new Font("Segoe UI", 11F);
            txtAtempts.Location = new Point(172, 124);
            txtAtempts.Margin = new Padding(4, 5, 4, 5);
            txtAtempts.Name = "txtAtempts";
            txtAtempts.ReadOnly = true;
            txtAtempts.Size = new Size(93, 37);
            txtAtempts.TabIndex = 6;
            txtAtempts.Text = "10";
            txtAtempts.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGues
            // 
            btnGues.Font = new Font("Segoe UI", 11F);
            btnGues.Location = new Point(33, 310);
            btnGues.Margin = new Padding(4, 5, 4, 5);
            btnGues.Name = "btnGues";
            btnGues.Size = new Size(411, 38);
            btnGues.TabIndex = 7;
            btnGues.Text = "Gues";
            btnGues.UseVisualStyleBackColor = true;
            btnGues.Click += btnGues_Click;
            // 
            // txtAnsw
            // 
            txtAnsw.Location = new Point(402, 126);
            txtAnsw.Name = "txtAnsw";
            txtAnsw.ReadOnly = true;
            txtAnsw.Size = new Size(42, 31);
            txtAnsw.TabIndex = 8;
            txtAnsw.TextAlign = HorizontalAlignment.Center;
            txtAnsw.Visible = false;
            // 
            // listViewGuesses
            // 
            listViewGuesses.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listViewGuesses.GridLines = true;
            listViewGuesses.Location = new Point(451, 21);
            listViewGuesses.Name = "listViewGuesses";
            listViewGuesses.Size = new Size(84, 327);
            listViewGuesses.TabIndex = 9;
            listViewGuesses.UseCompatibleStateImageBehavior = false;
            listViewGuesses.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Guesses";
            columnHeader1.Width = 80;
            // 
            // checkBoxShow
            // 
            checkBoxShow.AutoSize = true;
            checkBoxShow.Location = new Point(580, 151);
            checkBoxShow.Name = "checkBoxShow";
            checkBoxShow.Size = new Size(114, 29);
            checkBoxShow.TabIndex = 10;
            checkBoxShow.Text = "Show ans";
            checkBoxShow.UseVisualStyleBackColor = true;
            checkBoxShow.CheckedChanged += checkBoxShow_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 379);
            Controls.Add(checkBoxShow);
            Controls.Add(listViewGuesses);
            Controls.Add(txtAnsw);
            Controls.Add(btnGues);
            Controls.Add(txtAtempts);
            Controls.Add(txtWon);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnNewGame);
            Controls.Add(txtGues);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gues Number";
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
        private TextBox txtAnsw;
        private ListView listViewGuesses;
        private ColumnHeader columnHeader1;
        private CheckBox checkBoxShow;
    }
}
