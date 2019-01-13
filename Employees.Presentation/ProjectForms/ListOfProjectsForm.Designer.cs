namespace Employees.Presentation.ProjectForms
{
    partial class ListOfProjectsForm
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
            this.ListOfProjectsListBox = new System.Windows.Forms.ListBox();
            this.EditProjectButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DetalisButton = new System.Windows.Forms.Button();
            this.PlannedProjectsLabel = new System.Windows.Forms.Label();
            this.ActiveProjectsLabel = new System.Windows.Forms.Label();
            this.FinishedProjectsLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ListOfProjectsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListOfProjectsListBox
            // 
            this.ListOfProjectsListBox.FormattingEnabled = true;
            this.ListOfProjectsListBox.Location = new System.Drawing.Point(28, 136);
            this.ListOfProjectsListBox.Name = "ListOfProjectsListBox";
            this.ListOfProjectsListBox.Size = new System.Drawing.Size(487, 290);
            this.ListOfProjectsListBox.TabIndex = 0;
            // 
            // EditProjectButton
            // 
            this.EditProjectButton.Location = new System.Drawing.Point(591, 326);
            this.EditProjectButton.Name = "EditProjectButton";
            this.EditProjectButton.Size = new System.Drawing.Size(133, 23);
            this.EditProjectButton.TabIndex = 1;
            this.EditProjectButton.Text = "Edit project";
            this.EditProjectButton.UseVisualStyleBackColor = true;
            this.EditProjectButton.Click += new System.EventHandler(this.EditProject);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.TitleLabel.Location = new System.Drawing.Point(227, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(375, 63);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "List of projects";
            // 
            // DetalisButton
            // 
            this.DetalisButton.Location = new System.Drawing.Point(591, 280);
            this.DetalisButton.Name = "DetalisButton";
            this.DetalisButton.Size = new System.Drawing.Size(133, 23);
            this.DetalisButton.TabIndex = 3;
            this.DetalisButton.Text = "Details";
            this.DetalisButton.UseVisualStyleBackColor = true;
            this.DetalisButton.Click += new System.EventHandler(this.Detalis);
            // 
            // PlannedProjectsLabel
            // 
            this.PlannedProjectsLabel.AutoSize = true;
            this.PlannedProjectsLabel.Location = new System.Drawing.Point(588, 188);
            this.PlannedProjectsLabel.Name = "PlannedProjectsLabel";
            this.PlannedProjectsLabel.Size = new System.Drawing.Size(89, 13);
            this.PlannedProjectsLabel.TabIndex = 27;
            this.PlannedProjectsLabel.Text = "Planned projects:";
            // 
            // ActiveProjectsLabel
            // 
            this.ActiveProjectsLabel.AutoSize = true;
            this.ActiveProjectsLabel.Location = new System.Drawing.Point(588, 163);
            this.ActiveProjectsLabel.Name = "ActiveProjectsLabel";
            this.ActiveProjectsLabel.Size = new System.Drawing.Size(80, 13);
            this.ActiveProjectsLabel.TabIndex = 26;
            this.ActiveProjectsLabel.Text = "Active projects:";
            // 
            // FinishedProjectsLabel
            // 
            this.FinishedProjectsLabel.AutoSize = true;
            this.FinishedProjectsLabel.Location = new System.Drawing.Point(588, 136);
            this.FinishedProjectsLabel.Name = "FinishedProjectsLabel";
            this.FinishedProjectsLabel.Size = new System.Drawing.Size(89, 13);
            this.FinishedProjectsLabel.TabIndex = 25;
            this.FinishedProjectsLabel.Text = "Finished projects:";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(591, 375);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(133, 23);
            this.CloseButton.TabIndex = 28;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // ListOfProjectsLabel
            // 
            this.ListOfProjectsLabel.AutoSize = true;
            this.ListOfProjectsLabel.Location = new System.Drawing.Point(28, 117);
            this.ListOfProjectsLabel.Name = "ListOfProjectsLabel";
            this.ListOfProjectsLabel.Size = new System.Drawing.Size(266, 13);
            this.ListOfProjectsLabel.TabIndex = 29;
            this.ListOfProjectsLabel.Text = "Select the project you want to edit or see the details of:";
            // 
            // ListOfProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListOfProjectsLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PlannedProjectsLabel);
            this.Controls.Add(this.ActiveProjectsLabel);
            this.Controls.Add(this.FinishedProjectsLabel);
            this.Controls.Add(this.DetalisButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.EditProjectButton);
            this.Controls.Add(this.ListOfProjectsListBox);
            this.Name = "ListOfProjectsForm";
            this.Text = "ListOfProjectsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListOfProjectsListBox;
        private System.Windows.Forms.Button EditProjectButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button DetalisButton;
        private System.Windows.Forms.Label PlannedProjectsLabel;
        private System.Windows.Forms.Label ActiveProjectsLabel;
        private System.Windows.Forms.Label FinishedProjectsLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label ListOfProjectsLabel;
    }
}