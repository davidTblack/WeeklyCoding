namespace Week9_06_wf
{
    partial class frmBagOrder
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
            this.lblType = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstBxTypes = new System.Windows.Forms.ListBox();
            this.cmboQuantity = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(13, 13);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 17);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Types";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(16, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstBxTypes
            // 
            this.lstBxTypes.FormattingEnabled = true;
            this.lstBxTypes.ItemHeight = 16;
            this.lstBxTypes.Items.AddRange(new object[] {
            "Full Decorative",
            "Beaded",
            "Pirate Design",
            "Fringed",
            "Leather",
            "Plain"});
            this.lstBxTypes.Location = new System.Drawing.Point(88, 13);
            this.lstBxTypes.Name = "lstBxTypes";
            this.lstBxTypes.Size = new System.Drawing.Size(111, 100);
            this.lstBxTypes.TabIndex = 2;
            this.lstBxTypes.SelectedIndexChanged += new System.EventHandler(this.SelectionMade);
            // 
            // cmboQuantity
            // 
            this.cmboQuantity.FormattingEnabled = true;
            this.cmboQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmboQuantity.Location = new System.Drawing.Point(88, 130);
            this.cmboQuantity.Name = "cmboQuantity";
            this.cmboQuantity.Size = new System.Drawing.Size(37, 24);
            this.cmboQuantity.TabIndex = 3;
            this.cmboQuantity.Text = "1";
            this.cmboQuantity.SelectedIndexChanged += new System.EventHandler(this.SelectionMade);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AllowDrop = true;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(16, 130);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            // 
            // frmBagOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 246);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cmboQuantity);
            this.Controls.Add(this.lstBxTypes);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblType);
            this.Name = "frmBagOrder";
            this.Text = "Bags R Us";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstBxTypes;
        private System.Windows.Forms.ComboBox cmboQuantity;
        private System.Windows.Forms.Label lblQuantity;
    }
}

