namespace Week8_10
{
    partial class Form1
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
            this.lblGuessCount = new System.Windows.Forms.Label();
            this.txtGuessCount = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblGuess = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWinMessage = new System.Windows.Forms.Label();
            this.lblLastGuess = new System.Windows.Forms.Label();
            this.txtLastGuess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGuessCount
            // 
            this.lblGuessCount.AutoSize = true;
            this.lblGuessCount.Location = new System.Drawing.Point(154, 177);
            this.lblGuessCount.Name = "lblGuessCount";
            this.lblGuessCount.Size = new System.Drawing.Size(90, 17);
            this.lblGuessCount.TabIndex = 4;
            this.lblGuessCount.Text = "Guess Count";
            // 
            // txtGuessCount
            // 
            this.txtGuessCount.Enabled = false;
            this.txtGuessCount.Location = new System.Drawing.Point(265, 177);
            this.txtGuessCount.Name = "txtGuessCount";
            this.txtGuessCount.Size = new System.Drawing.Size(47, 22);
            this.txtGuessCount.TabIndex = 5;
            this.txtGuessCount.Text = "0";
            this.txtGuessCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(265, 121);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(265, 77);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess!";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(23, 77);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(103, 17);
            this.lblGuess.TabIndex = 0;
            this.lblGuess.Text = "Guess Number";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(147, 77);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 22);
            this.txtGuess.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(114, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(198, 25);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Guess the Number!";
            // 
            // lblWinMessage
            // 
            this.lblWinMessage.AutoSize = true;
            this.lblWinMessage.Location = new System.Drawing.Point(23, 147);
            this.lblWinMessage.Name = "lblWinMessage";
            this.lblWinMessage.Size = new System.Drawing.Size(0, 17);
            this.lblWinMessage.TabIndex = 7;
            // 
            // lblLastGuess
            // 
            this.lblLastGuess.AutoSize = true;
            this.lblLastGuess.Location = new System.Drawing.Point(342, 46);
            this.lblLastGuess.Name = "lblLastGuess";
            this.lblLastGuess.Size = new System.Drawing.Size(80, 17);
            this.lblLastGuess.TabIndex = 8;
            this.lblLastGuess.Text = "Last Guess";
            // 
            // txtLastGuess
            // 
            this.txtLastGuess.BackColor = System.Drawing.SystemColors.Menu;
            this.txtLastGuess.Enabled = false;
            this.txtLastGuess.Location = new System.Drawing.Point(347, 77);
            this.txtLastGuess.Name = "txtLastGuess";
            this.txtLastGuess.Size = new System.Drawing.Size(75, 22);
            this.txtLastGuess.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(426, 212);
            this.Controls.Add(this.txtLastGuess);
            this.Controls.Add(this.lblLastGuess);
            this.Controls.Add(this.lblWinMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtGuessCount);
            this.Controls.Add(this.lblGuessCount);
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuessCount;
        private System.Windows.Forms.TextBox txtGuessCount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWinMessage;
        private System.Windows.Forms.Label lblLastGuess;
        private System.Windows.Forms.TextBox txtLastGuess;
    }
}

