﻿namespace GPRTApp
{
    partial class AssesmentForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.assesmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.assesmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.predictedMarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualMarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wheightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assesmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assesmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.predictedMarkDataGridViewTextBoxColumn,
            this.actualMarkDataGridViewTextBoxColumn,
            this.wheightDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assesmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // assesmentBindingSource1
            // 
            this.assesmentBindingSource1.DataSource = typeof(GPRTCommon.Assesment);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(12, 415);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(93, 415);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // assesmentBindingSource
            // 
            this.assesmentBindingSource.DataSource = typeof(GPRTCommon.Assesment);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // predictedMarkDataGridViewTextBoxColumn
            // 
            this.predictedMarkDataGridViewTextBoxColumn.DataPropertyName = "PredictedMark";
            this.predictedMarkDataGridViewTextBoxColumn.HeaderText = "PredictedMark";
            this.predictedMarkDataGridViewTextBoxColumn.Name = "predictedMarkDataGridViewTextBoxColumn";
            // 
            // actualMarkDataGridViewTextBoxColumn
            // 
            this.actualMarkDataGridViewTextBoxColumn.DataPropertyName = "ActualMark";
            this.actualMarkDataGridViewTextBoxColumn.HeaderText = "ActualMark";
            this.actualMarkDataGridViewTextBoxColumn.Name = "actualMarkDataGridViewTextBoxColumn";
            // 
            // wheightDataGridViewTextBoxColumn
            // 
            this.wheightDataGridViewTextBoxColumn.DataPropertyName = "Wheight";
            this.wheightDataGridViewTextBoxColumn.HeaderText = "Wheight";
            this.wheightDataGridViewTextBoxColumn.Name = "wheightDataGridViewTextBoxColumn";
            // 
            // AssesmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AssesmentForm";
            this.Text = "Assesments";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assesmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assesmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.BindingSource assesmentBindingSource;
        private System.Windows.Forms.BindingSource assesmentBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn predictedMarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualMarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wheightDataGridViewTextBoxColumn;
    }
}