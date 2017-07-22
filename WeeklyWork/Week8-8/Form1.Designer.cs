namespace Week8_8
{
    partial class frmDistanceApp
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
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtCalculatedDistance = new System.Windows.Forms.TextBox();
            this.btnCalculateDistance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(46, 29);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(90, 17);
            this.lblSpeed.TabIndex = 0;
            this.lblSpeed.Text = "Speed (mph)";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(45, 69);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(91, 17);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time (Hours)";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(147, 26);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 22);
            this.txtSpeed.TabIndex = 2;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(147, 66);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 22);
            this.txtTime.TabIndex = 3;
            // 
            // txtCalculatedDistance
            // 
            this.txtCalculatedDistance.Location = new System.Drawing.Point(147, 143);
            this.txtCalculatedDistance.Name = "txtCalculatedDistance";
            this.txtCalculatedDistance.Size = new System.Drawing.Size(100, 22);
            this.txtCalculatedDistance.TabIndex = 4;
            // 
            // btnCalculateDistance
            // 
            this.btnCalculateDistance.Location = new System.Drawing.Point(16, 143);
            this.btnCalculateDistance.Name = "btnCalculateDistance";
            this.btnCalculateDistance.Size = new System.Drawing.Size(120, 23);
            this.btnCalculateDistance.TabIndex = 5;
            this.btnCalculateDistance.Text = "Find Distance";
            this.btnCalculateDistance.UseVisualStyleBackColor = true;
            this.btnCalculateDistance.Click += new System.EventHandler(this.btnCalculateDistance_Click);
            // 
            // frmDistanceApp
            // 
            this.AcceptButton = this.btnCalculateDistance;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 194);
            this.Controls.Add(this.btnCalculateDistance);
            this.Controls.Add(this.txtCalculatedDistance);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblSpeed);
            this.Name = "frmDistanceApp";
            this.Text = "Distance Calculator";
            this.Load += new System.EventHandler(this.frmDistanceApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtCalculatedDistance;
        private System.Windows.Forms.Button btnCalculateDistance;
    }
}

