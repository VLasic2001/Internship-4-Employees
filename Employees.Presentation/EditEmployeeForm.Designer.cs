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
            this.SuspendLayout();
            // 
            // editEmployeeFirstNameTextBox
            // 
            this.editEmployeeFirstNameTextBox.Location = new System.Drawing.Point(363, 84);
            this.editEmployeeFirstNameTextBox.Name = "editEmployeeFirstNameTextBox";
            this.editEmployeeFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.editEmployeeFirstNameTextBox.TabIndex = 0;
            // 
            // editEmployeeLastNameTextBox
            // 
            this.editEmployeeLastNameTextBox.Location = new System.Drawing.Point(363, 151);
            this.editEmployeeLastNameTextBox.Name = "editEmployeeLastNameTextBox";
            this.editEmployeeLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.editEmployeeLastNameTextBox.TabIndex = 1;
            // 
            // editEmployeeOibTextBox
            // 
            this.editEmployeeOibTextBox.Location = new System.Drawing.Point(363, 314);
            this.editEmployeeOibTextBox.Name = "editEmployeeOibTextBox";
            this.editEmployeeOibTextBox.Size = new System.Drawing.Size(100, 20);
            this.editEmployeeOibTextBox.TabIndex = 2;
            // 
            // editEmployeeFirstNameLabel
            // 
            this.editEmployeeFirstNameLabel.AutoSize = true;
            this.editEmployeeFirstNameLabel.Location = new System.Drawing.Point(247, 91);
            this.editEmployeeFirstNameLabel.Name = "editEmployeeFirstNameLabel";
            this.editEmployeeFirstNameLabel.Size = new System.Drawing.Size(55, 13);
            this.editEmployeeFirstNameLabel.TabIndex = 3;
            this.editEmployeeFirstNameLabel.Text = "First name";
            // 
            // editEmployeeLastNameLabel
            // 
            this.editEmployeeLastNameLabel.AutoSize = true;
            this.editEmployeeLastNameLabel.Location = new System.Drawing.Point(246, 154);
            this.editEmployeeLastNameLabel.Name = "editEmployeeLastNameLabel";
            this.editEmployeeLastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.editEmployeeLastNameLabel.TabIndex = 4;
            this.editEmployeeLastNameLabel.Text = "Last name";
            // 
            // editEmployeeOibLabel
            // 
            this.editEmployeeOibLabel.AutoSize = true;
            this.editEmployeeOibLabel.Location = new System.Drawing.Point(279, 321);
            this.editEmployeeOibLabel.Name = "editEmployeeOibLabel";
            this.editEmployeeOibLabel.Size = new System.Drawing.Size(23, 13);
            this.editEmployeeOibLabel.TabIndex = 5;
            this.editEmployeeOibLabel.Text = "Oib";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date of birth";
            // 
            // editEmployeeDateTimePicker
            // 
            this.editEmployeeDateTimePicker.Location = new System.Drawing.Point(363, 234);
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
            this.editEmployeeJobComboBox.Location = new System.Drawing.Point(363, 381);
            this.editEmployeeJobComboBox.Name = "editEmployeeJobComboBox";
            this.editEmployeeJobComboBox.Size = new System.Drawing.Size(121, 21);
            this.editEmployeeJobComboBox.TabIndex = 8;
            // 
            // editEmployeePostitonLabel
            // 
            this.editEmployeePostitonLabel.AutoSize = true;
            this.editEmployeePostitonLabel.Location = new System.Drawing.Point(255, 389);
            this.editEmployeePostitonLabel.Name = "editEmployeePostitonLabel";
            this.editEmployeePostitonLabel.Size = new System.Drawing.Size(47, 13);
            this.editEmployeePostitonLabel.TabIndex = 9;
            this.editEmployeePostitonLabel.Text = "Postition";
            // 
            // editEmployeeSaveChangesButton
            // 
            this.editEmployeeSaveChangesButton.Location = new System.Drawing.Point(619, 232);
            this.editEmployeeSaveChangesButton.Name = "editEmployeeSaveChangesButton";
            this.editEmployeeSaveChangesButton.Size = new System.Drawing.Size(135, 29);
            this.editEmployeeSaveChangesButton.TabIndex = 10;
            this.editEmployeeSaveChangesButton.Text = "Save Changes";
            this.editEmployeeSaveChangesButton.UseVisualStyleBackColor = true;
            this.editEmployeeSaveChangesButton.Click += new System.EventHandler(this.SaveChanges);
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}