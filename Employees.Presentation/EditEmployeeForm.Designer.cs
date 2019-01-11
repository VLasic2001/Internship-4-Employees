namespace Employees.Presentation
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
            this.editEmployeeFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.editEmployeeLastNameTextBox = new System.Windows.Forms.TextBox();
            this.editEmployeeOibTextBox = new System.Windows.Forms.TextBox();
            this.editEmployeeFirstNameLabel = new System.Windows.Forms.Label();
            this.editEmployeeLastNameLabel = new System.Windows.Forms.Label();
            this.editEmployeeOibLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.editEmployeeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.editEmployeeJobComboBox = new System.Windows.Forms.ComboBox();
            this.editEmployeePostitonLabel = new System.Windows.Forms.Label();
            this.editEmployeeSaveChangesButton = new System.Windows.Forms.Button();
            this.EmployeesProjectsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.EditEmployeeTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editEmployeeFirstNameTextBox
            // 
            this.editEmployeeFirstNameTextBox.Location = new System.Drawing.Point(166, 75);
            this.editEmployeeFirstNameTextBox.Name = "editEmployeeFirstNameTextBox";
            this.editEmployeeFirstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.editEmployeeFirstNameTextBox.TabIndex = 0;
            // 
            // editEmployeeLastNameTextBox
            // 
            this.editEmployeeLastNameTextBox.Location = new System.Drawing.Point(166, 142);
            this.editEmployeeLastNameTextBox.Name = "editEmployeeLastNameTextBox";
            this.editEmployeeLastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.editEmployeeLastNameTextBox.TabIndex = 1;
            // 
            // editEmployeeOibTextBox
            // 
            this.editEmployeeOibTextBox.Location = new System.Drawing.Point(166, 305);
            this.editEmployeeOibTextBox.Name = "editEmployeeOibTextBox";
            this.editEmployeeOibTextBox.Size = new System.Drawing.Size(200, 20);
            this.editEmployeeOibTextBox.TabIndex = 2;
            // 
            // editEmployeeFirstNameLabel
            // 
            this.editEmployeeFirstNameLabel.AutoSize = true;
            this.editEmployeeFirstNameLabel.Location = new System.Drawing.Point(50, 82);
            this.editEmployeeFirstNameLabel.Name = "editEmployeeFirstNameLabel";
            this.editEmployeeFirstNameLabel.Size = new System.Drawing.Size(55, 13);
            this.editEmployeeFirstNameLabel.TabIndex = 3;
            this.editEmployeeFirstNameLabel.Text = "First name";
            // 
            // editEmployeeLastNameLabel
            // 
            this.editEmployeeLastNameLabel.AutoSize = true;
            this.editEmployeeLastNameLabel.Location = new System.Drawing.Point(49, 145);
            this.editEmployeeLastNameLabel.Name = "editEmployeeLastNameLabel";
            this.editEmployeeLastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.editEmployeeLastNameLabel.TabIndex = 4;
            this.editEmployeeLastNameLabel.Text = "Last name";
            // 
            // editEmployeeOibLabel
            // 
            this.editEmployeeOibLabel.AutoSize = true;
            this.editEmployeeOibLabel.Location = new System.Drawing.Point(82, 312);
            this.editEmployeeOibLabel.Name = "editEmployeeOibLabel";
            this.editEmployeeOibLabel.Size = new System.Drawing.Size(23, 13);
            this.editEmployeeOibLabel.TabIndex = 5;
            this.editEmployeeOibLabel.Text = "Oib";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date of birth";
            // 
            // editEmployeeDateTimePicker
            // 
            this.editEmployeeDateTimePicker.Location = new System.Drawing.Point(166, 225);
            this.editEmployeeDateTimePicker.Name = "editEmployeeDateTimePicker";
            this.editEmployeeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.editEmployeeDateTimePicker.TabIndex = 7;
            // 
            // editEmployeeJobComboBox
            // 
            this.editEmployeeJobComboBox.FormattingEnabled = true;
            this.editEmployeeJobComboBox.Items.AddRange(new object[] {
            "Programmer",
            "Designer",
            "Accountant"});
            this.editEmployeeJobComboBox.Location = new System.Drawing.Point(166, 372);
            this.editEmployeeJobComboBox.Name = "editEmployeeJobComboBox";
            this.editEmployeeJobComboBox.Size = new System.Drawing.Size(200, 21);
            this.editEmployeeJobComboBox.TabIndex = 8;
            // 
            // editEmployeePostitonLabel
            // 
            this.editEmployeePostitonLabel.AutoSize = true;
            this.editEmployeePostitonLabel.Location = new System.Drawing.Point(58, 380);
            this.editEmployeePostitonLabel.Name = "editEmployeePostitonLabel";
            this.editEmployeePostitonLabel.Size = new System.Drawing.Size(47, 13);
            this.editEmployeePostitonLabel.TabIndex = 9;
            this.editEmployeePostitonLabel.Text = "Postition";
            // 
            // editEmployeeSaveChangesButton
            // 
            this.editEmployeeSaveChangesButton.Location = new System.Drawing.Point(509, 390);
            this.editEmployeeSaveChangesButton.Name = "editEmployeeSaveChangesButton";
            this.editEmployeeSaveChangesButton.Size = new System.Drawing.Size(135, 29);
            this.editEmployeeSaveChangesButton.TabIndex = 10;
            this.editEmployeeSaveChangesButton.Text = "Save Changes";
            this.editEmployeeSaveChangesButton.UseVisualStyleBackColor = true;
            this.editEmployeeSaveChangesButton.Click += new System.EventHandler(this.SaveChanges);
            // 
            // EmployeesProjectsCheckedListBox
            // 
            this.EmployeesProjectsCheckedListBox.FormattingEnabled = true;
            this.EmployeesProjectsCheckedListBox.Location = new System.Drawing.Point(414, 75);
            this.EmployeesProjectsCheckedListBox.Name = "EmployeesProjectsCheckedListBox";
            this.EmployeesProjectsCheckedListBox.Size = new System.Drawing.Size(354, 289);
            this.EmployeesProjectsCheckedListBox.TabIndex = 11;
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
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditEmployeeTitleLabel);
            this.Controls.Add(this.EmployeesProjectsCheckedListBox);
            this.Controls.Add(this.editEmployeeSaveChangesButton);
            this.Controls.Add(this.editEmployeePostitonLabel);
            this.Controls.Add(this.editEmployeeJobComboBox);
            this.Controls.Add(this.editEmployeeDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.editEmployeeOibLabel);
            this.Controls.Add(this.editEmployeeLastNameLabel);
            this.Controls.Add(this.editEmployeeFirstNameLabel);
            this.Controls.Add(this.editEmployeeOibTextBox);
            this.Controls.Add(this.editEmployeeLastNameTextBox);
            this.Controls.Add(this.editEmployeeFirstNameTextBox);
            this.Name = "EditEmployeeForm";
            this.Text = "EditEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editEmployeeFirstNameTextBox;
        private System.Windows.Forms.TextBox editEmployeeLastNameTextBox;
        private System.Windows.Forms.TextBox editEmployeeOibTextBox;
        private System.Windows.Forms.Label editEmployeeFirstNameLabel;
        private System.Windows.Forms.Label editEmployeeLastNameLabel;
        private System.Windows.Forms.Label editEmployeeOibLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker editEmployeeDateTimePicker;
        private System.Windows.Forms.ComboBox editEmployeeJobComboBox;
        private System.Windows.Forms.Label editEmployeePostitonLabel;
        private System.Windows.Forms.Button editEmployeeSaveChangesButton;
        private System.Windows.Forms.CheckedListBox EmployeesProjectsCheckedListBox;
        private System.Windows.Forms.Label EditEmployeeTitleLabel;
    }
}