﻿namespace MasterPro.Dlg
{
    partial class SelecetScoreDlg
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
            this.label1 = new System.Windows.Forms.Label();
            this.score_input = new System.Windows.Forms.TextBox();
            this.SureBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入需要查询的成绩";
            // 
            // score_input
            // 
            this.score_input.Location = new System.Drawing.Point(175, 28);
            this.score_input.Name = "score_input";
            this.score_input.Size = new System.Drawing.Size(195, 25);
            this.score_input.TabIndex = 1;
            // 
            // SureBtn
            // 
            this.SureBtn.Location = new System.Drawing.Point(390, 29);
            this.SureBtn.Name = "SureBtn";
            this.SureBtn.Size = new System.Drawing.Size(75, 23);
            this.SureBtn.TabIndex = 2;
            this.SureBtn.Text = "查询";
            this.SureBtn.UseVisualStyleBackColor = true;
            this.SureBtn.Click += new System.EventHandler(this.SureBtn_Click);
            // 
            // SelecetScoreDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 83);
            this.Controls.Add(this.SureBtn);
            this.Controls.Add(this.score_input);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(500, 130);
            this.MinimumSize = new System.Drawing.Size(500, 130);
            this.Name = "SelecetScoreDlg";
            this.Text = "查找学生成绩";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox score_input;
        private System.Windows.Forms.Button SureBtn;
    }
}