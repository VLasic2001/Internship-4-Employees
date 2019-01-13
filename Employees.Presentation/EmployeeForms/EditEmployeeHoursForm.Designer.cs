namespace Employees.Presentation.EmployeeForms
{
    partial class EditEmployeeHoursForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ProjectsListBox = new System.Windows.Forms.ListBox();
            this.EditHoursButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ProjectsListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.TitleLabel.Location = new System.Drawing.Point(255, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(270, 63);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Edit hours";
            // 
            // ProjectsListBox
            // 
            this.ProjectsListBox.FormattingEnabled = true;
            this.ProjectsListBox.Location = new System.Drawing.Point(26, 106);
            this.ProjectsListBox.Name = "ProjectsListBox";
            this.ProjectsListBox.Size = new System.Drawing.Size(489, 303);
            this.ProjectsListBox.TabIndex = 1;
            // 
            // EditHoursButton
            // 
            this.EditHoursButton.Location = new System.Drawing.Point(603, 229);
            this.EditHoursButton.Name = "EditHoursButton";
            this.EditHoursButton.Size = new System.Drawing.Size(124, 23);
            this.EditHoursButton.TabIndex = 2;
            this.EditHoursButton.Text = "Edit hours";
            this.EditHoursButton.UseVisualStyleBackColor = true;
            this.EditHoursButton.Click += new System.EventHandler(this.EditHours);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(603, 258);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(124, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // ProjectsListLabel
            // 
            this.ProjectsListLabel.AutoSize = true;
            this.ProjectsListLabel.Location = new System.Drawing.Point(26, 87);
            this.ProjectsListLabel.Name = "ProjectsListLabel";
            this.ProjectsListLabel.Size = new System.Drawing.Size(333, 13);
            this.ProjectsListLabel.TabIndex = 4;
            this.ProjectsListLabel.Text = "Select the project you want to change the employee\'s work hours on:";
            // 
            // EditEmployeeHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProjectsListLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EditHoursButton);
            this.Controls.Add(this.ProjectsListBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "EditEmployeeHoursForm";
            this.Text = "EditEmployeeHoursForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ListBox ProjectsListBox;
        private System.Windows.Forms.Button EditHoursButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label ProjectsListLabel;
    }
}