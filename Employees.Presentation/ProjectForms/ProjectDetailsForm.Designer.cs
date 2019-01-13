namespace Employees.Presentation.ProjectForms
{
    partial class ProjectDetailsForm
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
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.ProjectDatesLabel = new System.Windows.Forms.Label();
            this.ProjectDesignersLabel = new System.Windows.Forms.Label();
            this.ProjectProgrammersLabel = new System.Windows.Forms.Label();
            this.ProjectAccountantsLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.EditProjectButton = new System.Windows.Forms.Button();
            this.EditHoursButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.ProjectNameLabel.Location = new System.Drawing.Point(53, 22);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(257, 46);
            this.ProjectNameLabel.TabIndex = 0;
            this.ProjectNameLabel.Text = "Project name";
            // 
            // ProjectDatesLabel
            // 
            this.ProjectDatesLabel.AutoSize = true;
            this.ProjectDatesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProjectDatesLabel.Location = new System.Drawing.Point(67, 94);
            this.ProjectDatesLabel.Name = "ProjectDatesLabel";
            this.ProjectDatesLabel.Size = new System.Drawing.Size(102, 20);
            this.ProjectDatesLabel.TabIndex = 1;
            this.ProjectDatesLabel.Text = "Project dates";
            // 
            // ProjectDesignersLabel
            // 
            this.ProjectDesignersLabel.AutoSize = true;
            this.ProjectDesignersLabel.Location = new System.Drawing.Point(67, 129);
            this.ProjectDesignersLabel.Name = "ProjectDesignersLabel";
            this.ProjectDesignersLabel.Size = new System.Drawing.Size(63, 13);
            this.ProjectDesignersLabel.TabIndex = 2;
            this.ProjectDesignersLabel.Text = "Designers ()";
            // 
            // ProjectProgrammersLabel
            // 
            this.ProjectProgrammersLabel.AutoSize = true;
            this.ProjectProgrammersLabel.Location = new System.Drawing.Point(310, 129);
            this.ProjectProgrammersLabel.Name = "ProjectProgrammersLabel";
            this.ProjectProgrammersLabel.Size = new System.Drawing.Size(77, 13);
            this.ProjectProgrammersLabel.TabIndex = 3;
            this.ProjectProgrammersLabel.Text = "Programmers ()";
            // 
            // ProjectAccountantsLabel
            // 
            this.ProjectAccountantsLabel.AutoSize = true;
            this.ProjectAccountantsLabel.Location = new System.Drawing.Point(587, 129);
            this.ProjectAccountantsLabel.Name = "ProjectAccountantsLabel";
            this.ProjectAccountantsLabel.Size = new System.Drawing.Size(76, 13);
            this.ProjectAccountantsLabel.TabIndex = 4;
            this.ProjectAccountantsLabel.Text = "Accountants ()";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(634, 415);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(142, 23);
            this.CloseButton.TabIndex = 29;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // EditProjectButton
            // 
            this.EditProjectButton.Location = new System.Drawing.Point(328, 415);
            this.EditProjectButton.Name = "EditProjectButton";
            this.EditProjectButton.Size = new System.Drawing.Size(146, 23);
            this.EditProjectButton.TabIndex = 30;
            this.EditProjectButton.Text = "Edit project";
            this.EditProjectButton.UseVisualStyleBackColor = true;
            this.EditProjectButton.Click += new System.EventHandler(this.EditProject);
            // 
            // EditHoursButton
            // 
            this.EditHoursButton.Location = new System.Drawing.Point(480, 415);
            this.EditHoursButton.Name = "EditHoursButton";
            this.EditHoursButton.Size = new System.Drawing.Size(148, 23);
            this.EditHoursButton.TabIndex = 31;
            this.EditHoursButton.Text = "Edit employee\'s hours";
            this.EditHoursButton.UseVisualStyleBackColor = true;
            this.EditHoursButton.Click += new System.EventHandler(this.EditHours);
            // 
            // ProjectDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditHoursButton);
            this.Controls.Add(this.EditProjectButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ProjectAccountantsLabel);
            this.Controls.Add(this.ProjectProgrammersLabel);
            this.Controls.Add(this.ProjectDesignersLabel);
            this.Controls.Add(this.ProjectDatesLabel);
            this.Controls.Add(this.ProjectNameLabel);
            this.Name = "ProjectDetailsForm";
            this.Text = "ProjectDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.Label ProjectDatesLabel;
        private System.Windows.Forms.Label ProjectDesignersLabel;
        private System.Windows.Forms.Label ProjectProgrammersLabel;
        private System.Windows.Forms.Label ProjectAccountantsLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button EditProjectButton;
        private System.Windows.Forms.Button EditHoursButton;
    }
}