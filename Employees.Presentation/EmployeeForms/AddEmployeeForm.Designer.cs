namespace Employees.Presentation.EmployeeForms
{
    partial class AddEmployeeForm
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
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.OibTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.JobComboBox = new System.Windows.Forms.ComboBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.OibLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.JobLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.EmployeesProjectsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.EmployeeProjectsLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(104, 89);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.FirstNameTextBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(104, 164);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // OibTextBox
            // 
            this.OibTextBox.Location = new System.Drawing.Point(104, 300);
            this.OibTextBox.Name = "OibTextBox";
            this.OibTextBox.Size = new System.Drawing.Size(200, 20);
            this.OibTextBox.TabIndex = 2;
            // 
            // DateOfBirthDateTimePicker
            // 
            this.DateOfBirthDateTimePicker.Location = new System.Drawing.Point(104, 228);
            this.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker";
            this.DateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirthDateTimePicker.TabIndex = 3;
            // 
            // JobComboBox
            // 
            this.JobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JobComboBox.FormattingEnabled = true;
            this.JobComboBox.Items.AddRange(new object[] {
            "Programmer",
            "Designer",
            "Accountant"});
            this.JobComboBox.Location = new System.Drawing.Point(104, 368);
            this.JobComboBox.Name = "JobComboBox";
            this.JobComboBox.Size = new System.Drawing.Size(200, 21);
            this.JobComboBox.TabIndex = 4;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(25, 92);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(55, 13);
            this.FirstNameLabel.TabIndex = 5;
            this.FirstNameLabel.Text = "First name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(25, 167);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.LastNameLabel.TabIndex = 6;
            this.LastNameLabel.Text = "Last name";
            // 
            // OibLabel
            // 
            this.OibLabel.AutoSize = true;
            this.OibLabel.Location = new System.Drawing.Point(25, 303);
            this.OibLabel.Name = "OibLabel";
            this.OibLabel.Size = new System.Drawing.Size(23, 13);
            this.OibLabel.TabIndex = 7;
            this.OibLabel.Text = "Oib";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(25, 228);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(65, 13);
            this.DateOfBirthLabel.TabIndex = 8;
            this.DateOfBirthLabel.Text = "Date of birth";
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Location = new System.Drawing.Point(25, 371);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(44, 13);
            this.JobLabel.TabIndex = 9;
            this.JobLabel.Text = "Position";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(407, 385);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(119, 23);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveEmployee);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.TitleLabel.Location = new System.Drawing.Point(195, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(378, 63);
            this.TitleLabel.TabIndex = 11;
            this.TitleLabel.Text = "Add Employee";
            // 
            // EmployeesProjectsCheckedListBox
            // 
            this.EmployeesProjectsCheckedListBox.CheckOnClick = true;
            this.EmployeesProjectsCheckedListBox.FormattingEnabled = true;
            this.EmployeesProjectsCheckedListBox.Location = new System.Drawing.Point(368, 102);
            this.EmployeesProjectsCheckedListBox.Name = "EmployeesProjectsCheckedListBox";
            this.EmployeesProjectsCheckedListBox.Size = new System.Drawing.Size(383, 259);
            this.EmployeesProjectsCheckedListBox.TabIndex = 12;
            // 
            // EmployeeProjectsLabel
            // 
            this.EmployeeProjectsLabel.AutoSize = true;
            this.EmployeeProjectsLabel.Location = new System.Drawing.Point(365, 79);
            this.EmployeeProjectsLabel.Name = "EmployeeProjectsLabel";
            this.EmployeeProjectsLabel.Size = new System.Drawing.Size(104, 13);
            this.EmployeeProjectsLabel.TabIndex = 13;
            this.EmployeeProjectsLabel.Text = "Employee\'s Projects:";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(599, 385);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(133, 23);
            this.CloseButton.TabIndex = 14;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EmployeeProjectsLabel);
            this.Controls.Add(this.EmployeesProjectsCheckedListBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.JobLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.OibLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.JobComboBox);
            this.Controls.Add(this.DateOfBirthDateTimePicker);
            this.Controls.Add(this.OibTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Name = "AddEmployeeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox OibTextBox;
        private System.Windows.Forms.DateTimePicker DateOfBirthDateTimePicker;
        private System.Windows.Forms.ComboBox JobComboBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label OibLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.CheckedListBox EmployeesProjectsCheckedListBox;
        private System.Windows.Forms.Label EmployeeProjectsLabel;
        private System.Windows.Forms.Button CloseButton;
    }
}

