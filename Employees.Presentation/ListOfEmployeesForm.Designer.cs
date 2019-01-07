namespace Employees.Presentation
{
    partial class ListOfEmployeesForm
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
            this.ListOfEmployeesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.editEmployeeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListOfEmployeesCheckedListBox
            // 
            this.ListOfEmployeesCheckedListBox.CheckOnClick = true;
            this.ListOfEmployeesCheckedListBox.FormattingEnabled = true;
            this.ListOfEmployeesCheckedListBox.Location = new System.Drawing.Point(22, 99);
            this.ListOfEmployeesCheckedListBox.Name = "ListOfEmployeesCheckedListBox";
            this.ListOfEmployeesCheckedListBox.Size = new System.Drawing.Size(488, 214);
            this.ListOfEmployeesCheckedListBox.TabIndex = 0;
            // 
            // editEmployeeButton
            // 
            this.editEmployeeButton.Location = new System.Drawing.Point(606, 246);
            this.editEmployeeButton.Name = "editEmployeeButton";
            this.editEmployeeButton.Size = new System.Drawing.Size(133, 23);
            this.editEmployeeButton.TabIndex = 1;
            this.editEmployeeButton.Text = "Edit Employee";
            this.editEmployeeButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.titleLabel.Location = new System.Drawing.Point(185, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(447, 63);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "List of employees";
            // 
            // ListOfEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.editEmployeeButton);
            this.Controls.Add(this.ListOfEmployeesCheckedListBox);
            this.Name = "ListOfEmployeesForm";
            this.Text = "ListOfEmployeesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ListOfEmployeesCheckedListBox;
        private System.Windows.Forms.Button editEmployeeButton;
        private System.Windows.Forms.Label titleLabel;
    }
}