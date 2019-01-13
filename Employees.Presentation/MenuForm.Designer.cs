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
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.ListEmployeesButton = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.AddProjectButton = new System.Windows.Forms.Button();
            this.ListOfProjectsButton = new System.Windows.Forms.Button();
            this.DeleteProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(41, 181);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(160, 23);
            this.AddEmployeeButton.TabIndex = 0;
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployee);
            // 
            // ListEmployeesButton
            // 
            this.ListEmployeesButton.Location = new System.Drawing.Point(41, 152);
            this.ListEmployeesButton.Name = "ListEmployeesButton";
            this.ListEmployeesButton.Size = new System.Drawing.Size(160, 23);
            this.ListEmployeesButton.TabIndex = 1;
            this.ListEmployeesButton.Text = "List of employees";
            this.ListEmployeesButton.UseVisualStyleBackColor = true;
            this.ListEmployeesButton.Click += new System.EventHandler(this.ListEmployees);
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(41, 210);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(160, 23);
            this.DeleteEmployeeButton.TabIndex = 2;
            this.DeleteEmployeeButton.Text = "Delete Employee";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployee);
            // 
            // MenuLabel
            // 
            this.MenuLabel.AutoSize = true;
            this.MenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.MenuLabel.Location = new System.Drawing.Point(196, 36);
            this.MenuLabel.Name = "MenuLabel";
            this.MenuLabel.Size = new System.Drawing.Size(162, 63);
            this.MenuLabel.TabIndex = 3;
            this.MenuLabel.Text = "Menu";
            // 
            // AddProjectButton
            // 
            this.AddProjectButton.Location = new System.Drawing.Point(347, 180);
            this.AddProjectButton.Name = "AddProjectButton";
            this.AddProjectButton.Size = new System.Drawing.Size(158, 23);
            this.AddProjectButton.TabIndex = 4;
            this.AddProjectButton.Text = "Add project";
            this.AddProjectButton.UseVisualStyleBackColor = true;
            this.AddProjectButton.Click += new System.EventHandler(this.AddProject);
            // 
            // ListOfProjectsButton
            // 
            this.ListOfProjectsButton.Location = new System.Drawing.Point(347, 151);
            this.ListOfProjectsButton.Name = "ListOfProjectsButton";
            this.ListOfProjectsButton.Size = new System.Drawing.Size(158, 23);
            this.ListOfProjectsButton.TabIndex = 5;
            this.ListOfProjectsButton.Text = "List of projects";
            this.ListOfProjectsButton.UseVisualStyleBackColor = true;
            this.ListOfProjectsButton.Click += new System.EventHandler(this.ListProjects);
            // 
            // DeleteProjectButton
            // 
            this.DeleteProjectButton.Location = new System.Drawing.Point(347, 210);
            this.DeleteProjectButton.Name = "DeleteProjectButton";
            this.DeleteProjectButton.Size = new System.Drawing.Size(158, 23);
            this.DeleteProjectButton.TabIndex = 6;
            this.DeleteProjectButton.Text = "Delete project";
            this.DeleteProjectButton.UseVisualStyleBackColor = true;
            this.DeleteProjectButton.Click += new System.EventHandler(this.DeleteProject);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 330);
            this.Controls.Add(this.DeleteProjectButton);
            this.Controls.Add(this.ListOfProjectsButton);
            this.Controls.Add(this.AddProjectButton);
            this.Controls.Add(this.MenuLabel);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.ListEmployeesButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Name = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button ListEmployeesButton;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Button AddProjectButton;
        private System.Windows.Forms.Button ListOfProjectsButton;
        private System.Windows.Forms.Button DeleteProjectButton;
    }
}