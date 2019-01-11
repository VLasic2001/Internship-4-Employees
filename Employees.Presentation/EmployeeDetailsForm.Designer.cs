using System.Windows.Forms;

namespace Employees.Presentation
{
    partial class EmployeeDetailsForm
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
            this.EmployeeDetailsSaveChangesButton = new System.Windows.Forms.Button();
            this.EmployeeDetailsPostitonLabel = new System.Windows.Forms.Label();
            this.EmployeeDetailsDateofBirthLabel = new System.Windows.Forms.Label();
            this.EmployeeDetailsOibLabel = new System.Windows.Forms.Label();
            this.EmployeeDetailsLastNameLabel = new System.Windows.Forms.Label();
            this.EmployeeDetailsFirstNameLabel = new System.Windows.Forms.Label();
            this.FinishedProjectsLabel = new System.Windows.Forms.Label();
            this.ActiveProjectsLabel = new System.Windows.Forms.Label();
            this.PlannedProjectsLabel = new System.Windows.Forms.Label();
            this.Indicator = new System.Windows.Forms.Button();
            this.EmployeeDetailsTitleLabel = new System.Windows.Forms.Label();
            this.WeeklyWorkHoursLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeeDetailsSaveChangesButton
            // 
            this.EmployeeDetailsSaveChangesButton.Location = new System.Drawing.Point(41, 342);
            this.EmployeeDetailsSaveChangesButton.Name = "EmployeeDetailsSaveChangesButton";
            this.EmployeeDetailsSaveChangesButton.Size = new System.Drawing.Size(135, 29);
            this.EmployeeDetailsSaveChangesButton.TabIndex = 21;
            this.EmployeeDetailsSaveChangesButton.Text = "Edit employee";
            this.EmployeeDetailsSaveChangesButton.UseVisualStyleBackColor = true;
            this.EmployeeDetailsSaveChangesButton.Click += new System.EventHandler(this.EditEmployee);
            // 
            // EmployeeDetailsPostitonLabel
            // 
            this.EmployeeDetailsPostitonLabel.AutoSize = true;
            this.EmployeeDetailsPostitonLabel.Location = new System.Drawing.Point(38, 222);
            this.EmployeeDetailsPostitonLabel.Name = "EmployeeDetailsPostitonLabel";
            this.EmployeeDetailsPostitonLabel.Size = new System.Drawing.Size(50, 13);
            this.EmployeeDetailsPostitonLabel.TabIndex = 20;
            this.EmployeeDetailsPostitonLabel.Text = "Postition:";
            // 
            // EmployeeDetailsDateofBirthLabel
            // 
            this.EmployeeDetailsDateofBirthLabel.AutoSize = true;
            this.EmployeeDetailsDateofBirthLabel.Location = new System.Drawing.Point(38, 169);
            this.EmployeeDetailsDateofBirthLabel.Name = "EmployeeDetailsDateofBirthLabel";
            this.EmployeeDetailsDateofBirthLabel.Size = new System.Drawing.Size(68, 13);
            this.EmployeeDetailsDateofBirthLabel.TabIndex = 17;
            this.EmployeeDetailsDateofBirthLabel.Text = "Date of birth:";
            // 
            // EmployeeDetailsOibLabel
            // 
            this.EmployeeDetailsOibLabel.AutoSize = true;
            this.EmployeeDetailsOibLabel.Location = new System.Drawing.Point(38, 195);
            this.EmployeeDetailsOibLabel.Name = "EmployeeDetailsOibLabel";
            this.EmployeeDetailsOibLabel.Size = new System.Drawing.Size(26, 13);
            this.EmployeeDetailsOibLabel.TabIndex = 16;
            this.EmployeeDetailsOibLabel.Text = "Oib:";
            // 
            // EmployeeDetailsLastNameLabel
            // 
            this.EmployeeDetailsLastNameLabel.AutoSize = true;
            this.EmployeeDetailsLastNameLabel.Location = new System.Drawing.Point(38, 142);
            this.EmployeeDetailsLastNameLabel.Name = "EmployeeDetailsLastNameLabel";
            this.EmployeeDetailsLastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.EmployeeDetailsLastNameLabel.TabIndex = 15;
            this.EmployeeDetailsLastNameLabel.Text = "Last name:";
            // 
            // EmployeeDetailsFirstNameLabel
            // 
            this.EmployeeDetailsFirstNameLabel.AutoSize = true;
            this.EmployeeDetailsFirstNameLabel.Location = new System.Drawing.Point(38, 115);
            this.EmployeeDetailsFirstNameLabel.Name = "EmployeeDetailsFirstNameLabel";
            this.EmployeeDetailsFirstNameLabel.Size = new System.Drawing.Size(58, 13);
            this.EmployeeDetailsFirstNameLabel.TabIndex = 14;
            this.EmployeeDetailsFirstNameLabel.Text = "First name:";
            // 
            // FinishedProjectsLabel
            // 
            this.FinishedProjectsLabel.AutoSize = true;
            this.FinishedProjectsLabel.Location = new System.Drawing.Point(511, 115);
            this.FinishedProjectsLabel.Name = "FinishedProjectsLabel";
            this.FinishedProjectsLabel.Size = new System.Drawing.Size(89, 13);
            this.FinishedProjectsLabel.TabIndex = 22;
            this.FinishedProjectsLabel.Text = "Finished projects:";
            // 
            // ActiveProjectsLabel
            // 
            this.ActiveProjectsLabel.AutoSize = true;
            this.ActiveProjectsLabel.Location = new System.Drawing.Point(511, 142);
            this.ActiveProjectsLabel.Name = "ActiveProjectsLabel";
            this.ActiveProjectsLabel.Size = new System.Drawing.Size(80, 13);
            this.ActiveProjectsLabel.TabIndex = 23;
            this.ActiveProjectsLabel.Text = "Active projects:";
            // 
            // PlannedProjectsLabel
            // 
            this.PlannedProjectsLabel.AutoSize = true;
            this.PlannedProjectsLabel.Location = new System.Drawing.Point(511, 169);
            this.PlannedProjectsLabel.Name = "PlannedProjectsLabel";
            this.PlannedProjectsLabel.Size = new System.Drawing.Size(89, 13);
            this.PlannedProjectsLabel.TabIndex = 24;
            this.PlannedProjectsLabel.Text = "Planned projects:";
            // 
            // Indicator
            // 
            this.Indicator.BackColor = System.Drawing.Color.Yellow;
            this.Indicator.Enabled = false;
            this.Indicator.FlatAppearance.BorderSize = 0;
            this.Indicator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Indicator.Location = new System.Drawing.Point(102, 111);
            this.Indicator.Name = "Indicator";
            this.Indicator.Size = new System.Drawing.Size(20, 20);
            this.Indicator.TabIndex = 25;
            this.Indicator.TabStop = false;
            this.Indicator.UseVisualStyleBackColor = false;
            // 
            // EmployeeDetailsTitleLabel
            // 
            this.EmployeeDetailsTitleLabel.AutoSize = true;
            this.EmployeeDetailsTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.EmployeeDetailsTitleLabel.Location = new System.Drawing.Point(160, 25);
            this.EmployeeDetailsTitleLabel.Name = "EmployeeDetailsTitleLabel";
            this.EmployeeDetailsTitleLabel.Size = new System.Drawing.Size(440, 63);
            this.EmployeeDetailsTitleLabel.TabIndex = 26;
            this.EmployeeDetailsTitleLabel.Text = "Employee details";
            // 
            // WeeklyWorkHoursLabel
            // 
            this.WeeklyWorkHoursLabel.AutoSize = true;
            this.WeeklyWorkHoursLabel.Location = new System.Drawing.Point(511, 195);
            this.WeeklyWorkHoursLabel.Name = "WeeklyWorkHoursLabel";
            this.WeeklyWorkHoursLabel.Size = new System.Drawing.Size(161, 13);
            this.WeeklyWorkHoursLabel.TabIndex = 27;
            this.WeeklyWorkHoursLabel.Text = "Number of work hours per week:";
            // 
            // EmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WeeklyWorkHoursLabel);
            this.Controls.Add(this.EmployeeDetailsTitleLabel);
            this.Controls.Add(this.Indicator);
            this.Controls.Add(this.PlannedProjectsLabel);
            this.Controls.Add(this.ActiveProjectsLabel);
            this.Controls.Add(this.FinishedProjectsLabel);
            this.Controls.Add(this.EmployeeDetailsSaveChangesButton);
            this.Controls.Add(this.EmployeeDetailsPostitonLabel);
            this.Controls.Add(this.EmployeeDetailsDateofBirthLabel);
            this.Controls.Add(this.EmployeeDetailsOibLabel);
            this.Controls.Add(this.EmployeeDetailsLastNameLabel);
            this.Controls.Add(this.EmployeeDetailsFirstNameLabel);
            this.Name = "EmployeeDetailsForm";
            this.Text = "EmployeeDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EmployeeDetailsSaveChangesButton;
        private System.Windows.Forms.Label EmployeeDetailsPostitonLabel;
        private System.Windows.Forms.Label EmployeeDetailsDateofBirthLabel;
        private System.Windows.Forms.Label EmployeeDetailsOibLabel;
        private System.Windows.Forms.Label EmployeeDetailsLastNameLabel;
        private System.Windows.Forms.Label EmployeeDetailsFirstNameLabel;
        private System.Windows.Forms.Label FinishedProjectsLabel;
        private System.Windows.Forms.Label ActiveProjectsLabel;
        private System.Windows.Forms.Label PlannedProjectsLabel;
        private System.Windows.Forms.Button Indicator;
        private Label EmployeeDetailsTitleLabel;
        private Label WeeklyWorkHoursLabel;
    }
}