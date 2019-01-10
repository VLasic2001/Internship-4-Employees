namespace Employees.Presentation
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
            this.ListOfProjectsTitleLabel = new System.Windows.Forms.Label();
            this.DetalisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListOfProjectsListBox
            // 
            this.ListOfProjectsListBox.FormattingEnabled = true;
            this.ListOfProjectsListBox.Location = new System.Drawing.Point(21, 106);
            this.ListOfProjectsListBox.Name = "ListOfProjectsListBox";
            this.ListOfProjectsListBox.Size = new System.Drawing.Size(448, 290);
            this.ListOfProjectsListBox.TabIndex = 0;
            // 
            // EditProjectButton
            // 
            this.EditProjectButton.Location = new System.Drawing.Point(590, 228);
            this.EditProjectButton.Name = "EditProjectButton";
            this.EditProjectButton.Size = new System.Drawing.Size(121, 23);
            this.EditProjectButton.TabIndex = 1;
            this.EditProjectButton.Text = "Edit project";
            this.EditProjectButton.UseVisualStyleBackColor = true;
            this.EditProjectButton.Click += new System.EventHandler(this.EditProject);
            // 
            // ListOfProjectsTitleLabel
            // 
            this.ListOfProjectsTitleLabel.AutoSize = true;
            this.ListOfProjectsTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.ListOfProjectsTitleLabel.Location = new System.Drawing.Point(223, 19);
            this.ListOfProjectsTitleLabel.Name = "ListOfProjectsTitleLabel";
            this.ListOfProjectsTitleLabel.Size = new System.Drawing.Size(375, 63);
            this.ListOfProjectsTitleLabel.TabIndex = 2;
            this.ListOfProjectsTitleLabel.Text = "List of projects";
            // 
            // DetalisButton
            // 
            this.DetalisButton.Location = new System.Drawing.Point(590, 199);
            this.DetalisButton.Name = "DetalisButton";
            this.DetalisButton.Size = new System.Drawing.Size(121, 23);
            this.DetalisButton.TabIndex = 3;
            this.DetalisButton.Text = "Details";
            this.DetalisButton.UseVisualStyleBackColor = true;
            this.DetalisButton.Click += new System.EventHandler(this.Detalis);
            // 
            // ListOfProjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DetalisButton);
            this.Controls.Add(this.ListOfProjectsTitleLabel);
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
        private System.Windows.Forms.Label ListOfProjectsTitleLabel;
        private System.Windows.Forms.Button DetalisButton;
    }
}