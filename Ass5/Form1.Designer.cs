namespace Ass5
{
    partial class Form1
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
            this.studentDetailsBox = new System.Windows.Forms.RichTextBox();
            this.paperSearchBox = new System.Windows.Forms.RichTextBox();
            this.paperDetailsBox = new System.Windows.Forms.RichTextBox();
            this.searchBox = new System.Windows.Forms.RichTextBox();
            this.StudntInfoLab = new System.Windows.Forms.Label();
            this.searchIDLab = new System.Windows.Forms.Label();
            this.paperInfoLab = new System.Windows.Forms.Label();
            this.enterPaperCodeLab = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.displayStudentBut = new System.Windows.Forms.Button();
            this.searchStuBtn = new System.Windows.Forms.Button();
            this.SearchPaperBox = new System.Windows.Forms.TextBox();
            this.enterIdLab = new System.Windows.Forms.Label();
            this.displayPaperBut = new System.Windows.Forms.Button();
            this.searchPaperBtn = new System.Windows.Forms.Button();
            this.searchIdBox = new System.Windows.Forms.TextBox();
            this.paperCodeLab = new System.Windows.Forms.Label();
            this.addStudentBut = new System.Windows.Forms.Button();
            this.addPaperBut = new System.Windows.Forms.Button();
            this.enrollButt = new System.Windows.Forms.Button();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentDetailsBox
            // 
            this.studentDetailsBox.Location = new System.Drawing.Point(22, 99);
            this.studentDetailsBox.Margin = new System.Windows.Forms.Padding(2);
            this.studentDetailsBox.Name = "studentDetailsBox";
            this.studentDetailsBox.Size = new System.Drawing.Size(141, 192);
            this.studentDetailsBox.TabIndex = 11;
            this.studentDetailsBox.Text = "";
            // 
            // paperSearchBox
            // 
            this.paperSearchBox.Location = new System.Drawing.Point(199, 98);
            this.paperSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.paperSearchBox.Name = "paperSearchBox";
            this.paperSearchBox.Size = new System.Drawing.Size(143, 192);
            this.paperSearchBox.TabIndex = 20;
            this.paperSearchBox.Text = "";
            // 
            // paperDetailsBox
            // 
            this.paperDetailsBox.Location = new System.Drawing.Point(374, 99);
            this.paperDetailsBox.Margin = new System.Windows.Forms.Padding(2);
            this.paperDetailsBox.Name = "paperDetailsBox";
            this.paperDetailsBox.Size = new System.Drawing.Size(141, 194);
            this.paperDetailsBox.TabIndex = 21;
            this.paperDetailsBox.Text = "";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(546, 98);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(148, 192);
            this.searchBox.TabIndex = 22;
            this.searchBox.Text = "";
            // 
            // StudntInfoLab
            // 
            this.StudntInfoLab.AutoSize = true;
            this.StudntInfoLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudntInfoLab.Location = new System.Drawing.Point(24, 72);
            this.StudntInfoLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudntInfoLab.Name = "StudntInfoLab";
            this.StudntInfoLab.Size = new System.Drawing.Size(94, 13);
            this.StudntInfoLab.TabIndex = 23;
            this.StudntInfoLab.Text = "Student Details";
            // 
            // searchIDLab
            // 
            this.searchIDLab.AutoSize = true;
            this.searchIDLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIDLab.Location = new System.Drawing.Point(190, 72);
            this.searchIDLab.Name = "searchIDLab";
            this.searchIDLab.Size = new System.Drawing.Size(170, 13);
            this.searchIDLab.TabIndex = 25;
            this.searchIDLab.Text = "Search For Student Using ID";
            // 
            // paperInfoLab
            // 
            this.paperInfoLab.AutoSize = true;
            this.paperInfoLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paperInfoLab.Location = new System.Drawing.Point(377, 72);
            this.paperInfoLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paperInfoLab.Name = "paperInfoLab";
            this.paperInfoLab.Size = new System.Drawing.Size(83, 13);
            this.paperInfoLab.TabIndex = 26;
            this.paperInfoLab.Text = "Paper Details";
            // 
            // enterPaperCodeLab
            // 
            this.enterPaperCodeLab.AutoSize = true;
            this.enterPaperCodeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterPaperCodeLab.Location = new System.Drawing.Point(509, 72);
            this.enterPaperCodeLab.Name = "enterPaperCodeLab";
            this.enterPaperCodeLab.Size = new System.Drawing.Size(217, 13);
            this.enterPaperCodeLab.TabIndex = 27;
            this.enterPaperCodeLab.Text = "Search for Student using Paper code";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(232, 24);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(283, 24);
            this.title.TabIndex = 29;
            this.title.Text = "Massey University Enrollment";
            // 
            // displayStudentBut
            // 
            this.displayStudentBut.Location = new System.Drawing.Point(46, 307);
            this.displayStudentBut.Margin = new System.Windows.Forms.Padding(2);
            this.displayStudentBut.Name = "displayStudentBut";
            this.displayStudentBut.Size = new System.Drawing.Size(96, 31);
            this.displayStudentBut.TabIndex = 29;
            this.displayStudentBut.Text = "Display Student ";
            this.displayStudentBut.UseVisualStyleBackColor = true;
            this.displayStudentBut.Click += new System.EventHandler(this.displayStudentBut_Click);
            // 
            // searchStuBtn
            // 
            this.searchStuBtn.Location = new System.Drawing.Point(205, 331);
            this.searchStuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchStuBtn.Name = "searchStuBtn";
            this.searchStuBtn.Size = new System.Drawing.Size(94, 34);
            this.searchStuBtn.TabIndex = 30;
            this.searchStuBtn.Text = "Search Enrolled Student";
            this.searchStuBtn.UseVisualStyleBackColor = true;
            this.searchStuBtn.Click += new System.EventHandler(this.searchStuBtn_Click);
            // 
            // SearchPaperBox
            // 
            this.SearchPaperBox.Location = new System.Drawing.Point(205, 307);
            this.SearchPaperBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchPaperBox.Name = "SearchPaperBox";
            this.SearchPaperBox.Size = new System.Drawing.Size(119, 20);
            this.SearchPaperBox.TabIndex = 31;
            // 
            // enterIdLab
            // 
            this.enterIdLab.AutoSize = true;
            this.enterIdLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterIdLab.Location = new System.Drawing.Point(211, 292);
            this.enterIdLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterIdLab.Name = "enterIdLab";
            this.enterIdLab.Size = new System.Drawing.Size(102, 13);
            this.enterIdLab.TabIndex = 32;
            this.enterIdLab.Text = "Enter Student ID";
            // 
            // displayPaperBut
            // 
            this.displayPaperBut.Location = new System.Drawing.Point(398, 309);
            this.displayPaperBut.Margin = new System.Windows.Forms.Padding(2);
            this.displayPaperBut.Name = "displayPaperBut";
            this.displayPaperBut.Size = new System.Drawing.Size(96, 29);
            this.displayPaperBut.TabIndex = 33;
            this.displayPaperBut.Text = "Display Papers";
            this.displayPaperBut.UseVisualStyleBackColor = true;
            this.displayPaperBut.Click += new System.EventHandler(this.displayPaperBut_Click);
            // 
            // searchPaperBtn
            // 
            this.searchPaperBtn.Location = new System.Drawing.Point(574, 331);
            this.searchPaperBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchPaperBtn.Name = "searchPaperBtn";
            this.searchPaperBtn.Size = new System.Drawing.Size(94, 49);
            this.searchPaperBtn.TabIndex = 34;
            this.searchPaperBtn.Text = "Search Paper that student is Enrolled";
            this.searchPaperBtn.UseVisualStyleBackColor = true;
            this.searchPaperBtn.Click += new System.EventHandler(this.searchPaperBtn_Click);
            // 
            // searchIdBox
            // 
            this.searchIdBox.Location = new System.Drawing.Point(564, 307);
            this.searchIdBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchIdBox.Name = "searchIdBox";
            this.searchIdBox.Size = new System.Drawing.Size(119, 20);
            this.searchIdBox.TabIndex = 35;
            // 
            // paperCodeLab
            // 
            this.paperCodeLab.AutoSize = true;
            this.paperCodeLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paperCodeLab.Location = new System.Drawing.Point(561, 292);
            this.paperCodeLab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paperCodeLab.Name = "paperCodeLab";
            this.paperCodeLab.Size = new System.Drawing.Size(107, 13);
            this.paperCodeLab.TabIndex = 36;
            this.paperCodeLab.Text = "Enter Paper Code";
            // 
            // addStudentBut
            // 
            this.addStudentBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentBut.Location = new System.Drawing.Point(199, 397);
            this.addStudentBut.Margin = new System.Windows.Forms.Padding(2);
            this.addStudentBut.Name = "addStudentBut";
            this.addStudentBut.Size = new System.Drawing.Size(89, 29);
            this.addStudentBut.TabIndex = 37;
            this.addStudentBut.Text = "Add Student";
            this.addStudentBut.UseVisualStyleBackColor = true;
            this.addStudentBut.Click += new System.EventHandler(this.addStudentBut_Click);
            // 
            // addPaperBut
            // 
            this.addPaperBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPaperBut.Location = new System.Drawing.Point(493, 397);
            this.addPaperBut.Margin = new System.Windows.Forms.Padding(2);
            this.addPaperBut.Name = "addPaperBut";
            this.addPaperBut.Size = new System.Drawing.Size(89, 29);
            this.addPaperBut.TabIndex = 38;
            this.addPaperBut.Text = "Enroll";
            this.addPaperBut.UseVisualStyleBackColor = true;
            this.addPaperBut.Click += new System.EventHandler(this.addPaperBut_Click);
            // 
            // enrollButt
            // 
            this.enrollButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollButt.Location = new System.Drawing.Point(344, 397);
            this.enrollButt.Margin = new System.Windows.Forms.Padding(2);
            this.enrollButt.Name = "enrollButt";
            this.enrollButt.Size = new System.Drawing.Size(90, 29);
            this.enrollButt.TabIndex = 39;
            this.enrollButt.Text = "Add Paper";
            this.enrollButt.UseVisualStyleBackColor = true;
            this.enrollButt.Click += new System.EventHandler(this.enrollButt_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click_1);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 464);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.enrollButt);
            this.Controls.Add(this.addPaperBut);
            this.Controls.Add(this.addStudentBut);
            this.Controls.Add(this.paperCodeLab);
            this.Controls.Add(this.searchIdBox);
            this.Controls.Add(this.searchPaperBtn);
            this.Controls.Add(this.displayPaperBut);
            this.Controls.Add(this.enterIdLab);
            this.Controls.Add(this.SearchPaperBox);
            this.Controls.Add(this.searchStuBtn);
            this.Controls.Add(this.displayStudentBut);
            this.Controls.Add(this.title);
            this.Controls.Add(this.enterPaperCodeLab);
            this.Controls.Add(this.paperInfoLab);
            this.Controls.Add(this.searchIDLab);
            this.Controls.Add(this.StudntInfoLab);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.paperDetailsBox);
            this.Controls.Add(this.paperSearchBox);
            this.Controls.Add(this.studentDetailsBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
//            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox studentDetailsBox;
        private System.Windows.Forms.RichTextBox paperSearchBox;
        private System.Windows.Forms.RichTextBox paperDetailsBox;
        private System.Windows.Forms.RichTextBox searchBox;
        private System.Windows.Forms.Label StudntInfoLab;
        private System.Windows.Forms.Label searchIDLab;
        private System.Windows.Forms.Label paperInfoLab;
        private System.Windows.Forms.Label enterPaperCodeLab;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button displayStudentBut;
        private System.Windows.Forms.Button searchStuBtn;
        private System.Windows.Forms.TextBox SearchPaperBox;
        private System.Windows.Forms.Label enterIdLab;
        private System.Windows.Forms.Button displayPaperBut;
        private System.Windows.Forms.Button searchPaperBtn;
        private System.Windows.Forms.TextBox searchIdBox;
        private System.Windows.Forms.Label paperCodeLab;
        private System.Windows.Forms.Button addStudentBut;
        private System.Windows.Forms.Button addPaperBut;
        private System.Windows.Forms.Button enrollButt;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

