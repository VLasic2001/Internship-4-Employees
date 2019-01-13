namespace Employees.Presentation.ProjectForms
{
    partial class DeleteProjectForm
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
            this.ProjectListBox = new System.Windows.Forms.ListBox();
            this.DeleteProjectButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ProjectListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProjectListBox
            // 
            this.ProjectListBox.FormattingEnabled = true;
            this.ProjectListBox.Location = new System.Drawing.Point(37, 116);
            this.ProjectListBox.Name = "ProjectListBox";
            this.ProjectListBox.Size = new System.Drawing.Size(530, 290);
            this.ProjectListBox.TabIndex = 0;
            // 
            // DeleteProjectButton
            // 
            this.DeleteProjectButton.Location = new System.Drawing.Point(611, 228);
            this.DeleteProjectButton.Name = "DeleteProjectButton";
            this.DeleteProjectButton.Size = new System.Drawing.Size(134, 23);
            this.DeleteProjectButton.TabIndex = 1;
            this.DeleteProjectButton.Text = "Delete project";
            this.DeleteProjectButton.UseVisualStyleBackColor = true;
            this.DeleteProjectButton.Click += new System.EventHandler(this.DeleteProject);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(611, 257);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(134, 23);
            this.CloseButton.TabIndex = 15;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.Close);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.TitleLabel.Location = new System.Drawing.Point(234, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(361, 63);
            this.TitleLabel.TabIndex = 16;
            this.TitleLabel.Text = "Delete project";
            // 
            // ProjectListLabel
            // 
            this.ProjectListLabel.AutoSize = true;
            this.ProjectListLabel.Location = new System.Drawing.Point(37, 97);
            this.ProjectListLabel.Name = "ProjectListLabel";
            this.ProjectListLabel.Size = new System.Drawing.Size(165, 13);
            this.ProjectListLabel.TabIndex = 17;
            this.ProjectListLabel.Text = "Select project you want to delete:";
            // 
            // DeleteProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProjectListLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DeleteProjectButton);
            this.Controls.Add(this.ProjectListBox);
            this.Name = "DeleteProjectForm";
            this.Text = "DeleteProjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProjectListBox;
        private System.Windows.Forms.Button DeleteProjectButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ProjectListLabel;
    }
}