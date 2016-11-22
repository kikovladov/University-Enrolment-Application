namespace Ass5
{
    partial class Student
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
            this._StudentNameLabel = new System.Windows.Forms.Label();
            this._StudentIdLabel = new System.Windows.Forms.Label();
            this._StudentDOBLabel = new System.Windows.Forms.Label();
            this._StudentAddressLabel = new System.Windows.Forms.Label();
            this._StudentNameTextBox = new System.Windows.Forms.TextBox();
            this._StudentIDMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this._StudentAddressTextBox = new System.Windows.Forms.TextBox();
            this._AddStudentDetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _StudentNameLabel
            // 
            this._StudentNameLabel.AutoSize = true;
            this._StudentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._StudentNameLabel.Location = new System.Drawing.Point(86, 112);
            this._StudentNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._StudentNameLabel.Name = "_StudentNameLabel";
            this._StudentNameLabel.Size = new System.Drawing.Size(208, 31);
            this._StudentNameLabel.TabIndex = 21;
            this._StudentNameLabel.Text = "Student Name:";
            // 
            // _StudentIdLabel
            // 
            this._StudentIdLabel.AutoSize = true;
            this._StudentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._StudentIdLabel.Location = new System.Drawing.Point(86, 210);
            this._StudentIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._StudentIdLabel.Name = "_StudentIdLabel";
            this._StudentIdLabel.Size = new System.Drawing.Size(162, 31);
            this._StudentIdLabel.TabIndex = 22;
            this._StudentIdLabel.Text = "Student ID:";
            // 
            // _StudentDOBLabel
            // 
            this._StudentDOBLabel.AutoSize = true;
            this._StudentDOBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._StudentDOBLabel.Location = new System.Drawing.Point(86, 302);
            this._StudentDOBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._StudentDOBLabel.Name = "_StudentDOBLabel";
            this._StudentDOBLabel.Size = new System.Drawing.Size(212, 31);
            this._StudentDOBLabel.TabIndex = 23;
            this._StudentDOBLabel.Text = "Student D.O.B:";
            // 
            // _StudentAddressLabel
            // 
            this._StudentAddressLabel.AutoSize = true;
            this._StudentAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._StudentAddressLabel.Location = new System.Drawing.Point(86, 396);
            this._StudentAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._StudentAddressLabel.Name = "_StudentAddressLabel";
            this._StudentAddressLabel.Size = new System.Drawing.Size(239, 31);
            this._StudentAddressLabel.TabIndex = 24;
            this._StudentAddressLabel.Text = "Student Address:";
            // 
            // _StudentNameTextBox
            // 
            this._StudentNameTextBox.Location = new System.Drawing.Point(394, 113);
            this._StudentNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._StudentNameTextBox.Name = "_StudentNameTextBox";
            this._StudentNameTextBox.Size = new System.Drawing.Size(358, 31);
            this._StudentNameTextBox.TabIndex = 25;
            // 
            // _StudentIDMaskedTextBox
            // 
            this._StudentIDMaskedTextBox.Location = new System.Drawing.Point(394, 210);
            this._StudentIDMaskedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._StudentIDMaskedTextBox.Mask = "00000000";
            this._StudentIDMaskedTextBox.Name = "_StudentIDMaskedTextBox";
            this._StudentIDMaskedTextBox.Size = new System.Drawing.Size(358, 31);
            this._StudentIDMaskedTextBox.TabIndex = 26;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(394, 302);
            this.birthdayDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(358, 31);
            this.birthdayDateTimePicker.TabIndex = 27;
            // 
            // _StudentAddressTextBox
            // 
            this._StudentAddressTextBox.Location = new System.Drawing.Point(394, 394);
            this._StudentAddressTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._StudentAddressTextBox.Name = "_StudentAddressTextBox";
            this._StudentAddressTextBox.Size = new System.Drawing.Size(358, 31);
            this._StudentAddressTextBox.TabIndex = 28;
            // 
            // _AddStudentDetailsButton
            // 
            this._AddStudentDetailsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._AddStudentDetailsButton.Location = new System.Drawing.Point(286, 494);
            this._AddStudentDetailsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._AddStudentDetailsButton.Name = "_AddStudentDetailsButton";
            this._AddStudentDetailsButton.Size = new System.Drawing.Size(262, 69);
            this._AddStudentDetailsButton.TabIndex = 29;
            this._AddStudentDetailsButton.Text = "Add To Enroll";
            this._AddStudentDetailsButton.UseVisualStyleBackColor = true;
            this._AddStudentDetailsButton.Click += new System.EventHandler(this._AddStudentDetailsButton_Click_1);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._AddStudentDetailsButton;
            this.ClientSize = new System.Drawing.Size(938, 660);
            this.Controls.Add(this._AddStudentDetailsButton);
            this.Controls.Add(this._StudentAddressTextBox);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(this._StudentIDMaskedTextBox);
            this.Controls.Add(this._StudentNameTextBox);
            this.Controls.Add(this._StudentAddressLabel);
            this.Controls.Add(this._StudentDOBLabel);
            this.Controls.Add(this._StudentIdLabel);
            this.Controls.Add(this._StudentNameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Student";
            this.Text = "Stidents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _StudentNameLabel;
        private System.Windows.Forms.Label _StudentIdLabel;
        private System.Windows.Forms.Label _StudentDOBLabel;
        private System.Windows.Forms.Label _StudentAddressLabel;
        private System.Windows.Forms.TextBox _StudentNameTextBox;
        private System.Windows.Forms.MaskedTextBox _StudentIDMaskedTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox _StudentAddressTextBox;
        private System.Windows.Forms.Button _AddStudentDetailsButton;
    }
}