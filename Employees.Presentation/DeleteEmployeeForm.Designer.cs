namespace Employees.Presentation
{
    partial class DeleteEmployeeForm
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
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.deleteEmployeeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Location = new System.Drawing.Point(594, 186);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(136, 23);
            this.deleteEmployeeButton.TabIndex = 1;
            this.deleteEmployeeButton.Text = "Delete Employee";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployee);
            // 
            // deleteEmployeeCheckedListBox
            // 
            this.deleteEmployeeCheckedListBox.CheckOnClick = true;
            this.deleteEmployeeCheckedListBox.FormattingEnabled = true;
            this.deleteEmployeeCheckedListBox.Location = new System.Drawing.Point(47, 76);
            this.deleteEmployeeCheckedListBox.Name = "deleteEmployeeCheckedListBox";
            this.deleteEmployeeCheckedListBox.Size = new System.Drawing.Size(453, 229);
            this.deleteEmployeeCheckedListBox.TabIndex = 3;
            // 
            // DeleteEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteEmployeeCheckedListBox);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Name = "DeleteEmployeeForm";
            this.Text = "DeleteEmployeeForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button deleteEmployeeButton;
        private System.Windows.Forms.CheckedListBox deleteEmployeeCheckedListBox;
    }
}