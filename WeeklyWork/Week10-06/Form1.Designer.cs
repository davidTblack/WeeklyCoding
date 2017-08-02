namespace Week10_06
{
    partial class frmConvertWeights
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.cmboFrom = new System.Windows.Forms.ComboBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.cmboTo = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 27);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(44, 17);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(12, 70);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 17);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "To:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(65, 27);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 22);
            this.txtFrom.TabIndex = 2;
            // 
            // cmboFrom
            // 
            this.cmboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboFrom.FormattingEnabled = true;
            this.cmboFrom.Location = new System.Drawing.Point(182, 27);
            this.cmboFrom.Name = "cmboFrom";
            this.cmboFrom.Size = new System.Drawing.Size(98, 24);
            this.cmboFrom.TabIndex = 3;
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTo.Enabled = false;
            this.txtTo.Location = new System.Drawing.Point(65, 70);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 22);
            this.txtTo.TabIndex = 4;
            // 
            // cmboTo
            // 
            this.cmboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboTo.FormattingEnabled = true;
            this.cmboTo.Location = new System.Drawing.Point(182, 70);
            this.cmboTo.Name = "cmboTo";
            this.cmboTo.Size = new System.Drawing.Size(98, 24);
            this.cmboTo.TabIndex = 5;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(182, 101);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(98, 23);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // frmConvertWeights
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 135);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cmboTo);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.cmboFrom);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Name = "frmConvertWeights";
            this.Text = "Weight Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.ComboBox cmboFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.ComboBox cmboTo;
        private System.Windows.Forms.Button btnConvert;
    }
}

