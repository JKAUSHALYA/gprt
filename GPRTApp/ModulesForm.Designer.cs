namespace GPRTApp
{
    partial class ModulesForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.level5Btn = new System.Windows.Forms.Button();
            this.level6Btn = new System.Windows.Forms.Button();
            this.level4Btn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.level4GridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.level5GridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.level6GridView = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.summaryBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.level4GridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.level5GridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.level6GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.level5Btn);
            this.tabPage1.Controls.Add(this.level6Btn);
            this.tabPage1.Controls.Add(this.level4Btn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Module Levels";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a level to add module: ";
            // 
            // level5Btn
            // 
            this.level5Btn.Location = new System.Drawing.Point(186, 127);
            this.level5Btn.Name = "level5Btn";
            this.level5Btn.Size = new System.Drawing.Size(75, 23);
            this.level5Btn.TabIndex = 3;
            this.level5Btn.Text = "Level 5";
            this.level5Btn.UseVisualStyleBackColor = true;
            this.level5Btn.Click += new System.EventHandler(this.level5Btn_Click);
            // 
            // level6Btn
            // 
            this.level6Btn.Location = new System.Drawing.Point(186, 156);
            this.level6Btn.Name = "level6Btn";
            this.level6Btn.Size = new System.Drawing.Size(75, 23);
            this.level6Btn.TabIndex = 2;
            this.level6Btn.Text = "Level 6";
            this.level6Btn.UseVisualStyleBackColor = true;
            this.level6Btn.Click += new System.EventHandler(this.level6Btn_Click);
            // 
            // level4Btn
            // 
            this.level4Btn.Location = new System.Drawing.Point(186, 98);
            this.level4Btn.Name = "level4Btn";
            this.level4Btn.Size = new System.Drawing.Size(75, 23);
            this.level4Btn.TabIndex = 1;
            this.level4Btn.Text = "Level 4";
            this.level4Btn.UseVisualStyleBackColor = true;
            this.level4Btn.Click += new System.EventHandler(this.level4Btn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.level4GridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Level 4";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // level4GridView
            // 
            this.level4GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.level4GridView.Location = new System.Drawing.Point(6, 6);
            this.level4GridView.Name = "level4GridView";
            this.level4GridView.Size = new System.Drawing.Size(675, 388);
            this.level4GridView.TabIndex = 2;
            this.level4GridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.level4GridView_RowHeaderMouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.level5GridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(687, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Level 5";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // level5GridView
            // 
            this.level5GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.level5GridView.Location = new System.Drawing.Point(6, 6);
            this.level5GridView.Name = "level5GridView";
            this.level5GridView.Size = new System.Drawing.Size(675, 388);
            this.level5GridView.TabIndex = 2;
            this.level5GridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.level5GridView_RowHeaderMouseDoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.level6GridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(687, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Level 6";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // level6GridView
            // 
            this.level6GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.level6GridView.Location = new System.Drawing.Point(6, 6);
            this.level6GridView.Name = "level6GridView";
            this.level6GridView.Size = new System.Drawing.Size(675, 388);
            this.level6GridView.TabIndex = 1;
            this.level6GridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.level6GridView_RowHeaderMouseDoubleClick);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(713, 386);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(713, 415);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // summaryBtn
            // 
            this.summaryBtn.Location = new System.Drawing.Point(713, 357);
            this.summaryBtn.Name = "summaryBtn";
            this.summaryBtn.Size = new System.Drawing.Size(75, 23);
            this.summaryBtn.TabIndex = 2;
            this.summaryBtn.Text = "Summary";
            this.summaryBtn.UseVisualStyleBackColor = true;
            this.summaryBtn.Click += new System.EventHandler(this.summaryBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(713, 328);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 3;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(713, 299);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // ModulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.summaryBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.backBtn);
            this.Name = "ModulesForm";
            this.Text = "ModulesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModulesForm_FormClosing);
            this.Load += new System.EventHandler(this.ModulesForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.level4GridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.level5GridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.level6GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button summaryBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button level5Btn;
        private System.Windows.Forms.Button level6Btn;
        private System.Windows.Forms.Button level4Btn;
        internal System.Windows.Forms.DataGridView level4GridView;
        internal System.Windows.Forms.TabControl tabControl1;
        internal System.Windows.Forms.DataGridView level5GridView;
        internal System.Windows.Forms.DataGridView level6GridView;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}