namespace Employees.Presentation
{
    partial class AddProjectForm
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
            this.addProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.addProjesNameLabel = new System.Windows.Forms.Label();
            this.AddProjectStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.projectStartDateLabel = new System.Windows.Forms.Label();
            this.addProjectFinishDateLabel = new System.Windows.Forms.Label();
            this.addProjectFinishDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addProjectSaveButton = new System.Windows.Forms.Button();
            this.addProjectEmployeeListCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.addProjectTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addProjectNameTextBox
            // 
            this.addProjectNameTextBox.Location = new System.Drawing.Point(126, 92);
            this.addProjectNameTextBox.Name = "addProjectNameTextBox";
            this.addProjectNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.addProjectNameTextBox.TabIndex = 0;
            // 
            // addProjesNameLabel
            // 
            this.addProjesNameLabel.AutoSize = true;
            this.addProjesNameLabel.Location = new System.Drawing.Point(30, 95);
            this.addProjesNameLabel.Name = "addProjesNameLabel";
            this.addProjesNameLabel.Size = new System.Drawing.Size(69, 13);
            this.addProjesNameLabel.TabIndex = 1;
            this.addProjesNameLabel.Text = "Project name";
            // 
            // AddProjectStartDateTimePicker
            // 
            this.AddProjectStartDateTimePicker.Location = new System.Drawing.Point(126, 184);
            this.AddProjectStartDateTimePicker.Name = "AddProjectStartDateTimePicker";
            this.AddProjectStartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.AddProjectStartDateTimePicker.TabIndex = 2;
            // 
            // projectStartDateLabel
            // 
            this.projectStartDateLabel.AutoSize = true;
            this.projectStartDateLabel.Location = new System.Drawing.Point(12, 190);
            this.projectStartDateLabel.Name = "projectStartDateLabel";
            this.projectStartDateLabel.Size = new System.Drawing.Size(87, 13);
            this.projectStartDateLabel.TabIndex = 3;
            this.projectStartDateLabel.Text = "Project start date";
            // 
            // addProjectFinishDateLabel
            // 
            this.addProjectFinishDateLabel.AutoSize = true;
            this.addProjectFinishDateLabel.Location = new System.Drawing.Point(8, 288);
            this.addProjectFinishDateLabel.Name = "addProjectFinishDateLabel";
            this.addProjectFinishDateLabel.Size = new System.Drawing.Size(91, 13);
            this.addProjectFinishDateLabel.TabIndex = 4;
            this.addProjectFinishDateLabel.Text = "Project finish date";
            // 
            // addProjectFinishDateTimePicker
            // 
            this.addProjectFinishDateTimePicker.Location = new System.Drawing.Point(126, 281);
            this.addProjectFinishDateTimePicker.Name = "addProjectFinishDateTimePicker";
            this.addProjectFinishDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.addProjectFinishDateTimePicker.TabIndex = 5;
            // 
            // addProjectSaveButton
            // 
            this.addProjectSaveButton.Location = new System.Drawing.Point(144, 376);
            this.addProjectSaveButton.Name = "addProjectSaveButton";
            this.addProjectSaveButton.Size = new System.Drawing.Size(75, 23);
            this.addProjectSaveButton.TabIndex = 6;
            this.addProjectSaveButton.Text = "Save";
            this.addProjectSaveButton.UseVisualStyleBackColor = true;
            this.addProjectSaveButton.Click += new System.EventHandler(this.SaveProject);
            // 
            // addProjectEmployeeListCheckedListBox
            // 
            this.addProjectEmployeeListCheckedListBox.FormattingEnabled = true;
            this.addProjectEmployeeListCheckedListBox.Location = new System.Drawing.Point(369, 82);
            this.addProjectEmployeeListCheckedListBox.Name = "addProjectEmployeeListCheckedListBox";
            this.addProjectEmployeeListCheckedListBox.Size = new System.Drawing.Size(394, 349);
            this.addProjectEmployeeListCheckedListBox.TabIndex = 7;
            // 
            // addProjectTitleLabel
            // 
            this.addProjectTitleLabel.AutoSize = true;
            this.addProjectTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.addProjectTitleLabel.Location = new System.Drawing.Point(239, 6);
            this.addProjectTitleLabel.Name = "addProjectTitleLabel";
            this.addProjectTitleLabel.Size = new System.Drawing.Size(300, 63);
            this.addProjectTitleLabel.TabIndex = 8;
            this.addProjectTitleLabel.Text = "Add project";
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addProjectTitleLabel);
            this.Controls.Add(this.addProjectEmployeeListCheckedListBox);
            this.Controls.Add(this.addProjectSaveButton);
            this.Controls.Add(this.addProjectFinishDateTimePicker);
            this.Controls.Add(this.addProjectFinishDateLabel);
            this.Controls.Add(this.projectStartDateLabel);
            this.Controls.Add(this.AddProjectStartDateTimePicker);
            this.Controls.Add(this.addProjesNameLabel);
            this.Controls.Add(this.addProjectNameTextBox);
            this.Name = "AddProjectForm";
            this.Text = "AddProjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addProjectNameTextBox;
        private System.Windows.Forms.Label addProjesNameLabel;
        private System.Windows.Forms.DateTimePicker AddProjectStartDateTimePicker;
        private System.Windows.Forms.Label projectStartDateLabel;
        private System.Windows.Forms.Label addProjectFinishDateLabel;
        private System.Windows.Forms.DateTimePicker addProjectFinishDateTimePicker;
        private System.Windows.Forms.Button addProjectSaveButton;
        private System.Windows.Forms.CheckedListBox addProjectEmployeeListCheckedListBox;
        private System.Windows.Forms.Label addProjectTitleLabel;
    }
}