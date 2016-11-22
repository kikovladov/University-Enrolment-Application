namespace Ass5
{
    partial class AddingPapers
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
            this._PaperCodeLabel = new System.Windows.Forms.Label();
            this._PaperNameLabel = new System.Windows.Forms.Label();
            this._CourseCoordinatorLabel = new System.Windows.Forms.Label();
            this.CodePaperBox = new System.Windows.Forms.MaskedTextBox();
            this.NameOfPaperBox = new System.Windows.Forms.TextBox();
            this.CourseBox = new System.Windows.Forms.TextBox();
            this.AddPaper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _PaperCodeLabel
            // 
            this._PaperCodeLabel.AutoSize = true;
            this._PaperCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._PaperCodeLabel.Location = new System.Drawing.Point(112, 88);
            this._PaperCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._PaperCodeLabel.Name = "_PaperCodeLabel";
            this._PaperCodeLabel.Size = new System.Drawing.Size(181, 36);
            this._PaperCodeLabel.TabIndex = 1;
            this._PaperCodeLabel.Text = "Paper Code:";
            // 
            // _PaperNameLabel
            // 
            this._PaperNameLabel.AutoSize = true;
            this._PaperNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._PaperNameLabel.Location = new System.Drawing.Point(112, 208);
            this._PaperNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._PaperNameLabel.Name = "_PaperNameLabel";
            this._PaperNameLabel.Size = new System.Drawing.Size(225, 36);
            this._PaperNameLabel.TabIndex = 2;
            this._PaperNameLabel.Text = "Name Of Paper:";
            // 
            // _CourseCoordinatorLabel
            // 
            this._CourseCoordinatorLabel.AutoSize = true;
            this._CourseCoordinatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CourseCoordinatorLabel.Location = new System.Drawing.Point(112, 329);
            this._CourseCoordinatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._CourseCoordinatorLabel.Name = "_CourseCoordinatorLabel";
            this._CourseCoordinatorLabel.Size = new System.Drawing.Size(284, 36);
            this._CourseCoordinatorLabel.TabIndex = 3;
            this._CourseCoordinatorLabel.Text = "Course Coordinator:";
            // 
            // CodePaperBox
            // 
            this.CodePaperBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodePaperBox.Location = new System.Drawing.Point(388, 88);
            this.CodePaperBox.Margin = new System.Windows.Forms.Padding(4);
            this.CodePaperBox.Mask = "000000";
            this.CodePaperBox.Name = "CodePaperBox";
            this.CodePaperBox.Size = new System.Drawing.Size(286, 38);
            this.CodePaperBox.TabIndex = 4;
            // 
            // NameOfPaperBox
            // 
            this.NameOfPaperBox.Location = new System.Drawing.Point(388, 210);
            this.NameOfPaperBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameOfPaperBox.Name = "NameOfPaperBox";
            this.NameOfPaperBox.Size = new System.Drawing.Size(286, 31);
            this.NameOfPaperBox.TabIndex = 5;
            // 
            // CourseBox
            // 
            this.CourseBox.Location = new System.Drawing.Point(388, 331);
            this.CourseBox.Margin = new System.Windows.Forms.Padding(4);
            this.CourseBox.Name = "CourseBox";
            this.CourseBox.Size = new System.Drawing.Size(286, 31);
            this.CourseBox.TabIndex = 6;
            // 
            // AddPaper
            // 
            this.AddPaper.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddPaper.Location = new System.Drawing.Point(388, 431);
            this.AddPaper.Margin = new System.Windows.Forms.Padding(4);
            this.AddPaper.Name = "AddPaper";
            this.AddPaper.Size = new System.Drawing.Size(242, 92);
            this.AddPaper.TabIndex = 7;
            this.AddPaper.Text = "Add";
            this.AddPaper.UseVisualStyleBackColor = true;
            this.AddPaper.Click += new System.EventHandler(this.AddPaper_Click);
            // 
            // AddingPapers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.AddPaper;
            this.ClientSize = new System.Drawing.Size(1014, 677);
            this.Controls.Add(this.AddPaper);
            this.Controls.Add(this.CourseBox);
            this.Controls.Add(this.NameOfPaperBox);
            this.Controls.Add(this.CodePaperBox);
            this.Controls.Add(this._CourseCoordinatorLabel);
            this.Controls.Add(this._PaperNameLabel);
            this.Controls.Add(this._PaperCodeLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddingPapers";
            this.Text = "Paper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _PaperCodeLabel;
        private System.Windows.Forms.Label _PaperNameLabel;
        private System.Windows.Forms.Label _CourseCoordinatorLabel;
        private System.Windows.Forms.MaskedTextBox CodePaperBox;
        private System.Windows.Forms.TextBox NameOfPaperBox;
        private System.Windows.Forms.TextBox CourseBox;
        private System.Windows.Forms.Button AddPaper;
    }
}