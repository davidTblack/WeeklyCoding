namespace Week8_4
{
    partial class frmMagicMover
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
            this.lblXPosition = new System.Windows.Forms.Label();
            this.lblYPosition = new System.Windows.Forms.Label();
            this.txtXPosition = new System.Windows.Forms.TextBox();
            this.txtYPosition = new System.Windows.Forms.TextBox();
            this.btnMoveIt = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblXPosition
            // 
            this.lblXPosition.AutoSize = true;
            this.lblXPosition.Location = new System.Drawing.Point(43, 66);
            this.lblXPosition.Name = "lblXPosition";
            this.lblXPosition.Size = new System.Drawing.Size(71, 17);
            this.lblXPosition.TabIndex = 0;
            this.lblXPosition.Text = "X Position";
            // 
            // lblYPosition
            // 
            this.lblYPosition.AutoSize = true;
            this.lblYPosition.Location = new System.Drawing.Point(43, 105);
            this.lblYPosition.Name = "lblYPosition";
            this.lblYPosition.Size = new System.Drawing.Size(71, 17);
            this.lblYPosition.TabIndex = 1;
            this.lblYPosition.Text = "Y Position";
            // 
            // txtXPosition
            // 
            this.txtXPosition.Location = new System.Drawing.Point(117, 66);
            this.txtXPosition.Name = "txtXPosition";
            this.txtXPosition.Size = new System.Drawing.Size(100, 22);
            this.txtXPosition.TabIndex = 2;
            this.txtXPosition.TextChanged += new System.EventHandler(this.txtXPosition_TextChanged);
            // 
            // txtYPosition
            // 
            this.txtYPosition.Location = new System.Drawing.Point(117, 102);
            this.txtYPosition.Name = "txtYPosition";
            this.txtYPosition.Size = new System.Drawing.Size(100, 22);
            this.txtYPosition.TabIndex = 3;
            this.txtYPosition.TextChanged += new System.EventHandler(this.txtYPosition_TextChanged);
            // 
            // btnMoveIt
            // 
            this.btnMoveIt.Location = new System.Drawing.Point(129, 149);
            this.btnMoveIt.Name = "btnMoveIt";
            this.btnMoveIt.Size = new System.Drawing.Size(75, 23);
            this.btnMoveIt.TabIndex = 4;
            this.btnMoveIt.Text = "Move it!";
            this.btnMoveIt.UseVisualStyleBackColor = true;
            this.btnMoveIt.Click += new System.EventHandler(this.btnMoveIt_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(41, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 25);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Moving Form Application";
            // 
            // frmMagicMover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(333, 247);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnMoveIt);
            this.Controls.Add(this.txtYPosition);
            this.Controls.Add(this.txtXPosition);
            this.Controls.Add(this.lblYPosition);
            this.Controls.Add(this.lblXPosition);
            this.Name = "frmMagicMover";
            this.Text = "Magical Moving Form!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXPosition;
        private System.Windows.Forms.Label lblYPosition;
        private System.Windows.Forms.TextBox txtXPosition;
        private System.Windows.Forms.TextBox txtYPosition;
        private System.Windows.Forms.Button btnMoveIt;
        private System.Windows.Forms.Label lblTitle;
    }
}

