namespace Employees.Presentation
{
    partial class EditProjectForm
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
            this.EditProjectTitleLabel = new System.Windows.Forms.Label();
            this.EditProjectEmployeeListCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.EditProjectSaveButton = new System.Windows.Forms.Button();
            this.EditProjectFinishDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EditProjectFinishDateLabel = new System.Windows.Forms.Label();
            this.EditProjectStartDateLabel = new System.Windows.Forms.Label();
            this.EditProjectStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EditProjesNameLabel = new System.Windows.Forms.Label();
            this.EditProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EditProjectTitleLabel
            // 
            this.EditProjectTitleLabel.AutoSize = true;
            this.EditProjectTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.EditProjectTitleLabel.Location = new System.Drawing.Point(254, 13);
            this.EditProjectTitleLabel.Name = "EditProjectTitleLabel";
            this.EditProjectTitleLabel.Size = new System.Drawing.Size(298, 63);
            this.EditProjectTitleLabel.TabIndex = 17;
            this.EditProjectTitleLabel.Text = "Edit project";
            // 
            // EditProjectEmployeeListCheckedListBox
            // 
            this.EditProjectEmployeeListCheckedListBox.FormattingEnabled = true;
            this.EditProjectEmployeeListCheckedListBox.Location = new System.Drawing.Point(384, 89);
            this.EditProjectEmployeeListCheckedListBox.Name = "EditProjectEmployeeListCheckedListBox";
            this.EditProjectEmployeeListCheckedListBox.Size = new System.Drawing.Size(394, 349);
            this.EditProjectEmployeeListCheckedListBox.TabIndex = 16;
            // 
            // EditProjectSaveButton
            // 
            this.EditProjectSaveButton.Location = new System.Drawing.Point(159, 383);
            this.EditProjectSaveButton.Name = "EditProjectSaveButton";
            this.EditProjectSaveButton.Size = new System.Drawing.Size(75, 23);
            this.EditProjectSaveButton.TabIndex = 15;
            this.EditProjectSaveButton.Text = "Save";
            this.EditProjectSaveButton.UseVisualStyleBackColor = true;
            this.EditProjectSaveButton.Click += new System.EventHandler(this.SaveChanges);
            // 
            // EditProjectFinishDateTimePicker
            // 
            this.EditProjectFinishDateTimePicker.Location = new System.Drawing.Point(141, 288);
            this.EditProjectFinishDateTimePicker.Name = "EditProjectFinishDateTimePicker";
            this.EditProjectFinishDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EditProjectFinishDateTimePicker.TabIndex = 14;
            // 
            // EditProjectFinishDateLabel
            // 
            this.EditProjectFinishDateLabel.AutoSize = true;
            this.EditProjectFinishDateLabel.Location = new System.Drawing.Point(23, 295);
            this.EditProjectFinishDateLabel.Name = "EditProjectFinishDateLabel";
            this.EditProjectFinishDateLabel.Size = new System.Drawing.Size(91, 13);
            this.EditProjectFinishDateLabel.TabIndex = 13;
            this.EditProjectFinishDateLabel.Text = "Project finish date";
            // 
            // EditProjectStartDateLabel
            // 
            this.EditProjectStartDateLabel.AutoSize = true;
            this.EditProjectStartDateLabel.Location = new System.Drawing.Point(27, 197);
            this.EditProjectStartDateLabel.Name = "EditProjectStartDateLabel";
            this.EditProjectStartDateLabel.Size = new System.Drawing.Size(87, 13);
            this.EditProjectStartDateLabel.TabIndex = 12;
            this.EditProjectStartDateLabel.Text = "Project start date";
            // 
            // EditProjectStartDateTimePicker
            // 
            this.EditProjectStartDateTimePicker.Location = new System.Drawing.Point(141, 191);
            this.EditProjectStartDateTimePicker.Name = "EditProjectStartDateTimePicker";
            this.EditProjectStartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EditProjectStartDateTimePicker.TabIndex = 11;
            // 
            // EditProjesNameLabel
            // 
            this.EditProjesNameLabel.AutoSize = true;
            this.EditProjesNameLabel.Location = new System.Drawing.Point(45, 102);
            this.EditProjesNameLabel.Name = "EditProjesNameLabel";
            this.EditProjesNameLabel.Size = new System.Drawing.Size(69, 13);
            this.EditProjesNameLabel.TabIndex = 10;
            this.EditProjesNameLabel.Text = "Project name";
            // 
            // EditProjectNameTextBox
            // 
            this.EditProjectNameTextBox.Location = new System.Drawing.Point(141, 99);
            this.EditProjectNameTextBox.Name = "EditProjectNameTextBox";
            this.EditProjectNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.EditProjectNameTextBox.TabIndex = 9;
            // 
            // EditProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditProjectTitleLabel);
            this.Controls.Add(this.EditProjectEmployeeListCheckedListBox);
            this.Controls.Add(this.EditProjectSaveButton);
            this.Controls.Add(this.EditProjectFinishDateTimePicker);
            this.Controls.Add(this.EditProjectFinishDateLabel);
            this.Controls.Add(this.EditProjectStartDateLabel);
            this.Controls.Add(this.EditProjectStartDateTimePicker);
            this.Controls.Add(this.EditProjesNameLabel);
            this.Controls.Add(this.EditProjectNameTextBox);
            this.Name = "EditProjectForm";
            this.Text = "EditProjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditProjectTitleLabel;
        private System.Windows.Forms.CheckedListBox EditProjectEmployeeListCheckedListBox;
        private System.Windows.Forms.Button EditProjectSaveButton;
        private System.Windows.Forms.DateTimePicker EditProjectFinishDateTimePicker;
        private System.Windows.Forms.Label EditProjectFinishDateLabel;
        private System.Windows.Forms.Label EditProjectStartDateLabel;
        private System.Windows.Forms.DateTimePicker EditProjectStartDateTimePicker;
        private System.Windows.Forms.Label EditProjesNameLabel;
        private System.Windows.Forms.TextBox EditProjectNameTextBox;
    }
}