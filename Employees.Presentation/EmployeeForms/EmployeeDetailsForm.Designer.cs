using System.Windows.Forms;

namespace Employees.Presentation.EmployeeForms
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
            this.EditEmployeeButton = new System.Windows.Forms.Button();
            this.PostitonLabel = new System.Windows.Forms.Label();
            this.DateofBirthLabel = new System.Windows.Forms.Label();
            this.OibLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FinishedProjectsLabel = new System.Windows.Forms.Label();
            this.ActiveProjectsLabel = new System.Windows.Forms.Label();
            this.PlannedProjectsLabel = new System.Windows.Forms.Label();
            this.Indicator = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TotalnumberOfProjectsLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.WeeklyWorkHoursLabel = new System.Windows.Forms.Label();
            this.EditHoursButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditEmployeeButton
            // 
            this.EditEmployeeButton.Location = new System.Drawing.Point(41, 342);
            this.EditEmployeeButton.Name = "EditEmployeeButton";
            this.EditEmployeeButton.Size = new System.Drawing.Size(135, 29);
            this.EditEmployeeButton.TabIndex = 21;
            this.EditEmployeeButton.Text = "Edit employee";
            this.EditEmployeeButton.UseVisualStyleBackColor = true;
            this.EditEmployeeButton.Click += new System.EventHandler(this.EditEmployee);
            // 
            // PostitonLabel
            // 
            this.PostitonLabel.AutoSize = true;
            this.PostitonLabel.Location = new System.Drawing.Point(38, 222);
            this.PostitonLabel.Name = "PostitonLabel";
            this.PostitonLabel.Size = new System.Drawing.Size(50, 13);
            this.PostitonLabel.TabIndex = 20;
            this.PostitonLabel.Text = "Postition:";
            // 
            // DateofBirthLabel
            // 
            this.DateofBirthLabel.AutoSize = true;
            this.DateofBirthLabel.Location = new System.Drawing.Point(38, 169);
            this.DateofBirthLabel.Name = "DateofBirthLabel";
            this.DateofBirthLabel.Size = new System.Drawing.Size(68, 13);
            this.DateofBirthLabel.TabIndex = 17;
            this.DateofBirthLabel.Text = "Date of birth:";
            // 
            // OibLabel
            // 
            this.OibLabel.AutoSize = true;
            this.OibLabel.Location = new System.Drawing.Point(38, 195);
            this.OibLabel.Name = "OibLabel";
            this.OibLabel.Size = new System.Drawing.Size(26, 13);
            this.OibLabel.TabIndex = 16;
            this.OibLabel.Text = "Oib:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(38, 142);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.LastNameLabel.TabIndex = 15;
            this.LastNameLabel.Text = "Last name:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(38, 115);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(58, 13);
            this.FirstNameLabel.TabIndex = 14;
            this.FirstNameLabel.Text = "First name:";
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
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.TitleLabel.Location = new System.Drawing.Point(160, 25);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(440, 63);
            this.TitleLabel.TabIndex = 26;
            this.TitleLabel.Text = "Employee details";
            // 
            // TotalnumberOfProjectsLabel
            // 
            this.TotalnumberOfProjectsLabel.AutoSize = true;
            this.TotalnumberOfProjectsLabel.Location = new System.Drawing.Point(511, 195);
            this.TotalnumberOfProjectsLabel.Name = "TotalnumberOfProjectsLabel";
            this.TotalnumberOfProjectsLabel.Size = new System.Drawing.Size(124, 13);
            this.TotalnumberOfProjectsLabel.TabIndex = 27;
            this.TotalnumberOfProjectsLabel.Text = "Total number of projects:";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(514, 342);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(132, 28);
            this.CloseButton.TabIndex = 28;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // WeeklyWorkHoursLabel
            // 
            this.WeeklyWorkHoursLabel.AutoSize = true;
            this.WeeklyWorkHoursLabel.Location = new System.Drawing.Point(514, 221);
            this.WeeklyWorkHoursLabel.Name = "WeeklyWorkHoursLabel";
            this.WeeklyWorkHoursLabel.Size = new System.Drawing.Size(161, 13);
            this.WeeklyWorkHoursLabel.TabIndex = 29;
            this.WeeklyWorkHoursLabel.Text = "Number of work hours per week:";
            // 
            // EditHoursButton
            // 
            this.EditHoursButton.Location = new System.Drawing.Point(272, 342);
            this.EditHoursButton.Name = "EditHoursButton";
            this.EditHoursButton.Size = new System.Drawing.Size(146, 29);
            this.EditHoursButton.TabIndex = 30;
            this.EditHoursButton.Text = "Edit employee\'s hours";
            this.EditHoursButton.UseVisualStyleBackColor = true;
            this.EditHoursButton.Click += new System.EventHandler(this.EditHours);
            // 
            // EmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditHoursButton);
            this.Controls.Add(this.WeeklyWorkHoursLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TotalnumberOfProjectsLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.Indicator);
            this.Controls.Add(this.PlannedProjectsLabel);
            this.Controls.Add(this.ActiveProjectsLabel);
            this.Controls.Add(this.FinishedProjectsLabel);
            this.Controls.Add(this.EditEmployeeButton);
            this.Controls.Add(this.PostitonLabel);
            this.Controls.Add(this.DateofBirthLabel);
            this.Controls.Add(this.OibLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "EmployeeDetailsForm";
            this.Text = "EmployeeDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditEmployeeButton;
        private System.Windows.Forms.Label PostitonLabel;
        private System.Windows.Forms.Label DateofBirthLabel;
        private System.Windows.Forms.Label OibLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label FinishedProjectsLabel;
        private System.Windows.Forms.Label ActiveProjectsLabel;
        private System.Windows.Forms.Label PlannedProjectsLabel;
        private System.Windows.Forms.Button Indicator;
        private Label TitleLabel;
        private Label TotalnumberOfProjectsLabel;
        private Button CloseButton;
        private Label WeeklyWorkHoursLabel;
        private Button EditHoursButton;
    }
}