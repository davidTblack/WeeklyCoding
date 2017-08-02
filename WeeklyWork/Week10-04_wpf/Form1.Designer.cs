namespace Week10_04_wpf
{
    partial class frmAverage
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
            this.lblEnterScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.txtNumberScores = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEnterScore
            // 
            this.lblEnterScore.AutoSize = true;
            this.lblEnterScore.Location = new System.Drawing.Point(13, 43);
            this.lblEnterScore.Name = "lblEnterScore";
            this.lblEnterScore.Size = new System.Drawing.Size(83, 17);
            this.lblEnterScore.TabIndex = 0;
            this.lblEnterScore.Text = "Enter Score";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(102, 43);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(83, 22);
            this.txtScore.TabIndex = 1;
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(191, 43);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(91, 23);
            this.btnAddScore.TabIndex = 2;
            this.btnAddScore.TabStop = false;
            this.btnAddScore.Text = "Add Score";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(13, 105);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(122, 17);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "Number of Scores";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(13, 142);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(102, 17);
            this.lblAverage.TabIndex = 4;
            this.lblAverage.Text = "Average Score";
            // 
            // txtNumberScores
            // 
            this.txtNumberScores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumberScores.Enabled = false;
            this.txtNumberScores.Location = new System.Drawing.Point(141, 105);
            this.txtNumberScores.Name = "txtNumberScores";
            this.txtNumberScores.Size = new System.Drawing.Size(62, 22);
            this.txtNumberScores.TabIndex = 5;
            // 
            // txtAverage
            // 
            this.txtAverage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAverage.Enabled = false;
            this.txtAverage.Location = new System.Drawing.Point(141, 142);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(62, 22);
            this.txtAverage.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(219, 105);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(63, 59);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.ResetApp);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(16, 175);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(48, 17);
            this.lblGrade.TabIndex = 8;
            this.lblGrade.Text = "Grade";
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGrade.Enabled = false;
            this.txtGrade.Location = new System.Drawing.Point(141, 171);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(62, 22);
            this.txtGrade.TabIndex = 9;
            // 
            // frmAverage
            // 
            this.AcceptButton = this.btnAddScore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 204);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtNumberScores);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnAddScore);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblEnterScore);
            this.Name = "frmAverage";
            this.Text = "Average Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox txtNumberScores;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtGrade;
    }
}

