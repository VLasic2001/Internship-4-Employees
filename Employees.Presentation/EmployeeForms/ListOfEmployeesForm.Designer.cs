namespace Employees.Presentation.EmployeeForms
{
    partial class ListOfEmployeesForm
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
            this.EditEmployeeButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ListOfEmployeesListBox = new System.Windows.Forms.ListBox();
            this.EmployeeDetailsButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ListOfEmployeesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditEmployeeButton
            // 
            this.EditEmployeeButton.Location = new System.Drawing.Point(590, 247);
            this.EditEmployeeButton.Name = "EditEmployeeButton";
            this.EditEmployeeButton.Size = new System.Drawing.Size(133, 23);
            this.EditEmployeeButton.TabIndex = 1;
            this.EditEmployeeButton.Text = "Edit Employee";
            this.EditEmployeeButton.UseVisualStyleBackColor = true;
            this.EditEmployeeButton.Click += new System.EventHandler(this.EditEmployee);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.TitleLabel.Location = new System.Drawing.Point(185, 18);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(447, 63);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "List of employees";
            // 
            // ListOfEmployeesListBox
            // 
            this.ListOfEmployeesListBox.FormattingEnabled = true;
            this.ListOfEmployeesListBox.Location = new System.Drawing.Point(38, 149);
            this.ListOfEmployeesListBox.Name = "ListOfEmployeesListBox";
            this.ListOfEmployeesListBox.Size = new System.Drawing.Size(441, 251);
            this.ListOfEmployeesListBox.TabIndex = 3;
            // 
            // EmployeeDetailsButton
            // 
            this.EmployeeDetailsButton.Location = new System.Drawing.Point(590, 217);
            this.EmployeeDetailsButton.Name = "EmployeeDetailsButton";
            this.EmployeeDetailsButton.Size = new System.Drawing.Size(133, 23);
            this.EmployeeDetailsButton.TabIndex = 4;
            this.EmployeeDetailsButton.Text = "Details";
            this.EmployeeDetailsButton.UseVisualStyleBackColor = true;
            this.EmployeeDetailsButton.Click += new System.EventHandler(this.Details);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(590, 276);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(133, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // ListOfEmployeesLabel
            // 
            this.ListOfEmployeesLabel.AutoSize = true;
            this.ListOfEmployeesLabel.Location = new System.Drawing.Point(38, 130);
            this.ListOfEmployeesLabel.Name = "ListOfEmployeesLabel";
            this.ListOfEmployeesLabel.Size = new System.Drawing.Size(279, 13);
            this.ListOfEmployeesLabel.TabIndex = 6;
            this.ListOfEmployeesLabel.Text = "Select the employee you want to edit or see the details of:";
            // 
            // ListOfEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListOfEmployeesLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EmployeeDetailsButton);
            this.Controls.Add(this.ListOfEmployeesListBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.EditEmployeeButton);
            this.Name = "ListOfEmployeesForm";
            this.Text = "ListOfEmployeesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EditEmployeeButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox ListOfEmployeesListBox;
        private System.Windows.Forms.Button EmployeeDetailsButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label ListOfEmployeesLabel;
    }
}