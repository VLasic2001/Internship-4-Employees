namespace Employees.Presentation.ProjectForms
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.EmployeeListCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ProjectFinishDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ProjectFinishDateLabel = new System.Windows.Forms.Label();
            this.ProjectStartDateLabel = new System.Windows.Forms.Label();
            this.ProjectStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.EmployeeListLlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.TitleLabel.Location = new System.Drawing.Point(250, -1);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(298, 63);
            this.TitleLabel.TabIndex = 17;
            this.TitleLabel.Text = "Edit project";
            // 
            // EmployeeListCheckedListBox
            // 
            this.EmployeeListCheckedListBox.CheckOnClick = true;
            this.EmployeeListCheckedListBox.FormattingEnabled = true;
            this.EmployeeListCheckedListBox.Location = new System.Drawing.Point(384, 89);
            this.EmployeeListCheckedListBox.Name = "EmployeeListCheckedListBox";
            this.EmployeeListCheckedListBox.Size = new System.Drawing.Size(394, 349);
            this.EmployeeListCheckedListBox.TabIndex = 16;
            this.EmployeeListCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ItemCheck);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(30, 382);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(129, 23);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveChanges);
            // 
            // ProjectFinishDateTimePicker
            // 
            this.ProjectFinishDateTimePicker.Location = new System.Drawing.Point(141, 288);
            this.ProjectFinishDateTimePicker.Name = "ProjectFinishDateTimePicker";
            this.ProjectFinishDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ProjectFinishDateTimePicker.TabIndex = 14;
            // 
            // ProjectFinishDateLabel
            // 
            this.ProjectFinishDateLabel.AutoSize = true;
            this.ProjectFinishDateLabel.Location = new System.Drawing.Point(23, 295);
            this.ProjectFinishDateLabel.Name = "ProjectFinishDateLabel";
            this.ProjectFinishDateLabel.Size = new System.Drawing.Size(91, 13);
            this.ProjectFinishDateLabel.TabIndex = 13;
            this.ProjectFinishDateLabel.Text = "Project finish date";
            // 
            // ProjectStartDateLabel
            // 
            this.ProjectStartDateLabel.AutoSize = true;
            this.ProjectStartDateLabel.Location = new System.Drawing.Point(27, 197);
            this.ProjectStartDateLabel.Name = "ProjectStartDateLabel";
            this.ProjectStartDateLabel.Size = new System.Drawing.Size(87, 13);
            this.ProjectStartDateLabel.TabIndex = 12;
            this.ProjectStartDateLabel.Text = "Project start date";
            // 
            // ProjectStartDateTimePicker
            // 
            this.ProjectStartDateTimePicker.Location = new System.Drawing.Point(141, 191);
            this.ProjectStartDateTimePicker.Name = "ProjectStartDateTimePicker";
            this.ProjectStartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ProjectStartDateTimePicker.TabIndex = 11;
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Location = new System.Drawing.Point(45, 102);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(69, 13);
            this.ProjectNameLabel.TabIndex = 10;
            this.ProjectNameLabel.Text = "Project name";
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Location = new System.Drawing.Point(141, 99);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.ProjectNameTextBox.TabIndex = 9;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(208, 382);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(133, 23);
            this.CloseButton.TabIndex = 18;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // EmployeeListLlabel
            // 
            this.EmployeeListLlabel.AutoSize = true;
            this.EmployeeListLlabel.Location = new System.Drawing.Point(384, 70);
            this.EmployeeListLlabel.Name = "EmployeeListLlabel";
            this.EmployeeListLlabel.Size = new System.Drawing.Size(202, 13);
            this.EmployeeListLlabel.TabIndex = 19;
            this.EmployeeListLlabel.Text = "Select employees working on this project:";
            // 
            // EditProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmployeeListLlabel);
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
            this.Name = "EditProjectForm";
            this.Text = "EditProjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.CheckedListBox EmployeeListCheckedListBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DateTimePicker ProjectFinishDateTimePicker;
        private System.Windows.Forms.Label ProjectFinishDateLabel;
        private System.Windows.Forms.Label ProjectStartDateLabel;
        private System.Windows.Forms.DateTimePicker ProjectStartDateTimePicker;
        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label EmployeeListLlabel;
    }
}