namespace Employees.Presentation
{
    partial class EmployeeHoursOnProjectForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.HoursOnProjectTextBox = new System.Windows.Forms.TextBox();
            this.HoursOnProjectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(393, 194);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Save);
            // 
            // HoursOnProjectTextBox
            // 
            this.HoursOnProjectTextBox.Location = new System.Drawing.Point(380, 74);
            this.HoursOnProjectTextBox.Name = "HoursOnProjectTextBox";
            this.HoursOnProjectTextBox.Size = new System.Drawing.Size(113, 20);
            this.HoursOnProjectTextBox.TabIndex = 1;
            // 
            // HoursOnProjectLabel
            // 
            this.HoursOnProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.HoursOnProjectLabel.Location = new System.Drawing.Point(25, 30);
            this.HoursOnProjectLabel.Name = "HoursOnProjectLabel";
            this.HoursOnProjectLabel.Size = new System.Drawing.Size(313, 237);
            this.HoursOnProjectLabel.TabIndex = 2;
            this.HoursOnProjectLabel.Text = "Enter amount of hours {} works on {} per week";
            // 
            // EmployeeHoursOnProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 303);
            this.Controls.Add(this.HoursOnProjectLabel);
            this.Controls.Add(this.HoursOnProjectTextBox);
            this.Controls.Add(this.SaveButton);
            this.Name = "EmployeeHoursOnProjectForm";
            this.Text = "EmployeeHoursOnProjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox HoursOnProjectTextBox;
        private System.Windows.Forms.Label HoursOnProjectLabel;
    }
}