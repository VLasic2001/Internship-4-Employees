namespace Employees.Presentation
{
    partial class MenuForm
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
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.listEmployeesButton = new System.Windows.Forms.Button();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.menuLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(41, 181);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(160, 23);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.AddEmployee);
            // 
            // listEmployeesButton
            // 
            this.listEmployeesButton.Location = new System.Drawing.Point(41, 152);
            this.listEmployeesButton.Name = "listEmployeesButton";
            this.listEmployeesButton.Size = new System.Drawing.Size(160, 23);
            this.listEmployeesButton.TabIndex = 1;
            this.listEmployeesButton.Text = "List of employees";
            this.listEmployeesButton.UseVisualStyleBackColor = true;
            this.listEmployeesButton.Click += new System.EventHandler(this.ListEmployees);
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Location = new System.Drawing.Point(41, 210);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(160, 23);
            this.deleteEmployeeButton.TabIndex = 2;
            this.deleteEmployeeButton.Text = "Delete Employee";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployee);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.menuLabel.Location = new System.Drawing.Point(336, 31);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(162, 63);
            this.menuLabel.TabIndex = 3;
            this.menuLabel.Text = "Menu";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Controls.Add(this.listEmployeesButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button listEmployeesButton;
        private System.Windows.Forms.Button deleteEmployeeButton;
        private System.Windows.Forms.Label menuLabel;
    }
}