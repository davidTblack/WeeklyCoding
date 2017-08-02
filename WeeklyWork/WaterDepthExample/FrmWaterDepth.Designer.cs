namespace WaterDepthExample
{
    partial class frmWaterDepth
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
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.grpLowDepths = new System.Windows.Forms.GroupBox();
            this.txtLow4 = new System.Windows.Forms.TextBox();
            this.txtLow3 = new System.Windows.Forms.TextBox();
            this.txtLow2 = new System.Windows.Forms.TextBox();
            this.txtLow1 = new System.Windows.Forms.TextBox();
            this.grpHiDepths = new System.Windows.Forms.GroupBox();
            this.txtHigh4 = new System.Windows.Forms.TextBox();
            this.txtHigh3 = new System.Windows.Forms.TextBox();
            this.txtHigh2 = new System.Windows.Forms.TextBox();
            this.txtHigh1 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.grpState = new System.Windows.Forms.GroupBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtMileMarker = new System.Windows.Forms.TextBox();
            this.grpMileMarker = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.grpLocation.SuspendLayout();
            this.grpLowDepths.SuspendLayout();
            this.grpHiDepths.SuspendLayout();
            this.grpState.SuspendLayout();
            this.grpMileMarker.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLocation
            // 
            this.grpLocation.Controls.Add(this.txtLocation);
            this.grpLocation.Location = new System.Drawing.Point(23, 14);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(128, 61);
            this.grpLocation.TabIndex = 0;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(7, 22);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 22);
            this.txtLocation.TabIndex = 0;
            // 
            // grpLowDepths
            // 
            this.grpLowDepths.Controls.Add(this.txtLow4);
            this.grpLowDepths.Controls.Add(this.txtLow3);
            this.grpLowDepths.Controls.Add(this.txtLow2);
            this.grpLowDepths.Controls.Add(this.txtLow1);
            this.grpLowDepths.Location = new System.Drawing.Point(23, 81);
            this.grpLowDepths.Name = "grpLowDepths";
            this.grpLowDepths.Size = new System.Drawing.Size(149, 148);
            this.grpLowDepths.TabIndex = 1;
            this.grpLowDepths.TabStop = false;
            this.grpLowDepths.Text = "Low Tide Depths";
            // 
            // txtLow4
            // 
            this.txtLow4.Location = new System.Drawing.Point(7, 109);
            this.txtLow4.Name = "txtLow4";
            this.txtLow4.Size = new System.Drawing.Size(100, 22);
            this.txtLow4.TabIndex = 3;
            // 
            // txtLow3
            // 
            this.txtLow3.Location = new System.Drawing.Point(7, 80);
            this.txtLow3.Name = "txtLow3";
            this.txtLow3.Size = new System.Drawing.Size(100, 22);
            this.txtLow3.TabIndex = 2;
            // 
            // txtLow2
            // 
            this.txtLow2.Location = new System.Drawing.Point(7, 51);
            this.txtLow2.Name = "txtLow2";
            this.txtLow2.Size = new System.Drawing.Size(100, 22);
            this.txtLow2.TabIndex = 1;
            // 
            // txtLow1
            // 
            this.txtLow1.Location = new System.Drawing.Point(7, 22);
            this.txtLow1.Name = "txtLow1";
            this.txtLow1.Size = new System.Drawing.Size(100, 22);
            this.txtLow1.TabIndex = 0;
            // 
            // grpHiDepths
            // 
            this.grpHiDepths.Controls.Add(this.txtHigh4);
            this.grpHiDepths.Controls.Add(this.txtHigh3);
            this.grpHiDepths.Controls.Add(this.txtHigh2);
            this.grpHiDepths.Controls.Add(this.txtHigh1);
            this.grpHiDepths.Location = new System.Drawing.Point(178, 81);
            this.grpHiDepths.Name = "grpHiDepths";
            this.grpHiDepths.Size = new System.Drawing.Size(149, 148);
            this.grpHiDepths.TabIndex = 4;
            this.grpHiDepths.TabStop = false;
            this.grpHiDepths.Text = "High Tide Depths";
            // 
            // txtHigh4
            // 
            this.txtHigh4.Location = new System.Drawing.Point(7, 109);
            this.txtHigh4.Name = "txtHigh4";
            this.txtHigh4.Size = new System.Drawing.Size(100, 22);
            this.txtHigh4.TabIndex = 3;
            // 
            // txtHigh3
            // 
            this.txtHigh3.Location = new System.Drawing.Point(7, 80);
            this.txtHigh3.Name = "txtHigh3";
            this.txtHigh3.Size = new System.Drawing.Size(100, 22);
            this.txtHigh3.TabIndex = 2;
            // 
            // txtHigh2
            // 
            this.txtHigh2.Location = new System.Drawing.Point(7, 51);
            this.txtHigh2.Name = "txtHigh2";
            this.txtHigh2.Size = new System.Drawing.Size(100, 22);
            this.txtHigh2.TabIndex = 1;
            // 
            // txtHigh1
            // 
            this.txtHigh1.Location = new System.Drawing.Point(7, 22);
            this.txtHigh1.Name = "txtHigh1";
            this.txtHigh1.Size = new System.Drawing.Size(100, 22);
            this.txtHigh1.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(185, 251);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 100;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // grpState
            // 
            this.grpState.Controls.Add(this.txtState);
            this.grpState.Location = new System.Drawing.Point(178, 14);
            this.grpState.Name = "grpState";
            this.grpState.Size = new System.Drawing.Size(128, 61);
            this.grpState.TabIndex = 1;
            this.grpState.TabStop = false;
            this.grpState.Text = "State";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(7, 22);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 22);
            this.txtState.TabIndex = 0;
            // 
            // txtMileMarker
            // 
            this.txtMileMarker.Location = new System.Drawing.Point(7, 22);
            this.txtMileMarker.Name = "txtMileMarker";
            this.txtMileMarker.Size = new System.Drawing.Size(100, 22);
            this.txtMileMarker.TabIndex = 99;
            // 
            // grpMileMarker
            // 
            this.grpMileMarker.Controls.Add(this.txtMileMarker);
            this.grpMileMarker.Location = new System.Drawing.Point(30, 235);
            this.grpMileMarker.Name = "grpMileMarker";
            this.grpMileMarker.Size = new System.Drawing.Size(128, 61);
            this.grpMileMarker.TabIndex = 2;
            this.grpMileMarker.TabStop = false;
            this.grpMileMarker.Text = "MileMarker";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(27, 313);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 6;
            // 
            // frmWaterDepth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 354);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.grpMileMarker);
            this.Controls.Add(this.grpState);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpHiDepths);
            this.Controls.Add(this.grpLowDepths);
            this.Controls.Add(this.grpLocation);
            this.Name = "frmWaterDepth";
            this.Text = "Water Depth";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWaterDepth_FormClosing);
            this.Load += new System.EventHandler(this.frmWaterDepth_Load);
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            this.grpLowDepths.ResumeLayout(false);
            this.grpLowDepths.PerformLayout();
            this.grpHiDepths.ResumeLayout(false);
            this.grpHiDepths.PerformLayout();
            this.grpState.ResumeLayout(false);
            this.grpState.PerformLayout();
            this.grpMileMarker.ResumeLayout(false);
            this.grpMileMarker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.GroupBox grpLowDepths;
        private System.Windows.Forms.TextBox txtLow4;
        private System.Windows.Forms.TextBox txtLow3;
        private System.Windows.Forms.TextBox txtLow2;
        private System.Windows.Forms.TextBox txtLow1;
        private System.Windows.Forms.GroupBox grpHiDepths;
        private System.Windows.Forms.TextBox txtHigh4;
        private System.Windows.Forms.TextBox txtHigh3;
        private System.Windows.Forms.TextBox txtHigh2;
        private System.Windows.Forms.TextBox txtHigh1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtMileMarker;
        private System.Windows.Forms.GroupBox grpMileMarker;
        private System.Windows.Forms.Label lblError;
    }
}

