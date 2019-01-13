namespace Employees.Presentation.EmployeeForms
{
    partial class EditEmployeeForm
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.OibLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.DateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.JobComboBox = new System.Windows.Forms.ComboBox();
            this.PostitonLabel = new System.Windows.Forms.Label();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.EmployeesProjectsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.EditEmployeeTitleLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CheckedListBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(166, 82);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.FirstNameTextBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(166, 154);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // OibTextBox
            // 
            this.OibTextBox.Location = new System.Drawing.Point(166, 305);
            this.OibTextBox.Name = "OibTextBox";
            this.OibTextBox.Size = new System.Drawing.Size(200, 20);
            this.OibTextBox.TabIndex = 2;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(50, 85);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(55, 13);
            this.FirstNameLabel.TabIndex = 3;
            this.FirstNameLabel.Text = "First name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(50, 157);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Last name";
            // 
            // OibLabel
            // 
            this.OibLabel.AutoSize = true;
            this.OibLabel.Location = new System.Drawing.Point(82, 312);
            this.OibLabel.Name = "OibLabel";
            this.OibLabel.Size = new System.Drawing.Size(23, 13);
            this.OibLabel.TabIndex = 5;
            this.OibLabel.Text = "Oib";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(40, 232);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(65, 13);
            this.DateOfBirthLabel.TabIndex = 6;
            this.DateOfBirthLabel.Text = "Date of birth";
            // 
            // DateOfBirthDateTimePicker
            // 
            this.DateOfBirthDateTimePicker.Location = new System.Drawing.Point(166, 225);
            this.DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker";
            this.DateOfBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirthDateTimePicker.TabIndex = 7;
            // 
            // JobComboBox
            // 
            this.JobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JobComboBox.FormattingEnabled = true;
            this.JobComboBox.Items.AddRange(new object[] {
            "Programmer",
            "Designer",
            "Accountant"});
            this.JobComboBox.Location = new System.Drawing.Point(166, 372);
            this.JobComboBox.Name = "JobComboBox";
            this.JobComboBox.Size = new System.Drawing.Size(200, 21);
            this.JobComboBox.TabIndex = 8;
            // 
            // PostitonLabel
            // 
            this.PostitonLabel.AutoSize = true;
            this.PostitonLabel.Location = new System.Drawing.Point(58, 380);
            this.PostitonLabel.Name = "PostitonLabel";
            this.PostitonLabel.Size = new System.Drawing.Size(47, 13);
            this.PostitonLabel.TabIndex = 9;
            this.PostitonLabel.Text = "Postition";
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Location = new System.Drawing.Point(414, 396);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(135, 29);
            this.SaveChangesButton.TabIndex = 10;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = true;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChanges);
            // 
            // EmployeesProjectsCheckedListBox
            // 
            this.EmployeesProjectsCheckedListBox.CheckOnClick = true;
            this.EmployeesProjectsCheckedListBox.FormattingEnabled = true;
            this.EmployeesProjectsCheckedListBox.Location = new System.Drawing.Point(414, 92);
            this.EmployeesProjectsCheckedListBox.Name = "EmployeesProjectsCheckedListBox";
            this.EmployeesProjectsCheckedListBox.Size = new System.Drawing.Size(354, 289);
            this.EmployeesProjectsCheckedListBox.TabIndex = 11;
            this.EmployeesProjectsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ItemCheck);
            // 
            // EditEmployeeTitleLabel
            // 
            this.EditEmployeeTitleLabel.AutoSize = true;
            this.EditEmployeeTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.EditEmployeeTitleLabel.Location = new System.Drawing.Point(209, -3);
            this.EditEmployeeTitleLabel.Name = "EditEmployeeTitleLabel";
            this.EditEmployeeTitleLabel.Size = new System.Drawing.Size(370, 63);
            this.EditEmployeeTitleLabel.TabIndex = 12;
            this.EditEmployeeTitleLabel.Text = "Edit employee";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(639, 396);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(129, 28);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // CheckedListBoxLabel
            // 
            this.CheckedListBoxLabel.AutoSize = true;
            this.CheckedListBoxLabel.Location = new System.Drawing.Point(414, 73);
            this.CheckedListBoxLabel.Name = "CheckedListBoxLabel";
            this.CheckedListBoxLabel.Size = new System.Drawing.Size(135, 13);
            this.CheckedListBoxLabel.TabIndex = 14;
            this.CheckedListBoxLabel.Text = "Select employee\'s projects:";
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckedListBoxLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EditEmployeeTitleLabel);
            this.Controls.Add(this.EmployeesProjectsCheckedListBox);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.PostitonLabel);
            this.Controls.Add(this.JobComboBox);
            this.Controls.Add(this.DateOfBirthDateTimePicker);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.OibLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.OibTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Name = "EditEmployeeForm";
            this.Text = "EditEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox OibTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label OibLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.DateTimePicker DateOfBirthDateTimePicker;
        private System.Windows.Forms.ComboBox JobComboBox;
        private System.Windows.Forms.Label PostitonLabel;
        private System.Windows.Forms.Button SaveChangesButton;
        private System.Windows.Forms.CheckedListBox EmployeesProjectsCheckedListBox;
        private System.Windows.Forms.Label EditEmployeeTitleLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label CheckedListBoxLabel;
    }
}