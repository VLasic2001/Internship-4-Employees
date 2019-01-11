namespace Employees.Presentation
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
            this.editEmployeeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.ListOfEmployeesListBox = new System.Windows.Forms.ListBox();
            this.EmployeeDetasilsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editEmployeeButton
            // 
            this.editEmployeeButton.Location = new System.Drawing.Point(606, 246);
            this.editEmployeeButton.Name = "editEmployeeButton";
            this.editEmployeeButton.Size = new System.Drawing.Size(133, 23);
            this.editEmployeeButton.TabIndex = 1;
            this.editEmployeeButton.Text = "Edit Employee";
            this.editEmployeeButton.UseVisualStyleBackColor = true;
            this.editEmployeeButton.Click += new System.EventHandler(this.EditEmployee);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.titleLabel.Location = new System.Drawing.Point(185, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(447, 63);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "List of employees";
            // 
            // ListOfEmployeesListBox
            // 
            this.ListOfEmployeesListBox.FormattingEnabled = true;
            this.ListOfEmployeesListBox.Location = new System.Drawing.Point(39, 95);
            this.ListOfEmployeesListBox.Name = "ListOfEmployeesListBox";
            this.ListOfEmployeesListBox.Size = new System.Drawing.Size(441, 251);
            this.ListOfEmployeesListBox.TabIndex = 3;
            // 
            // EmployeeDetasilsButton
            // 
            this.EmployeeDetasilsButton.Location = new System.Drawing.Point(606, 217);
            this.EmployeeDetasilsButton.Name = "EmployeeDetasilsButton";
            this.EmployeeDetasilsButton.Size = new System.Drawing.Size(133, 23);
            this.EmployeeDetasilsButton.TabIndex = 4;
            this.EmployeeDetasilsButton.Text = "Details";
            this.EmployeeDetasilsButton.UseVisualStyleBackColor = true;
            this.EmployeeDetasilsButton.Click += new System.EventHandler(this.Details);
            // 
            // ListOfEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmployeeDetasilsButton);
            this.Controls.Add(this.ListOfEmployeesListBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.editEmployeeButton);
            this.Name = "ListOfEmployeesForm";
            this.Text = "ListOfEmployeesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button editEmployeeButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListBox ListOfEmployeesListBox;
        private System.Windows.Forms.Button EmployeeDetasilsButton;
    }
}