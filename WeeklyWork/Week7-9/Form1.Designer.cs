namespace Week7_9
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
            this.btnStudent1 = new System.Windows.Forms.Button();
            this.btnStudent2 = new System.Windows.Forms.Button();
            this.btnStudent3 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.txtStudentInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStudent1
            // 
            this.btnStudent1.Location = new System.Drawing.Point(31, 29);
            this.btnStudent1.Name = "btnStudent1";
            this.btnStudent1.Size = new System.Drawing.Size(103, 23);
            this.btnStudent1.TabIndex = 0;
            this.btnStudent1.Text = "Student 1";
            this.btnStudent1.UseVisualStyleBackColor = true;
            this.btnStudent1.Click += new System.EventHandler(this.btnStudent1_Click);
            // 
            // btnStudent2
            // 
            this.btnStudent2.Location = new System.Drawing.Point(171, 29);
            this.btnStudent2.Name = "btnStudent2";
            this.btnStudent2.Size = new System.Drawing.Size(103, 23);
            this.btnStudent2.TabIndex = 1;
            this.btnStudent2.Text = "Student 2";
            this.btnStudent2.UseVisualStyleBackColor = true;
            this.btnStudent2.Click += new System.EventHandler(this.btnStudent2_Click);
            // 
            // btnStudent3
            // 
            this.btnStudent3.Location = new System.Drawing.Point(308, 29);
            this.btnStudent3.Name = "btnStudent3";
            this.btnStudent3.Size = new System.Drawing.Size(103, 23);
            this.btnStudent3.TabIndex = 2;
            this.btnStudent3.Text = "Student 3";
            this.btnStudent3.UseVisualStyleBackColor = true;
            this.btnStudent3.Click += new System.EventHandler(this.btnStudent3_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Student name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(45, 127);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(72, 17);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Student Id";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Enabled = false;
            this.txtStudentName.Location = new System.Drawing.Point(193, 93);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 22);
            this.txtStudentName.TabIndex = 5;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Enabled = false;
            this.txtStudentId.Location = new System.Drawing.Point(193, 124);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(100, 22);
            this.txtStudentId.TabIndex = 6;
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Location = new System.Drawing.Point(45, 158);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(131, 17);
            this.lblStudentInfo.TabIndex = 7;
            this.lblStudentInfo.Text = "Student Information";
            // 
            // txtStudentInfo
            // 
            this.txtStudentInfo.AcceptsReturn = true;
            this.txtStudentInfo.AcceptsTab = true;
            this.txtStudentInfo.Enabled = false;
            this.txtStudentInfo.Location = new System.Drawing.Point(193, 158);
            this.txtStudentInfo.Multiline = true;
            this.txtStudentInfo.Name = "txtStudentInfo";
            this.txtStudentInfo.Size = new System.Drawing.Size(402, 231);
            this.txtStudentInfo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 432);
            this.Controls.Add(this.txtStudentInfo);
            this.Controls.Add(this.lblStudentInfo);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnStudent3);
            this.Controls.Add(this.btnStudent2);
            this.Controls.Add(this.btnStudent1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudent1;
        private System.Windows.Forms.Button btnStudent2;
        private System.Windows.Forms.Button btnStudent3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.TextBox txtStudentInfo;
    }
}

