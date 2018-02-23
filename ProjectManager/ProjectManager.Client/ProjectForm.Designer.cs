namespace ProjectManager.Client
{
    partial class ProjectForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_Name = new System.Windows.Forms.Label();
            this.LBL_IsEnded = new System.Windows.Forms.Label();
            this.LBL_Deadline = new System.Windows.Forms.Label();
            this.LBL_EstimatedCost = new System.Windows.Forms.Label();
            this.TXT_Name = new System.Windows.Forms.TextBox();
            this.TXT_EstimatedCost = new System.Windows.Forms.TextBox();
            this.DTP_Deadline = new System.Windows.Forms.DateTimePicker();
            this.CKB_IsEnded = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LBL_Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_IsEnded, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Deadline, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_EstimatedCost, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TXT_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TXT_EstimatedCost, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DTP_Deadline, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CKB_IsEnded, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(283, 170);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Name.Location = new System.Drawing.Point(3, 0);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(68, 26);
            this.LBL_Name.TabIndex = 0;
            this.LBL_Name.Text = "Nom :";
            // 
            // LBL_IsEnded
            // 
            this.LBL_IsEnded.AutoSize = true;
            this.LBL_IsEnded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_IsEnded.Location = new System.Drawing.Point(3, 26);
            this.LBL_IsEnded.Name = "LBL_IsEnded";
            this.LBL_IsEnded.Size = new System.Drawing.Size(68, 20);
            this.LBL_IsEnded.TabIndex = 1;
            this.LBL_IsEnded.Text = "Est terminé :";
            // 
            // LBL_Deadline
            // 
            this.LBL_Deadline.AutoSize = true;
            this.LBL_Deadline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Deadline.Location = new System.Drawing.Point(3, 46);
            this.LBL_Deadline.Name = "LBL_Deadline";
            this.LBL_Deadline.Size = new System.Drawing.Size(68, 26);
            this.LBL_Deadline.TabIndex = 2;
            this.LBL_Deadline.Text = "Date limite :";
            // 
            // LBL_EstimatedCost
            // 
            this.LBL_EstimatedCost.AutoSize = true;
            this.LBL_EstimatedCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_EstimatedCost.Location = new System.Drawing.Point(3, 72);
            this.LBL_EstimatedCost.Name = "LBL_EstimatedCost";
            this.LBL_EstimatedCost.Size = new System.Drawing.Size(68, 26);
            this.LBL_EstimatedCost.TabIndex = 3;
            this.LBL_EstimatedCost.Text = "Coût estimé :";
            // 
            // TXT_Name
            // 
            this.TXT_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_Name.Location = new System.Drawing.Point(77, 3);
            this.TXT_Name.Name = "TXT_Name";
            this.TXT_Name.Size = new System.Drawing.Size(203, 20);
            this.TXT_Name.TabIndex = 4;
            // 
            // TXT_EstimatedCost
            // 
            this.TXT_EstimatedCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_EstimatedCost.Location = new System.Drawing.Point(77, 75);
            this.TXT_EstimatedCost.Name = "TXT_EstimatedCost";
            this.TXT_EstimatedCost.Size = new System.Drawing.Size(203, 20);
            this.TXT_EstimatedCost.TabIndex = 5;
            // 
            // DTP_Deadline
            // 
            this.DTP_Deadline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTP_Deadline.Location = new System.Drawing.Point(77, 49);
            this.DTP_Deadline.Name = "DTP_Deadline";
            this.DTP_Deadline.Size = new System.Drawing.Size(203, 20);
            this.DTP_Deadline.TabIndex = 6;
            // 
            // CKB_IsEnded
            // 
            this.CKB_IsEnded.AutoSize = true;
            this.CKB_IsEnded.Location = new System.Drawing.Point(77, 29);
            this.CKB_IsEnded.Name = "CKB_IsEnded";
            this.CKB_IsEnded.Size = new System.Drawing.Size(15, 14);
            this.CKB_IsEnded.TabIndex = 7;
            this.CKB_IsEnded.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Ok);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Cancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 138);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(277, 29);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Location = new System.Drawing.Point(199, 3);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 1;
            this.BTN_Ok.Text = "&Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(118, 3);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 2;
            this.BTN_Cancel.Text = "&Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // ProjectForm
            // 
            this.AcceptButton = this.BTN_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(283, 170);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProjectForm";
            this.Text = "Projet";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.Label LBL_IsEnded;
        private System.Windows.Forms.Label LBL_Deadline;
        private System.Windows.Forms.Label LBL_EstimatedCost;
        private System.Windows.Forms.CheckBox CKB_IsEnded;
        private System.Windows.Forms.DateTimePicker DTP_Deadline;
        private System.Windows.Forms.TextBox TXT_EstimatedCost;
        private System.Windows.Forms.TextBox TXT_Name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Cancel;
    }
}