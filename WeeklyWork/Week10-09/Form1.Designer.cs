namespace Week10_09
{
    partial class frmCharacterCounter
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
            this.txtCharacterEntry = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCountDown = new System.Windows.Forms.Label();
            this.txtCharRemaining = new System.Windows.Forms.TextBox();
            this.lblCharacterCount = new System.Windows.Forms.Label();
            this.txtCharCount = new System.Windows.Forms.TextBox();
            this.btnCaclulateCounts = new System.Windows.Forms.Button();
            this.txtCharCountBreakdown = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCharacterEntry
            // 
            this.txtCharacterEntry.Location = new System.Drawing.Point(13, 58);
            this.txtCharacterEntry.Multiline = true;
            this.txtCharacterEntry.Name = "txtCharacterEntry";
            this.txtCharacterEntry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCharacterEntry.Size = new System.Drawing.Size(422, 552);
            this.txtCharacterEntry.TabIndex = 0;
            this.txtCharacterEntry.SizeChanged += new System.EventHandler(this.txtCharacterEntry_SizeChanged);
            this.txtCharacterEntry.TextChanged += new System.EventHandler(this.txtCharacterEntry_SizeChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 17);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Enter a paragraph below and see the character count.";
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.Location = new System.Drawing.Point(147, 639);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(182, 17);
            this.lblCountDown.TabIndex = 2;
            this.lblCountDown.Text = "Max Char 500.  Remaining: ";
            // 
            // txtCharRemaining
            // 
            this.txtCharRemaining.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCharRemaining.Enabled = false;
            this.txtCharRemaining.Location = new System.Drawing.Point(336, 639);
            this.txtCharRemaining.Name = "txtCharRemaining";
            this.txtCharRemaining.Size = new System.Drawing.Size(100, 22);
            this.txtCharRemaining.TabIndex = 3;
            // 
            // lblCharacterCount
            // 
            this.lblCharacterCount.AutoSize = true;
            this.lblCharacterCount.Location = new System.Drawing.Point(147, 668);
            this.lblCharacterCount.Name = "lblCharacterCount";
            this.lblCharacterCount.Size = new System.Drawing.Size(111, 17);
            this.lblCharacterCount.TabIndex = 4;
            this.lblCharacterCount.Text = "Character Count";
            // 
            // txtCharCount
            // 
            this.txtCharCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCharCount.Enabled = false;
            this.txtCharCount.Location = new System.Drawing.Point(335, 668);
            this.txtCharCount.Name = "txtCharCount";
            this.txtCharCount.Size = new System.Drawing.Size(100, 22);
            this.txtCharCount.TabIndex = 5;
            // 
            // btnCaclulateCounts
            // 
            this.btnCaclulateCounts.Location = new System.Drawing.Point(16, 636);
            this.btnCaclulateCounts.Name = "btnCaclulateCounts";
            this.btnCaclulateCounts.Size = new System.Drawing.Size(125, 25);
            this.btnCaclulateCounts.TabIndex = 6;
            this.btnCaclulateCounts.Text = "Calculate Counts";
            this.btnCaclulateCounts.UseVisualStyleBackColor = true;
            this.btnCaclulateCounts.Click += new System.EventHandler(this.btnCaclulateCounts_Click);
            // 
            // txtCharCountBreakdown
            // 
            this.txtCharCountBreakdown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCharCountBreakdown.Enabled = false;
            this.txtCharCountBreakdown.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharCountBreakdown.Location = new System.Drawing.Point(465, 58);
            this.txtCharCountBreakdown.Multiline = true;
            this.txtCharCountBreakdown.Name = "txtCharCountBreakdown";
            this.txtCharCountBreakdown.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCharCountBreakdown.Size = new System.Drawing.Size(186, 632);
            this.txtCharCountBreakdown.TabIndex = 7;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(16, 666);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmCharacterCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 720);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtCharCountBreakdown);
            this.Controls.Add(this.btnCaclulateCounts);
            this.Controls.Add(this.txtCharCount);
            this.Controls.Add(this.lblCharacterCount);
            this.Controls.Add(this.txtCharRemaining);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtCharacterEntry);
            this.Name = "frmCharacterCounter";
            this.Text = "Character Counter";
            this.Load += new System.EventHandler(this.frmCharacterCounter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCharacterEntry;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCountDown;
        private System.Windows.Forms.TextBox txtCharRemaining;
        private System.Windows.Forms.Label lblCharacterCount;
        private System.Windows.Forms.TextBox txtCharCount;
        private System.Windows.Forms.Button btnCaclulateCounts;
        private System.Windows.Forms.TextBox txtCharCountBreakdown;
        private System.Windows.Forms.Button btnReset;
    }
}

