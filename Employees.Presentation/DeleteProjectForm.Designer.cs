namespace Employees.Presentation
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
            this.DeleteProjectListBox = new System.Windows.Forms.ListBox();
            this.DeleteProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteProjectListBox
            // 
            this.DeleteProjectListBox.FormattingEnabled = true;
            this.DeleteProjectListBox.Location = new System.Drawing.Point(51, 63);
            this.DeleteProjectListBox.Name = "DeleteProjectListBox";
            this.DeleteProjectListBox.Size = new System.Drawing.Size(454, 290);
            this.DeleteProjectListBox.TabIndex = 0;
            // 
            // DeleteProjectButton
            // 
            this.DeleteProjectButton.Location = new System.Drawing.Point(611, 203);
            this.DeleteProjectButton.Name = "DeleteProjectButton";
            this.DeleteProjectButton.Size = new System.Drawing.Size(134, 23);
            this.DeleteProjectButton.TabIndex = 1;
            this.DeleteProjectButton.Text = "Delete project";
            this.DeleteProjectButton.UseVisualStyleBackColor = true;
            this.DeleteProjectButton.Click += new System.EventHandler(this.DeleteProject);
            // 
            // DeleteProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteProjectButton);
            this.Controls.Add(this.DeleteProjectListBox);
            this.Name = "DeleteProjectForm";
            this.Text = "DeleteProjectForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DeleteProjectListBox;
        private System.Windows.Forms.Button DeleteProjectButton;
    }
}