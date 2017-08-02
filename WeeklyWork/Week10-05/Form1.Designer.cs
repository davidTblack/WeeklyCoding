namespace Week10_05
{
    partial class frmFractions
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
            this.lblNumerator = new System.Windows.Forms.Label();
            this.lblDenominator = new System.Windows.Forms.Label();
            this.txtNumerator = new System.Windows.Forms.TextBox();
            this.txtDenominator = new System.Windows.Forms.TextBox();
            this.btnSetFraction = new System.Windows.Forms.Button();
            this.lblFraction = new System.Windows.Forms.Label();
            this.btnReduceFraction = new System.Windows.Forms.Button();
            this.txtFractionDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumerator
            // 
            this.lblNumerator.AutoSize = true;
            this.lblNumerator.Location = new System.Drawing.Point(16, 22);
            this.lblNumerator.Name = "lblNumerator";
            this.lblNumerator.Size = new System.Drawing.Size(75, 17);
            this.lblNumerator.TabIndex = 0;
            this.lblNumerator.Text = "Numerator";
            // 
            // lblDenominator
            // 
            this.lblDenominator.AutoSize = true;
            this.lblDenominator.Location = new System.Drawing.Point(16, 54);
            this.lblDenominator.Name = "lblDenominator";
            this.lblDenominator.Size = new System.Drawing.Size(89, 17);
            this.lblDenominator.TabIndex = 1;
            this.lblDenominator.Text = "Denominator";
            // 
            // txtNumerator
            // 
            this.txtNumerator.Location = new System.Drawing.Point(109, 22);
            this.txtNumerator.Name = "txtNumerator";
            this.txtNumerator.Size = new System.Drawing.Size(78, 22);
            this.txtNumerator.TabIndex = 2;
            // 
            // txtDenominator
            // 
            this.txtDenominator.Location = new System.Drawing.Point(109, 49);
            this.txtDenominator.Name = "txtDenominator";
            this.txtDenominator.Size = new System.Drawing.Size(78, 22);
            this.txtDenominator.TabIndex = 3;
            // 
            // btnSetFraction
            // 
            this.btnSetFraction.Location = new System.Drawing.Point(48, 91);
            this.btnSetFraction.Name = "btnSetFraction";
            this.btnSetFraction.Size = new System.Drawing.Size(139, 36);
            this.btnSetFraction.TabIndex = 4;
            this.btnSetFraction.Text = "Set Your Fraction";
            this.btnSetFraction.UseVisualStyleBackColor = true;
            this.btnSetFraction.Click += new System.EventHandler(this.btnSetFraction_Click);
            // 
            // lblFraction
            // 
            this.lblFraction.AutoSize = true;
            this.lblFraction.Location = new System.Drawing.Point(217, 22);
            this.lblFraction.Name = "lblFraction";
            this.lblFraction.Size = new System.Drawing.Size(97, 17);
            this.lblFraction.TabIndex = 5;
            this.lblFraction.Text = "Your Fraction:";
            // 
            // btnReduceFraction
            // 
            this.btnReduceFraction.Location = new System.Drawing.Point(273, 91);
            this.btnReduceFraction.Name = "btnReduceFraction";
            this.btnReduceFraction.Size = new System.Drawing.Size(148, 36);
            this.btnReduceFraction.TabIndex = 6;
            this.btnReduceFraction.Text = "Reduce Fraction";
            this.btnReduceFraction.UseVisualStyleBackColor = true;
            this.btnReduceFraction.Click += new System.EventHandler(this.btnReduceFraction_Click);
            // 
            // txtFractionDisplay
            // 
            this.txtFractionDisplay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFractionDisplay.Enabled = false;
            this.txtFractionDisplay.Location = new System.Drawing.Point(321, 22);
            this.txtFractionDisplay.Name = "txtFractionDisplay";
            this.txtFractionDisplay.Size = new System.Drawing.Size(100, 22);
            this.txtFractionDisplay.TabIndex = 7;
            // 
            // frmFractions
            // 
            this.AcceptButton = this.btnSetFraction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 144);
            this.Controls.Add(this.txtFractionDisplay);
            this.Controls.Add(this.btnReduceFraction);
            this.Controls.Add(this.lblFraction);
            this.Controls.Add(this.btnSetFraction);
            this.Controls.Add(this.txtDenominator);
            this.Controls.Add(this.txtNumerator);
            this.Controls.Add(this.lblDenominator);
            this.Controls.Add(this.lblNumerator);
            this.Name = "frmFractions";
            this.Text = "Fractions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumerator;
        private System.Windows.Forms.Label lblDenominator;
        private System.Windows.Forms.TextBox txtNumerator;
        private System.Windows.Forms.TextBox txtDenominator;
        private System.Windows.Forms.Button btnSetFraction;
        private System.Windows.Forms.Label lblFraction;
        private System.Windows.Forms.Button btnReduceFraction;
        private System.Windows.Forms.TextBox txtFractionDisplay;
    }
}

