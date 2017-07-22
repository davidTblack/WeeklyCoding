namespace Week8_5
{
    partial class frmTripCalculator
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblGallons = new System.Windows.Forms.Label();
            this.lblMiles = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.txtGallons = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMpg = new System.Windows.Forms.Label();
            this.txtMpg = new System.Windows.Forms.TextBox();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.txtGallons);
            this.grpInput.Controls.Add(this.txtMiles);
            this.grpInput.Controls.Add(this.txtDestination);
            this.grpInput.Controls.Add(this.lblGallons);
            this.grpInput.Controls.Add(this.lblMiles);
            this.grpInput.Controls.Add(this.lblDestination);
            this.grpInput.Location = new System.Drawing.Point(13, 13);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(258, 178);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // lblGallons
            // 
            this.lblGallons.AutoSize = true;
            this.lblGallons.Location = new System.Drawing.Point(10, 112);
            this.lblGallons.Name = "lblGallons";
            this.lblGallons.Size = new System.Drawing.Size(93, 17);
            this.lblGallons.TabIndex = 2;
            this.lblGallons.Text = "Gallons Used";
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(10, 67);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(100, 17);
            this.lblMiles.TabIndex = 1;
            this.lblMiles.Text = "Miles Traveled";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(10, 22);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(79, 17);
            this.lblDestination.TabIndex = 0;
            this.lblDestination.Text = "Destination";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.txtMpg);
            this.grpOutput.Controls.Add(this.lblMpg);
            this.grpOutput.Location = new System.Drawing.Point(336, 13);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(258, 129);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(13, 43);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(239, 22);
            this.txtDestination.TabIndex = 3;
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(10, 86);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(239, 22);
            this.txtMiles.TabIndex = 4;
            this.txtMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGallons
            // 
            this.txtGallons.Location = new System.Drawing.Point(10, 131);
            this.txtGallons.Name = "txtGallons";
            this.txtGallons.Size = new System.Drawing.Size(239, 22);
            this.txtGallons.TabIndex = 5;
            this.txtGallons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCompute.Location = new System.Drawing.Point(278, 46);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(52, 62);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "=>";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(428, 149);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 28);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMpg
            // 
            this.lblMpg.AutoSize = true;
            this.lblMpg.Location = new System.Drawing.Point(14, 22);
            this.lblMpg.Name = "lblMpg";
            this.lblMpg.Size = new System.Drawing.Size(111, 17);
            this.lblMpg.TabIndex = 0;
            this.lblMpg.Text = "Miles Per Gallon";
            // 
            // txtMpg
            // 
            this.txtMpg.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtMpg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMpg.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMpg.Location = new System.Drawing.Point(18, 72);
            this.txtMpg.Name = "txtMpg";
            this.txtMpg.Size = new System.Drawing.Size(223, 38);
            this.txtMpg.TabIndex = 1;
            this.txtMpg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmTripCalculator
            // 
            this.AcceptButton = this.btnCompute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(607, 203);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.ForeColor = System.Drawing.Color.Chartreuse;
            this.Location = new System.Drawing.Point(300, 200);
            this.Name = "frmTripCalculator";
            this.Text = "Trip Calculator";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblGallons;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.TextBox txtGallons;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label lblMpg;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtMpg;
    }
}

