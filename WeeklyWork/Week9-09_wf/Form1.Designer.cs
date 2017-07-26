namespace Week9_09_wf
{
    partial class frmFlooring
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
            this.txtLenFeet = new System.Windows.Forms.TextBox();
            this.txtWidFeet = new System.Windows.Forms.TextBox();
            this.lblLenFeet = new System.Windows.Forms.Label();
            this.lblLenInches = new System.Windows.Forms.Label();
            this.lblWidFeet = new System.Windows.Forms.Label();
            this.lblWidInches = new System.Windows.Forms.Label();
            this.txtLenInches = new System.Windows.Forms.TextBox();
            this.txtWidInches = new System.Windows.Forms.TextBox();
            this.grpLength = new System.Windows.Forms.GroupBox();
            this.grpWidth = new System.Windows.Forms.GroupBox();
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabHardwood = new System.Windows.Forms.TabPage();
            this.tabCarpet = new System.Windows.Forms.TabPage();
            this.tabLaminate = new System.Windows.Forms.TabPage();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.radBtnOak = new System.Windows.Forms.RadioButton();
            this.radBtnMaple = new System.Windows.Forms.RadioButton();
            this.radBtnWalnut = new System.Windows.Forms.RadioButton();
            this.radBtnCherry = new System.Windows.Forms.RadioButton();
            this.radBtnShag = new System.Windows.Forms.RadioButton();
            this.radBtnStandard = new System.Windows.Forms.RadioButton();
            this.radBtnSolidLaminate = new System.Windows.Forms.RadioButton();
            this.radBtnTiledLaminate = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpLength.SuspendLayout();
            this.grpWidth.SuspendLayout();
            this.tabCtrl.SuspendLayout();
            this.tabHardwood.SuspendLayout();
            this.tabCarpet.SuspendLayout();
            this.tabLaminate.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLenFeet
            // 
            this.txtLenFeet.Location = new System.Drawing.Point(67, 36);
            this.txtLenFeet.Name = "txtLenFeet";
            this.txtLenFeet.Size = new System.Drawing.Size(100, 22);
            this.txtLenFeet.TabIndex = 1;
            // 
            // txtWidFeet
            // 
            this.txtWidFeet.Location = new System.Drawing.Point(67, 35);
            this.txtWidFeet.Name = "txtWidFeet";
            this.txtWidFeet.Size = new System.Drawing.Size(100, 22);
            this.txtWidFeet.TabIndex = 3;
            // 
            // lblLenFeet
            // 
            this.lblLenFeet.AutoSize = true;
            this.lblLenFeet.Location = new System.Drawing.Point(6, 36);
            this.lblLenFeet.Name = "lblLenFeet";
            this.lblLenFeet.Size = new System.Drawing.Size(36, 17);
            this.lblLenFeet.TabIndex = 4;
            this.lblLenFeet.Text = "Feet";
            // 
            // lblLenInches
            // 
            this.lblLenInches.AutoSize = true;
            this.lblLenInches.Location = new System.Drawing.Point(189, 36);
            this.lblLenInches.Name = "lblLenInches";
            this.lblLenInches.Size = new System.Drawing.Size(49, 17);
            this.lblLenInches.TabIndex = 5;
            this.lblLenInches.Text = "Inches";
            // 
            // lblWidFeet
            // 
            this.lblWidFeet.AutoSize = true;
            this.lblWidFeet.Location = new System.Drawing.Point(6, 35);
            this.lblWidFeet.Name = "lblWidFeet";
            this.lblWidFeet.Size = new System.Drawing.Size(36, 17);
            this.lblWidFeet.TabIndex = 6;
            this.lblWidFeet.Text = "Feet";
            // 
            // lblWidInches
            // 
            this.lblWidInches.AutoSize = true;
            this.lblWidInches.Location = new System.Drawing.Point(192, 35);
            this.lblWidInches.Name = "lblWidInches";
            this.lblWidInches.Size = new System.Drawing.Size(49, 17);
            this.lblWidInches.TabIndex = 7;
            this.lblWidInches.Text = "Inches";
            // 
            // txtLenInches
            // 
            this.txtLenInches.Location = new System.Drawing.Point(260, 36);
            this.txtLenInches.Name = "txtLenInches";
            this.txtLenInches.Size = new System.Drawing.Size(100, 22);
            this.txtLenInches.TabIndex = 2;
            // 
            // txtWidInches
            // 
            this.txtWidInches.Location = new System.Drawing.Point(260, 35);
            this.txtWidInches.Name = "txtWidInches";
            this.txtWidInches.Size = new System.Drawing.Size(100, 22);
            this.txtWidInches.TabIndex = 4;
            // 
            // grpLength
            // 
            this.grpLength.Controls.Add(this.lblLenFeet);
            this.grpLength.Controls.Add(this.txtLenFeet);
            this.grpLength.Controls.Add(this.txtLenInches);
            this.grpLength.Controls.Add(this.lblLenInches);
            this.grpLength.Location = new System.Drawing.Point(16, 39);
            this.grpLength.Name = "grpLength";
            this.grpLength.Size = new System.Drawing.Size(373, 85);
            this.grpLength.TabIndex = 10;
            this.grpLength.TabStop = false;
            this.grpLength.Text = "Length";
            // 
            // grpWidth
            // 
            this.grpWidth.Controls.Add(this.lblWidFeet);
            this.grpWidth.Controls.Add(this.txtWidFeet);
            this.grpWidth.Controls.Add(this.txtWidInches);
            this.grpWidth.Controls.Add(this.lblWidInches);
            this.grpWidth.Location = new System.Drawing.Point(16, 135);
            this.grpWidth.Name = "grpWidth";
            this.grpWidth.Size = new System.Drawing.Size(373, 85);
            this.grpWidth.TabIndex = 11;
            this.grpWidth.TabStop = false;
            this.grpWidth.Text = "Width";
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabHardwood);
            this.tabCtrl.Controls.Add(this.tabCarpet);
            this.tabCtrl.Controls.Add(this.tabLaminate);
            this.tabCtrl.Location = new System.Drawing.Point(450, 39);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(401, 181);
            this.tabCtrl.TabIndex = 12;
            this.tabCtrl.SelectedIndexChanged += new System.EventHandler(this.tabCtrl_SelectedIndexChanged);
            // 
            // tabHardwood
            // 
            this.tabHardwood.Controls.Add(this.radBtnCherry);
            this.tabHardwood.Controls.Add(this.radBtnWalnut);
            this.tabHardwood.Controls.Add(this.radBtnMaple);
            this.tabHardwood.Controls.Add(this.radBtnOak);
            this.tabHardwood.Location = new System.Drawing.Point(4, 25);
            this.tabHardwood.Name = "tabHardwood";
            this.tabHardwood.Padding = new System.Windows.Forms.Padding(3);
            this.tabHardwood.Size = new System.Drawing.Size(393, 152);
            this.tabHardwood.TabIndex = 0;
            this.tabHardwood.Text = "Hardwood";
            this.tabHardwood.UseVisualStyleBackColor = true;
            // 
            // tabCarpet
            // 
            this.tabCarpet.Controls.Add(this.radBtnStandard);
            this.tabCarpet.Controls.Add(this.radBtnShag);
            this.tabCarpet.Location = new System.Drawing.Point(4, 25);
            this.tabCarpet.Name = "tabCarpet";
            this.tabCarpet.Padding = new System.Windows.Forms.Padding(3);
            this.tabCarpet.Size = new System.Drawing.Size(393, 152);
            this.tabCarpet.TabIndex = 1;
            this.tabCarpet.Text = "Carpet";
            this.tabCarpet.UseVisualStyleBackColor = true;
            // 
            // tabLaminate
            // 
            this.tabLaminate.Controls.Add(this.radBtnTiledLaminate);
            this.tabLaminate.Controls.Add(this.radBtnSolidLaminate);
            this.tabLaminate.Location = new System.Drawing.Point(4, 25);
            this.tabLaminate.Name = "tabLaminate";
            this.tabLaminate.Size = new System.Drawing.Size(393, 152);
            this.tabLaminate.TabIndex = 2;
            this.tabLaminate.Text = "Laminate";
            this.tabLaminate.UseVisualStyleBackColor = true;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(16, 236);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(72, 17);
            this.lblTotalCost.TabIndex = 13;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Enabled = false;
            this.txtTotalCost.Location = new System.Drawing.Point(118, 236);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(100, 22);
            this.txtTotalCost.TabIndex = 14;
            // 
            // radBtnOak
            // 
            this.radBtnOak.AutoSize = true;
            this.radBtnOak.Location = new System.Drawing.Point(17, 12);
            this.radBtnOak.Name = "radBtnOak";
            this.radBtnOak.Size = new System.Drawing.Size(222, 21);
            this.radBtnOak.TabIndex = 0;
            this.radBtnOak.TabStop = true;
            this.radBtnOak.Text = "Oak -- $41.95 per square yard";
            this.radBtnOak.UseVisualStyleBackColor = true;
            // 
            // radBtnMaple
            // 
            this.radBtnMaple.AutoSize = true;
            this.radBtnMaple.Location = new System.Drawing.Point(17, 39);
            this.radBtnMaple.Name = "radBtnMaple";
            this.radBtnMaple.Size = new System.Drawing.Size(234, 21);
            this.radBtnMaple.TabIndex = 1;
            this.radBtnMaple.TabStop = true;
            this.radBtnMaple.Text = "Maple -- $37.88 per square yard";
            this.radBtnMaple.UseVisualStyleBackColor = true;
            // 
            // radBtnWalnut
            // 
            this.radBtnWalnut.AutoSize = true;
            this.radBtnWalnut.Location = new System.Drawing.Point(17, 66);
            this.radBtnWalnut.Name = "radBtnWalnut";
            this.radBtnWalnut.Size = new System.Drawing.Size(240, 21);
            this.radBtnWalnut.TabIndex = 2;
            this.radBtnWalnut.TabStop = true;
            this.radBtnWalnut.Text = "Walnut -- $35.08 per square yard";
            this.radBtnWalnut.UseVisualStyleBackColor = true;
            // 
            // radBtnCherry
            // 
            this.radBtnCherry.AutoSize = true;
            this.radBtnCherry.Location = new System.Drawing.Point(17, 93);
            this.radBtnCherry.Name = "radBtnCherry";
            this.radBtnCherry.Size = new System.Drawing.Size(238, 21);
            this.radBtnCherry.TabIndex = 3;
            this.radBtnCherry.TabStop = true;
            this.radBtnCherry.Text = "Cherry -- $41.95 per square yard";
            this.radBtnCherry.UseVisualStyleBackColor = true;
            // 
            // radBtnShag
            // 
            this.radBtnShag.AutoSize = true;
            this.radBtnShag.Location = new System.Drawing.Point(22, 11);
            this.radBtnShag.Name = "radBtnShag";
            this.radBtnShag.Size = new System.Drawing.Size(229, 21);
            this.radBtnShag.TabIndex = 0;
            this.radBtnShag.TabStop = true;
            this.radBtnShag.Text = "Shag -- $20.98 per square yard";
            this.radBtnShag.UseVisualStyleBackColor = true;
            // 
            // radBtnStandard
            // 
            this.radBtnStandard.AutoSize = true;
            this.radBtnStandard.Location = new System.Drawing.Point(22, 38);
            this.radBtnStandard.Name = "radBtnStandard";
            this.radBtnStandard.Size = new System.Drawing.Size(254, 21);
            this.radBtnStandard.TabIndex = 1;
            this.radBtnStandard.TabStop = true;
            this.radBtnStandard.Text = "Standard -- $15.67 per square yard";
            this.radBtnStandard.UseVisualStyleBackColor = true;
            // 
            // radBtnSolidLaminate
            // 
            this.radBtnSolidLaminate.AutoSize = true;
            this.radBtnSolidLaminate.Location = new System.Drawing.Point(20, 11);
            this.radBtnSolidLaminate.Name = "radBtnSolidLaminate";
            this.radBtnSolidLaminate.Size = new System.Drawing.Size(281, 21);
            this.radBtnSolidLaminate.TabIndex = 0;
            this.radBtnSolidLaminate.TabStop = true;
            this.radBtnSolidLaminate.Text = "Solid Laminate -- $3.44 per square yard";
            this.radBtnSolidLaminate.UseVisualStyleBackColor = true;
            // 
            // radBtnTiledLaminate
            // 
            this.radBtnTiledLaminate.AutoSize = true;
            this.radBtnTiledLaminate.Location = new System.Drawing.Point(20, 39);
            this.radBtnTiledLaminate.Name = "radBtnTiledLaminate";
            this.radBtnTiledLaminate.Size = new System.Drawing.Size(281, 21);
            this.radBtnTiledLaminate.TabIndex = 1;
            this.radBtnTiledLaminate.TabStop = true;
            this.radBtnTiledLaminate.Text = "Tiled Laminate -- $5.44 per square yard";
            this.radBtnTiledLaminate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(361, 236);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear Selections";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(256, 235);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 23);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmFlooring
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 283);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.tabCtrl);
            this.Controls.Add(this.grpWidth);
            this.Controls.Add(this.grpLength);
            this.Name = "frmFlooring";
            this.Text = "The Flooring Fortress!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLength.ResumeLayout(false);
            this.grpLength.PerformLayout();
            this.grpWidth.ResumeLayout(false);
            this.grpWidth.PerformLayout();
            this.tabCtrl.ResumeLayout(false);
            this.tabHardwood.ResumeLayout(false);
            this.tabHardwood.PerformLayout();
            this.tabCarpet.ResumeLayout(false);
            this.tabCarpet.PerformLayout();
            this.tabLaminate.ResumeLayout(false);
            this.tabLaminate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLenFeet;
        private System.Windows.Forms.TextBox txtWidFeet;
        private System.Windows.Forms.Label lblLenFeet;
        private System.Windows.Forms.Label lblLenInches;
        private System.Windows.Forms.Label lblWidFeet;
        private System.Windows.Forms.Label lblWidInches;
        private System.Windows.Forms.TextBox txtLenInches;
        private System.Windows.Forms.TextBox txtWidInches;
        private System.Windows.Forms.GroupBox grpLength;
        private System.Windows.Forms.GroupBox grpWidth;
        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabHardwood;
        private System.Windows.Forms.TabPage tabCarpet;
        private System.Windows.Forms.TabPage tabLaminate;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.RadioButton radBtnCherry;
        private System.Windows.Forms.RadioButton radBtnWalnut;
        private System.Windows.Forms.RadioButton radBtnMaple;
        private System.Windows.Forms.RadioButton radBtnOak;
        private System.Windows.Forms.RadioButton radBtnStandard;
        private System.Windows.Forms.RadioButton radBtnShag;
        private System.Windows.Forms.RadioButton radBtnTiledLaminate;
        private System.Windows.Forms.RadioButton radBtnSolidLaminate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
    }
}

