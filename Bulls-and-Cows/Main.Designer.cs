namespace Bulls_and_Cows
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtTry = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtCheck
            // 
            this.txtCheck.Location = new System.Drawing.Point(12, 230);
            this.txtCheck.MaxLength = 4;
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(100, 20);
            this.txtCheck.TabIndex = 0;
            this.txtCheck.TextChanged += new System.EventHandler(this.txtCheck_TextChanged);
            this.txtCheck.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCheck_KeyUp);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(118, 227);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Проверить";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(12, 269);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(181, 23);
            this.btnNewGame.TabIndex = 3;
            this.btnNewGame.Text = "Новая игра";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(12, 344);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "label1";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(162, 344);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(31, 13);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "0000";
            // 
            // txtTry
            // 
            this.txtTry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTry.Location = new System.Drawing.Point(12, 9);
            this.txtTry.Name = "txtTry";
            this.txtTry.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtTry.Size = new System.Drawing.Size(181, 201);
            this.txtTry.TabIndex = 6;
            this.txtTry.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 367);
            this.Controls.Add(this.txtTry);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Быки и Коровы";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCheck;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RichTextBox txtTry;
    }
}

