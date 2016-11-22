namespace Ass5
{
    partial class Paper_Details
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
            this._StudentIDF3Lable = new System.Windows.Forms.Label();
            this._PaperCodesLabel = new System.Windows.Forms.Label();
            this.IdBox = new System.Windows.Forms.MaskedTextBox();
            this.paperCodeBox = new System.Windows.Forms.MaskedTextBox();
            this.EnrollBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _StudentIDF3Lable
            // 
            this._StudentIDF3Lable.AutoSize = true;
            this._StudentIDF3Lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._StudentIDF3Lable.Location = new System.Drawing.Point(142, 110);
            this._StudentIDF3Lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._StudentIDF3Lable.Name = "_StudentIDF3Lable";
            this._StudentIDF3Lable.Size = new System.Drawing.Size(48, 36);
            this._StudentIDF3Lable.TabIndex = 3;
            this._StudentIDF3Lable.Text = "Id:";
            // 
            // _PaperCodesLabel
            // 
            this._PaperCodesLabel.AutoSize = true;
            this._PaperCodesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._PaperCodesLabel.Location = new System.Drawing.Point(142, 212);
            this._PaperCodesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._PaperCodesLabel.Name = "_PaperCodesLabel";
            this._PaperCodesLabel.Size = new System.Drawing.Size(181, 36);
            this._PaperCodesLabel.TabIndex = 4;
            this._PaperCodesLabel.Text = "Paper Code:";
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(352, 112);
            this.IdBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdBox.Mask = "00000000";
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(258, 31);
            this.IdBox.TabIndex = 10;
            // 
            // paperCodeBox
            // 
            this.paperCodeBox.Location = new System.Drawing.Point(352, 215);
            this.paperCodeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paperCodeBox.Mask = "000000";
            this.paperCodeBox.Name = "paperCodeBox";
            this.paperCodeBox.Size = new System.Drawing.Size(258, 31);
            this.paperCodeBox.TabIndex = 11;
            // 
            // EnrollBut
            // 
            this.EnrollBut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EnrollBut.Location = new System.Drawing.Point(242, 294);
            this.EnrollBut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnrollBut.Name = "EnrollBut";
            this.EnrollBut.Size = new System.Drawing.Size(188, 87);
            this.EnrollBut.TabIndex = 12;
            this.EnrollBut.Text = "Add To Roll";
            this.EnrollBut.UseVisualStyleBackColor = true;
            this.EnrollBut.Click += new System.EventHandler(this.EnrollBut_Click);
            // 
            // Paper_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.EnrollBut;
            this.ClientSize = new System.Drawing.Size(686, 458);
            this.Controls.Add(this.EnrollBut);
            this.Controls.Add(this.paperCodeBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this._PaperCodesLabel);
            this.Controls.Add(this._StudentIDF3Lable);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Paper_Details";
            this.Text = "Paper_Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _StudentIDF3Lable;
        private System.Windows.Forms.Label _PaperCodesLabel;
        private System.Windows.Forms.MaskedTextBox IdBox;
        private System.Windows.Forms.MaskedTextBox paperCodeBox;
        private System.Windows.Forms.Button EnrollBut;
    }
}