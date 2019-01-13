namespace Employees.Presentation.ProjectForms
{
    partial class EditProjectHoursForm
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
            this.EmployeeListLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.EditHoursButton = new System.Windows.Forms.Button();
            this.EmployeesListBox = new System.Windows.Forms.ListBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeeListLabel
            // 
            this.EmployeeListLabel.AutoSize = true;
            this.EmployeeListLabel.Location = new System.Drawing.Point(22, 97);
            this.EmployeeListLabel.Name = "EmployeeListLabel";
            this.EmployeeListLabel.Size = new System.Drawing.Size(335, 13);
            this.EmployeeListLabel.TabIndex = 9;
            this.EmployeeListLabel.Text = "Select the employee whose hours you want to change on this project:";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(604, 259);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(124, 23);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // EditHoursButton
            // 
            this.EditHoursButton.Location = new System.Drawing.Point(604, 218);
            this.EditHoursButton.Name = "EditHoursButton";
            this.EditHoursButton.Size = new System.Drawing.Size(124, 23);
            this.EditHoursButton.TabIndex = 7;
            this.EditHoursButton.Text = "Edit hours";
            this.EditHoursButton.UseVisualStyleBackColor = true;
            this.EditHoursButton.Click += new System.EventHandler(this.EditHours);
            // 
            // EmployeesListBox
            // 
            this.EmployeesListBox.FormattingEnabled = true;
            this.EmployeesListBox.Location = new System.Drawing.Point(25, 122);
            this.EmployeesListBox.Name = "EmployeesListBox";
            this.EmployeesListBox.Size = new System.Drawing.Size(489, 303);
            this.EmployeesListBox.TabIndex = 6;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.TitleLabel.Location = new System.Drawing.Point(269, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(270, 63);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Edit hours";
            // 
            // EditProjectHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmployeeListLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EditHoursButton);
            this.Controls.Add(this.EmployeesListBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "EditProjectHoursForm";
            this.Text = "EditProjectHoursForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeListLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button EditHoursButton;
        private System.Windows.Forms.ListBox EmployeesListBox;
        private System.Windows.Forms.Label TitleLabel;
    }
}