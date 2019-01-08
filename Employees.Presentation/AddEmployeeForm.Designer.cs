namespace Employees.Presentation
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
            this.employeeFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeLastNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeOibTextBox = new System.Windows.Forms.TextBox();
            this.employeeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employeeJobComboBox = new System.Windows.Forms.ComboBox();
            this.employeeFirstNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeDateofBirthLabel = new System.Windows.Forms.Label();
            this.employeeJobLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeFirstNameTextBox
            // 
            this.employeeFirstNameTextBox.Location = new System.Drawing.Point(388, 80);
            this.employeeFirstNameTextBox.Name = "employeeFirstNameTextBox";
            this.employeeFirstNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.employeeFirstNameTextBox.TabIndex = 0;
            // 
            // employeeLastNameTextBox
            // 
            this.employeeLastNameTextBox.Location = new System.Drawing.Point(388, 156);
            this.employeeLastNameTextBox.Name = "employeeLastNameTextBox";
            this.employeeLastNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.employeeLastNameTextBox.TabIndex = 1;
            // 
            // employeeOibTextBox
            // 
            this.employeeOibTextBox.Location = new System.Drawing.Point(388, 304);
            this.employeeOibTextBox.Name = "employeeOibTextBox";
            this.employeeOibTextBox.Size = new System.Drawing.Size(121, 20);
            this.employeeOibTextBox.TabIndex = 2;
            // 
            // employeeDateTimePicker
            // 
            this.employeeDateTimePicker.Location = new System.Drawing.Point(388, 232);
            this.employeeDateTimePicker.Name = "employeeDateTimePicker";
            this.employeeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.employeeDateTimePicker.TabIndex = 3;
            // 
            // employeeJobComboBox
            // 
            this.employeeJobComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeJobComboBox.FormattingEnabled = true;
            this.employeeJobComboBox.Items.AddRange(new object[] {
            "Programmer",
            "Designer",
            "Accountant"});
            this.employeeJobComboBox.Location = new System.Drawing.Point(388, 372);
            this.employeeJobComboBox.Name = "employeeJobComboBox";
            this.employeeJobComboBox.Size = new System.Drawing.Size(121, 21);
            this.employeeJobComboBox.TabIndex = 4;
            // 
            // employeeFirstNameLabel
            // 
            this.employeeFirstNameLabel.AutoSize = true;
            this.employeeFirstNameLabel.Location = new System.Drawing.Point(319, 83);
            this.employeeFirstNameLabel.Name = "employeeFirstNameLabel";
            this.employeeFirstNameLabel.Size = new System.Drawing.Size(55, 13);
            this.employeeFirstNameLabel.TabIndex = 5;
            this.employeeFirstNameLabel.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Oib";
            // 
            // employeeDateofBirthLabel
            // 
            this.employeeDateofBirthLabel.AutoSize = true;
            this.employeeDateofBirthLabel.Location = new System.Drawing.Point(309, 232);
            this.employeeDateofBirthLabel.Name = "employeeDateofBirthLabel";
            this.employeeDateofBirthLabel.Size = new System.Drawing.Size(65, 13);
            this.employeeDateofBirthLabel.TabIndex = 8;
            this.employeeDateofBirthLabel.Text = "Date of birth";
            // 
            // employeeJobLabel
            // 
            this.employeeJobLabel.AutoSize = true;
            this.employeeJobLabel.Location = new System.Drawing.Point(330, 375);
            this.employeeJobLabel.Name = "employeeJobLabel";
            this.employeeJobLabel.Size = new System.Drawing.Size(44, 13);
            this.employeeJobLabel.TabIndex = 9;
            this.employeeJobLabel.Text = "Position";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(675, 200);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveEmployee);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(329, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add Employee";
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.employeeJobLabel);
            this.Controls.Add(this.employeeDateofBirthLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeeFirstNameLabel);
            this.Controls.Add(this.employeeJobComboBox);
            this.Controls.Add(this.employeeDateTimePicker);
            this.Controls.Add(this.employeeOibTextBox);
            this.Controls.Add(this.employeeLastNameTextBox);
            this.Controls.Add(this.employeeFirstNameTextBox);
            this.Name = "AddEmployeeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox employeeFirstNameTextBox;
        private System.Windows.Forms.TextBox employeeLastNameTextBox;
        private System.Windows.Forms.TextBox employeeOibTextBox;
        private System.Windows.Forms.DateTimePicker employeeDateTimePicker;
        private System.Windows.Forms.ComboBox employeeJobComboBox;
        private System.Windows.Forms.Label employeeFirstNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label employeeDateofBirthLabel;
        private System.Windows.Forms.Label employeeJobLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
    }
}

