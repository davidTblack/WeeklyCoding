namespace Week7_8
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
            this.btnAddNewMaterial = new System.Windows.Forms.Button();
            this.grpMaterialTypes = new System.Windows.Forms.GroupBox();
            this.radBtnBook = new System.Windows.Forms.RadioButton();
            this.radBtnMagazine = new System.Windows.Forms.RadioButton();
            this.radBtnOnline = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.lblIssue = new System.Windows.Forms.Label();
            this.txtIssue = new System.Windows.Forms.TextBox();
            this.chkbxIsHardCover = new System.Windows.Forms.CheckBox();
            this.grpIssueFrequency = new System.Windows.Forms.GroupBox();
            this.radBtnWeekly = new System.Windows.Forms.RadioButton();
            this.radBtnMonthly = new System.Windows.Forms.RadioButton();
            this.chkBxIsHardCoverDisplay = new System.Windows.Forms.CheckBox();
            this.txtIssueDisplay = new System.Windows.Forms.TextBox();
            this.lblIssueDisplay = new System.Windows.Forms.Label();
            this.txtLanguageDisplay = new System.Windows.Forms.TextBox();
            this.txtPagesDisplay = new System.Windows.Forms.TextBox();
            this.txtPriceDisplay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPagesDisplay = new System.Windows.Forms.Label();
            this.lblLanguageDisplay = new System.Windows.Forms.Label();
            this.txtAuthorDisplay = new System.Windows.Forms.TextBox();
            this.lblAuthorDisplay = new System.Windows.Forms.Label();
            this.txtTitleDisplay = new System.Windows.Forms.TextBox();
            this.lblTitleDisplay = new System.Windows.Forms.Label();
            this.grpIssueFrequencyDisplay = new System.Windows.Forms.GroupBox();
            this.radBtnMonthlyDisplay = new System.Windows.Forms.RadioButton();
            this.radBtnWeeklyDisplay = new System.Windows.Forms.RadioButton();
            this.lblGetCopy = new System.Windows.Forms.Label();
            this.txtCopySourceDisplay = new System.Windows.Forms.TextBox();
            this.lblLastAdded = new System.Windows.Forms.Label();
            this.grpMaterialTypeDisplay = new System.Windows.Forms.GroupBox();
            this.radBtnOnlineDisplay = new System.Windows.Forms.RadioButton();
            this.radBtnMagazineDisplay = new System.Windows.Forms.RadioButton();
            this.radBtnBookDisplay = new System.Windows.Forms.RadioButton();
            this.grpMaterialTypes.SuspendLayout();
            this.grpIssueFrequency.SuspendLayout();
            this.grpIssueFrequencyDisplay.SuspendLayout();
            this.grpMaterialTypeDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewMaterial
            // 
            this.btnAddNewMaterial.Location = new System.Drawing.Point(106, 401);
            this.btnAddNewMaterial.Name = "btnAddNewMaterial";
            this.btnAddNewMaterial.Size = new System.Drawing.Size(125, 23);
            this.btnAddNewMaterial.TabIndex = 14;
            this.btnAddNewMaterial.Text = "Add Material";
            this.btnAddNewMaterial.UseVisualStyleBackColor = true;
            this.btnAddNewMaterial.Click += new System.EventHandler(this.btnAddNewMaterial_Click);
            // 
            // grpMaterialTypes
            // 
            this.grpMaterialTypes.Controls.Add(this.radBtnOnline);
            this.grpMaterialTypes.Controls.Add(this.radBtnMagazine);
            this.grpMaterialTypes.Controls.Add(this.radBtnBook);
            this.grpMaterialTypes.Location = new System.Drawing.Point(12, 12);
            this.grpMaterialTypes.Name = "grpMaterialTypes";
            this.grpMaterialTypes.Size = new System.Drawing.Size(287, 55);
            this.grpMaterialTypes.TabIndex = 0;
            this.grpMaterialTypes.TabStop = false;
            this.grpMaterialTypes.Text = "Reading Material Type";
            // 
            // radBtnBook
            // 
            this.radBtnBook.AutoSize = true;
            this.radBtnBook.Location = new System.Drawing.Point(12, 21);
            this.radBtnBook.Name = "radBtnBook";
            this.radBtnBook.Size = new System.Drawing.Size(61, 21);
            this.radBtnBook.TabIndex = 1;
            this.radBtnBook.TabStop = true;
            this.radBtnBook.Text = "Book";
            this.radBtnBook.UseVisualStyleBackColor = true;
            this.radBtnBook.CheckedChanged += new System.EventHandler(this.radBtnBook_CheckedChanged);
            // 
            // radBtnMagazine
            // 
            this.radBtnMagazine.AutoSize = true;
            this.radBtnMagazine.Location = new System.Drawing.Point(94, 21);
            this.radBtnMagazine.Name = "radBtnMagazine";
            this.radBtnMagazine.Size = new System.Drawing.Size(90, 21);
            this.radBtnMagazine.TabIndex = 2;
            this.radBtnMagazine.TabStop = true;
            this.radBtnMagazine.Text = "Magazine";
            this.radBtnMagazine.UseVisualStyleBackColor = true;
            this.radBtnMagazine.CheckedChanged += new System.EventHandler(this.radBtnMagazine_CheckedChanged);
            // 
            // radBtnOnline
            // 
            this.radBtnOnline.AutoSize = true;
            this.radBtnOnline.Location = new System.Drawing.Point(205, 21);
            this.radBtnOnline.Name = "radBtnOnline";
            this.radBtnOnline.Size = new System.Drawing.Size(70, 21);
            this.radBtnOnline.TabIndex = 3;
            this.radBtnOnline.TabStop = true;
            this.radBtnOnline.Text = "Online";
            this.radBtnOnline.UseVisualStyleBackColor = true;
            this.radBtnOnline.CheckedChanged += new System.EventHandler(this.radBtnOnline_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(27, 74);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(106, 74);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(181, 22);
            this.txtTitle.TabIndex = 4;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(27, 138);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(50, 17);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(106, 138);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(181, 22);
            this.txtAuthor.TabIndex = 6;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(27, 172);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(72, 17);
            this.lblLanguage.TabIndex = 7;
            this.lblLanguage.Text = "Language";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(27, 207);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(48, 17);
            this.lblPages.TabIndex = 8;
            this.lblPages.Text = "Pages";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(27, 237);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(106, 237);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(181, 22);
            this.txtPrice.TabIndex = 9;
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(106, 209);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(181, 22);
            this.txtPages.TabIndex = 8;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(106, 172);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(181, 22);
            this.txtLanguage.TabIndex = 7;
            // 
            // lblIssue
            // 
            this.lblIssue.AutoSize = true;
            this.lblIssue.Location = new System.Drawing.Point(27, 105);
            this.lblIssue.Name = "lblIssue";
            this.lblIssue.Size = new System.Drawing.Size(53, 17);
            this.lblIssue.TabIndex = 13;
            this.lblIssue.Text = "Issue #";
            // 
            // txtIssue
            // 
            this.txtIssue.Location = new System.Drawing.Point(106, 105);
            this.txtIssue.Name = "txtIssue";
            this.txtIssue.Size = new System.Drawing.Size(181, 22);
            this.txtIssue.TabIndex = 5;
            // 
            // chkbxIsHardCover
            // 
            this.chkbxIsHardCover.AutoSize = true;
            this.chkbxIsHardCover.Location = new System.Drawing.Point(106, 275);
            this.chkbxIsHardCover.Name = "chkbxIsHardCover";
            this.chkbxIsHardCover.Size = new System.Drawing.Size(102, 21);
            this.chkbxIsHardCover.TabIndex = 10;
            this.chkbxIsHardCover.Text = "Hard Cover";
            this.chkbxIsHardCover.UseVisualStyleBackColor = true;
            // 
            // grpIssueFrequency
            // 
            this.grpIssueFrequency.Controls.Add(this.radBtnMonthly);
            this.grpIssueFrequency.Controls.Add(this.radBtnWeekly);
            this.grpIssueFrequency.Location = new System.Drawing.Point(12, 317);
            this.grpIssueFrequency.Name = "grpIssueFrequency";
            this.grpIssueFrequency.Size = new System.Drawing.Size(182, 63);
            this.grpIssueFrequency.TabIndex = 11;
            this.grpIssueFrequency.TabStop = false;
            this.grpIssueFrequency.Text = "Issue Frequency";
            // 
            // radBtnWeekly
            // 
            this.radBtnWeekly.AutoSize = true;
            this.radBtnWeekly.Location = new System.Drawing.Point(6, 32);
            this.radBtnWeekly.Name = "radBtnWeekly";
            this.radBtnWeekly.Size = new System.Drawing.Size(75, 21);
            this.radBtnWeekly.TabIndex = 12;
            this.radBtnWeekly.Text = "Weekly";
            this.radBtnWeekly.UseVisualStyleBackColor = true;
            // 
            // radBtnMonthly
            // 
            this.radBtnMonthly.AutoSize = true;
            this.radBtnMonthly.Location = new System.Drawing.Point(94, 32);
            this.radBtnMonthly.Name = "radBtnMonthly";
            this.radBtnMonthly.Size = new System.Drawing.Size(78, 21);
            this.radBtnMonthly.TabIndex = 13;
            this.radBtnMonthly.Text = "Monthly";
            this.radBtnMonthly.UseVisualStyleBackColor = true;
            // 
            // chkBxIsHardCoverDisplay
            // 
            this.chkBxIsHardCoverDisplay.AutoSize = true;
            this.chkBxIsHardCoverDisplay.Enabled = false;
            this.chkBxIsHardCoverDisplay.Location = new System.Drawing.Point(648, 412);
            this.chkBxIsHardCoverDisplay.Name = "chkBxIsHardCoverDisplay";
            this.chkBxIsHardCoverDisplay.Size = new System.Drawing.Size(102, 21);
            this.chkBxIsHardCoverDisplay.TabIndex = 30;
            this.chkBxIsHardCoverDisplay.Text = "Hard Cover";
            this.chkBxIsHardCoverDisplay.UseVisualStyleBackColor = true;
            // 
            // txtIssueDisplay
            // 
            this.txtIssueDisplay.Enabled = false;
            this.txtIssueDisplay.Location = new System.Drawing.Point(651, 242);
            this.txtIssueDisplay.Name = "txtIssueDisplay";
            this.txtIssueDisplay.Size = new System.Drawing.Size(181, 22);
            this.txtIssueDisplay.TabIndex = 29;
            // 
            // lblIssueDisplay
            // 
            this.lblIssueDisplay.AutoSize = true;
            this.lblIssueDisplay.Location = new System.Drawing.Point(569, 242);
            this.lblIssueDisplay.Name = "lblIssueDisplay";
            this.lblIssueDisplay.Size = new System.Drawing.Size(53, 17);
            this.lblIssueDisplay.TabIndex = 28;
            this.lblIssueDisplay.Text = "Issue #";
            // 
            // txtLanguageDisplay
            // 
            this.txtLanguageDisplay.Enabled = false;
            this.txtLanguageDisplay.Location = new System.Drawing.Point(651, 309);
            this.txtLanguageDisplay.Name = "txtLanguageDisplay";
            this.txtLanguageDisplay.Size = new System.Drawing.Size(181, 22);
            this.txtLanguageDisplay.TabIndex = 27;
            // 
            // txtPagesDisplay
            // 
            this.txtPagesDisplay.Enabled = false;
            this.txtPagesDisplay.Location = new System.Drawing.Point(651, 346);
            this.txtPagesDisplay.Name = "txtPagesDisplay";
            this.txtPagesDisplay.Size = new System.Drawing.Size(181, 22);
            this.txtPagesDisplay.TabIndex = 26;
            // 
            // txtPriceDisplay
            // 
            this.txtPriceDisplay.Enabled = false;
            this.txtPriceDisplay.Location = new System.Drawing.Point(651, 374);
            this.txtPriceDisplay.Name = "txtPriceDisplay";
            this.txtPriceDisplay.Size = new System.Drawing.Size(181, 22);
            this.txtPriceDisplay.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Price";
            // 
            // lblPagesDisplay
            // 
            this.lblPagesDisplay.AutoSize = true;
            this.lblPagesDisplay.Location = new System.Drawing.Point(569, 344);
            this.lblPagesDisplay.Name = "lblPagesDisplay";
            this.lblPagesDisplay.Size = new System.Drawing.Size(48, 17);
            this.lblPagesDisplay.TabIndex = 23;
            this.lblPagesDisplay.Text = "Pages";
            // 
            // lblLanguageDisplay
            // 
            this.lblLanguageDisplay.AutoSize = true;
            this.lblLanguageDisplay.Location = new System.Drawing.Point(569, 309);
            this.lblLanguageDisplay.Name = "lblLanguageDisplay";
            this.lblLanguageDisplay.Size = new System.Drawing.Size(72, 17);
            this.lblLanguageDisplay.TabIndex = 22;
            this.lblLanguageDisplay.Text = "Language";
            // 
            // txtAuthorDisplay
            // 
            this.txtAuthorDisplay.Enabled = false;
            this.txtAuthorDisplay.Location = new System.Drawing.Point(651, 275);
            this.txtAuthorDisplay.Name = "txtAuthorDisplay";
            this.txtAuthorDisplay.Size = new System.Drawing.Size(181, 22);
            this.txtAuthorDisplay.TabIndex = 21;
            // 
            // lblAuthorDisplay
            // 
            this.lblAuthorDisplay.AutoSize = true;
            this.lblAuthorDisplay.Location = new System.Drawing.Point(569, 275);
            this.lblAuthorDisplay.Name = "lblAuthorDisplay";
            this.lblAuthorDisplay.Size = new System.Drawing.Size(50, 17);
            this.lblAuthorDisplay.TabIndex = 20;
            this.lblAuthorDisplay.Text = "Author";
            // 
            // txtTitleDisplay
            // 
            this.txtTitleDisplay.Enabled = false;
            this.txtTitleDisplay.Location = new System.Drawing.Point(651, 211);
            this.txtTitleDisplay.Name = "txtTitleDisplay";
            this.txtTitleDisplay.Size = new System.Drawing.Size(181, 22);
            this.txtTitleDisplay.TabIndex = 19;
            // 
            // lblTitleDisplay
            // 
            this.lblTitleDisplay.AutoSize = true;
            this.lblTitleDisplay.Location = new System.Drawing.Point(569, 211);
            this.lblTitleDisplay.Name = "lblTitleDisplay";
            this.lblTitleDisplay.Size = new System.Drawing.Size(35, 17);
            this.lblTitleDisplay.TabIndex = 18;
            this.lblTitleDisplay.Text = "Title";
            // 
            // grpIssueFrequencyDisplay
            // 
            this.grpIssueFrequencyDisplay.Controls.Add(this.radBtnMonthlyDisplay);
            this.grpIssueFrequencyDisplay.Controls.Add(this.radBtnWeeklyDisplay);
            this.grpIssueFrequencyDisplay.Location = new System.Drawing.Point(572, 442);
            this.grpIssueFrequencyDisplay.Name = "grpIssueFrequencyDisplay";
            this.grpIssueFrequencyDisplay.Size = new System.Drawing.Size(182, 63);
            this.grpIssueFrequencyDisplay.TabIndex = 18;
            this.grpIssueFrequencyDisplay.TabStop = false;
            this.grpIssueFrequencyDisplay.Text = "Issue Frequency";
            // 
            // radBtnMonthlyDisplay
            // 
            this.radBtnMonthlyDisplay.AutoSize = true;
            this.radBtnMonthlyDisplay.Enabled = false;
            this.radBtnMonthlyDisplay.Location = new System.Drawing.Point(94, 32);
            this.radBtnMonthlyDisplay.Name = "radBtnMonthlyDisplay";
            this.radBtnMonthlyDisplay.Size = new System.Drawing.Size(78, 21);
            this.radBtnMonthlyDisplay.TabIndex = 1;
            this.radBtnMonthlyDisplay.TabStop = true;
            this.radBtnMonthlyDisplay.Text = "Monthly";
            this.radBtnMonthlyDisplay.UseVisualStyleBackColor = true;
            // 
            // radBtnWeeklyDisplay
            // 
            this.radBtnWeeklyDisplay.AutoSize = true;
            this.radBtnWeeklyDisplay.Enabled = false;
            this.radBtnWeeklyDisplay.Location = new System.Drawing.Point(6, 32);
            this.radBtnWeeklyDisplay.Name = "radBtnWeeklyDisplay";
            this.radBtnWeeklyDisplay.Size = new System.Drawing.Size(75, 21);
            this.radBtnWeeklyDisplay.TabIndex = 0;
            this.radBtnWeeklyDisplay.TabStop = true;
            this.radBtnWeeklyDisplay.Text = "Weekly";
            this.radBtnWeeklyDisplay.UseVisualStyleBackColor = true;
            // 
            // lblGetCopy
            // 
            this.lblGetCopy.AutoSize = true;
            this.lblGetCopy.Location = new System.Drawing.Point(572, 176);
            this.lblGetCopy.Name = "lblGetCopy";
            this.lblGetCopy.Size = new System.Drawing.Size(113, 17);
            this.lblGetCopy.TabIndex = 31;
            this.lblGetCopy.Text = "Get a copy from:";
            // 
            // txtCopySourceDisplay
            // 
            this.txtCopySourceDisplay.Enabled = false;
            this.txtCopySourceDisplay.Location = new System.Drawing.Point(704, 176);
            this.txtCopySourceDisplay.Name = "txtCopySourceDisplay";
            this.txtCopySourceDisplay.Size = new System.Drawing.Size(128, 22);
            this.txtCopySourceDisplay.TabIndex = 32;
            // 
            // lblLastAdded
            // 
            this.lblLastAdded.AutoSize = true;
            this.lblLastAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastAdded.Location = new System.Drawing.Point(579, 66);
            this.lblLastAdded.Name = "lblLastAdded";
            this.lblLastAdded.Size = new System.Drawing.Size(290, 25);
            this.lblLastAdded.TabIndex = 33;
            this.lblLastAdded.Text = "Last Added Reading Material";
            // 
            // grpMaterialTypeDisplay
            // 
            this.grpMaterialTypeDisplay.Controls.Add(this.radBtnOnlineDisplay);
            this.grpMaterialTypeDisplay.Controls.Add(this.radBtnMagazineDisplay);
            this.grpMaterialTypeDisplay.Controls.Add(this.radBtnBookDisplay);
            this.grpMaterialTypeDisplay.Location = new System.Drawing.Point(572, 115);
            this.grpMaterialTypeDisplay.Name = "grpMaterialTypeDisplay";
            this.grpMaterialTypeDisplay.Size = new System.Drawing.Size(287, 55);
            this.grpMaterialTypeDisplay.TabIndex = 3;
            this.grpMaterialTypeDisplay.TabStop = false;
            this.grpMaterialTypeDisplay.Text = "Reading Material Type";
            // 
            // radBtnOnlineDisplay
            // 
            this.radBtnOnlineDisplay.AutoSize = true;
            this.radBtnOnlineDisplay.Enabled = false;
            this.radBtnOnlineDisplay.Location = new System.Drawing.Point(205, 21);
            this.radBtnOnlineDisplay.Name = "radBtnOnlineDisplay";
            this.radBtnOnlineDisplay.Size = new System.Drawing.Size(70, 21);
            this.radBtnOnlineDisplay.TabIndex = 2;
            this.radBtnOnlineDisplay.TabStop = true;
            this.radBtnOnlineDisplay.Text = "Online";
            this.radBtnOnlineDisplay.UseVisualStyleBackColor = true;
            // 
            // radBtnMagazineDisplay
            // 
            this.radBtnMagazineDisplay.Enabled = false;
            this.radBtnMagazineDisplay.Location = new System.Drawing.Point(94, 21);
            this.radBtnMagazineDisplay.Name = "radBtnMagazineDisplay";
            this.radBtnMagazineDisplay.Size = new System.Drawing.Size(105, 21);
            this.radBtnMagazineDisplay.TabIndex = 1;
            this.radBtnMagazineDisplay.TabStop = true;
            this.radBtnMagazineDisplay.Text = "Magazine";
            this.radBtnMagazineDisplay.UseVisualStyleBackColor = true;
            // 
            // radBtnBookDisplay
            // 
            this.radBtnBookDisplay.Enabled = false;
            this.radBtnBookDisplay.Location = new System.Drawing.Point(12, 21);
            this.radBtnBookDisplay.Name = "radBtnBookDisplay";
            this.radBtnBookDisplay.Size = new System.Drawing.Size(69, 21);
            this.radBtnBookDisplay.TabIndex = 0;
            this.radBtnBookDisplay.TabStop = true;
            this.radBtnBookDisplay.Text = "Book";
            this.radBtnBookDisplay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(950, 517);
            this.Controls.Add(this.grpMaterialTypeDisplay);
            this.Controls.Add(this.lblLastAdded);
            this.Controls.Add(this.txtCopySourceDisplay);
            this.Controls.Add(this.lblGetCopy);
            this.Controls.Add(this.grpIssueFrequencyDisplay);
            this.Controls.Add(this.chkBxIsHardCoverDisplay);
            this.Controls.Add(this.txtIssueDisplay);
            this.Controls.Add(this.lblIssueDisplay);
            this.Controls.Add(this.txtLanguageDisplay);
            this.Controls.Add(this.txtPagesDisplay);
            this.Controls.Add(this.txtPriceDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPagesDisplay);
            this.Controls.Add(this.lblLanguageDisplay);
            this.Controls.Add(this.txtAuthorDisplay);
            this.Controls.Add(this.lblAuthorDisplay);
            this.Controls.Add(this.txtTitleDisplay);
            this.Controls.Add(this.lblTitleDisplay);
            this.Controls.Add(this.grpIssueFrequency);
            this.Controls.Add(this.chkbxIsHardCover);
            this.Controls.Add(this.txtIssue);
            this.Controls.Add(this.lblIssue);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.txtPages);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpMaterialTypes);
            this.Controls.Add(this.btnAddNewMaterial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpMaterialTypes.ResumeLayout(false);
            this.grpMaterialTypes.PerformLayout();
            this.grpIssueFrequency.ResumeLayout(false);
            this.grpIssueFrequency.PerformLayout();
            this.grpIssueFrequencyDisplay.ResumeLayout(false);
            this.grpIssueFrequencyDisplay.PerformLayout();
            this.grpMaterialTypeDisplay.ResumeLayout(false);
            this.grpMaterialTypeDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewMaterial;
        private System.Windows.Forms.GroupBox grpMaterialTypes;
        private System.Windows.Forms.RadioButton radBtnOnline;
        private System.Windows.Forms.RadioButton radBtnMagazine;
        private System.Windows.Forms.RadioButton radBtnBook;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label lblIssue;
        private System.Windows.Forms.TextBox txtIssue;
        private System.Windows.Forms.CheckBox chkbxIsHardCover;
        private System.Windows.Forms.GroupBox grpIssueFrequency;
        private System.Windows.Forms.RadioButton radBtnMonthly;
        private System.Windows.Forms.RadioButton radBtnWeekly;
        private System.Windows.Forms.CheckBox chkBxIsHardCoverDisplay;
        private System.Windows.Forms.TextBox txtIssueDisplay;
        private System.Windows.Forms.Label lblIssueDisplay;
        private System.Windows.Forms.TextBox txtLanguageDisplay;
        private System.Windows.Forms.TextBox txtPagesDisplay;
        private System.Windows.Forms.TextBox txtPriceDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPagesDisplay;
        private System.Windows.Forms.Label lblLanguageDisplay;
        private System.Windows.Forms.TextBox txtAuthorDisplay;
        private System.Windows.Forms.Label lblAuthorDisplay;
        private System.Windows.Forms.TextBox txtTitleDisplay;
        private System.Windows.Forms.Label lblTitleDisplay;
        private System.Windows.Forms.GroupBox grpIssueFrequencyDisplay;
        private System.Windows.Forms.RadioButton radBtnMonthlyDisplay;
        private System.Windows.Forms.RadioButton radBtnWeeklyDisplay;
        private System.Windows.Forms.Label lblGetCopy;
        private System.Windows.Forms.TextBox txtCopySourceDisplay;
        private System.Windows.Forms.Label lblLastAdded;
        private System.Windows.Forms.GroupBox grpMaterialTypeDisplay;
        private System.Windows.Forms.RadioButton radBtnOnlineDisplay;
        private System.Windows.Forms.RadioButton radBtnMagazineDisplay;
        private System.Windows.Forms.RadioButton radBtnBookDisplay;
    }
}

