namespace Employees.Presentation.ProjectForms
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
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.ProjectStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ProjectStartDateLabel = new System.Windows.Forms.Label();
            this.ProjectFinishDateLabel = new System.Windows.Forms.Label();
            this.ProjectFinishDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EmployeeListCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.EmployeeListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Location = new System.Drawing.Point(126, 92);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.ProjectNameTextBox.TabIndex = 0;
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Location = new System.Drawing.Point(30, 95);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(69, 13);
            this.ProjectNameLabel.TabIndex = 1;
            this.ProjectNameLabel.Text = "Project name";
            // 
            // ProjectStartDateTimePicker
            // 
            this.ProjectStartDateTimePicker.Location = new System.Drawing.Point(126, 184);
            this.ProjectStartDateTimePicker.Name = "ProjectStartDateTimePicker";
            this.ProjectStartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ProjectStartDateTimePicker.TabIndex = 2;
            // 
            // ProjectStartDateLabel
            // 
            this.ProjectStartDateLabel.AutoSize = true;
            this.ProjectStartDateLabel.Location = new System.Drawing.Point(12, 190);
            this.ProjectStartDateLabel.Name = "ProjectStartDateLabel";
            this.ProjectStartDateLabel.Size = new System.Drawing.Size(87, 13);
            this.ProjectStartDateLabel.TabIndex = 3;
            this.ProjectStartDateLabel.Text = "Project start date";
            // 
            // ProjectFinishDateLabel
            // 
            this.ProjectFinishDateLabel.AutoSize = true;
            this.ProjectFinishDateLabel.Location = new System.Drawing.Point(8, 288);
            this.ProjectFinishDateLabel.Name = "ProjectFinishDateLabel";
            this.ProjectFinishDateLabel.Size = new System.Drawing.Size(91, 13);
            this.ProjectFinishDateLabel.TabIndex = 4;
            this.ProjectFinishDateLabel.Text = "Project finish date";
            // 
            // ProjectFinishDateTimePicker
            // 
            this.ProjectFinishDateTimePicker.Location = new System.Drawing.Point(126, 281);
            this.ProjectFinishDateTimePicker.Name = "ProjectFinishDateTimePicker";
            this.ProjectFinishDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ProjectFinishDateTimePicker.TabIndex = 5;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(33, 371);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(127, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveProject);
            // 
            // EmployeeListCheckedListBox
            // 
            this.EmployeeListCheckedListBox.CheckOnClick = true;
            this.EmployeeListCheckedListBox.FormattingEnabled = true;
            this.EmployeeListCheckedListBox.Location = new System.Drawing.Point(379, 89);
            this.EmployeeListCheckedListBox.Name = "EmployeeListCheckedListBox";
            this.EmployeeListCheckedListBox.Size = new System.Drawing.Size(394, 349);
            this.EmployeeListCheckedListBox.TabIndex = 7;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.TitleLabel.Location = new System.Drawing.Point(224, -1);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(300, 63);
            this.TitleLabel.TabIndex = 8;
            this.TitleLabel.Text = "Add project";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(203, 371);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(133, 23);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // EmployeeListLabel
            // 
            this.EmployeeListLabel.AutoSize = true;
            this.EmployeeListLabel.Location = new System.Drawing.Point(376, 73);
            this.EmployeeListLabel.Name = "EmployeeListLabel";
            this.EmployeeListLabel.Size = new System.Drawing.Size(201, 13);
            this.EmployeeListLabel.TabIndex = 16;
            this.EmployeeListLabel.Text = "Select employees working on the project:";
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmployeeListLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.EmployeeListCheckedListBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ProjectFinishDateTimePicker);
            this.Controls.Add(this.ProjectFinishDateLabel);
            this.Controls.Add(this.ProjectStartDateLabel);
            this.Controls.Add(this.ProjectStartDateTimePicker);
            this.Controls.Add(this.ProjectNameLabel);
            this.Controls.Add(this.ProjectNameTextBox);
            this.Name = "AddProjectForm";
            this.Text = "AddProjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.DateTimePicker ProjectStartDateTimePicker;
        private System.Windows.Forms.Label ProjectStartDateLabel;
        private System.Windows.Forms.Label ProjectFinishDateLabel;
        private System.Windows.Forms.DateTimePicker ProjectFinishDateTimePicker;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckedListBox EmployeeListCheckedListBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label EmployeeListLabel;
    }
}