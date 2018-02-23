namespace ProjectManager.Client
{
    partial class TaskForm
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
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_Project = new System.Windows.Forms.Label();
            this.LBL_StartDate = new System.Windows.Forms.Label();
            this.LBL_EndDate = new System.Windows.Forms.Label();
            this.LBL_Description = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.TXT_Description = new System.Windows.Forms.TextBox();
            this.TXT_Title = new System.Windows.Forms.TextBox();
            this.CBX_Project = new System.Windows.Forms.ComboBox();
            this.DTP_StartDate = new System.Windows.Forms.DateTimePicker();
            this.DTP_EndDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LBL_Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Project, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_StartDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBL_EndDate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LBL_Description, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.TXT_Description, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TXT_Title, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CBX_Project, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DTP_StartDate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.DTP_EndDate, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 255);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Title.Location = new System.Drawing.Point(3, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(66, 26);
            this.LBL_Title.TabIndex = 0;
            this.LBL_Title.Text = "Title :";
            // 
            // LBL_Project
            // 
            this.LBL_Project.AutoSize = true;
            this.LBL_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Project.Location = new System.Drawing.Point(3, 26);
            this.LBL_Project.Name = "LBL_Project";
            this.LBL_Project.Size = new System.Drawing.Size(66, 27);
            this.LBL_Project.TabIndex = 1;
            this.LBL_Project.Text = "Projet :";
            // 
            // LBL_StartDate
            // 
            this.LBL_StartDate.AutoSize = true;
            this.LBL_StartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_StartDate.Location = new System.Drawing.Point(3, 53);
            this.LBL_StartDate.Name = "LBL_StartDate";
            this.LBL_StartDate.Size = new System.Drawing.Size(66, 26);
            this.LBL_StartDate.TabIndex = 2;
            this.LBL_StartDate.Text = "Début :";
            // 
            // LBL_EndDate
            // 
            this.LBL_EndDate.AutoSize = true;
            this.LBL_EndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_EndDate.Location = new System.Drawing.Point(3, 79);
            this.LBL_EndDate.Name = "LBL_EndDate";
            this.LBL_EndDate.Size = new System.Drawing.Size(66, 26);
            this.LBL_EndDate.TabIndex = 3;
            this.LBL_EndDate.Text = "Fin :";
            // 
            // LBL_Description
            // 
            this.LBL_Description.AutoSize = true;
            this.LBL_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Description.Location = new System.Drawing.Point(3, 105);
            this.LBL_Description.Name = "LBL_Description";
            this.LBL_Description.Size = new System.Drawing.Size(66, 86);
            this.LBL_Description.TabIndex = 4;
            this.LBL_Description.Text = "Description :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Ok);
            this.flowLayoutPanel1.Controls.Add(this.BTN_Cancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 223);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(352, 29);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Location = new System.Drawing.Point(274, 3);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 0;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            this.BTN_Ok.Click += new System.EventHandler(this.BTN_Ok_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(193, 3);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 1;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // TXT_Description
            // 
            this.TXT_Description.AcceptsReturn = true;
            this.TXT_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_Description.Location = new System.Drawing.Point(75, 108);
            this.TXT_Description.Multiline = true;
            this.TXT_Description.Name = "TXT_Description";
            this.TXT_Description.Size = new System.Drawing.Size(280, 80);
            this.TXT_Description.TabIndex = 6;
            // 
            // TXT_Title
            // 
            this.TXT_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXT_Title.Location = new System.Drawing.Point(75, 3);
            this.TXT_Title.Name = "TXT_Title";
            this.TXT_Title.Size = new System.Drawing.Size(280, 20);
            this.TXT_Title.TabIndex = 7;
            // 
            // CBX_Project
            // 
            this.CBX_Project.DisplayMember = "Name";
            this.CBX_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBX_Project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Project.FormattingEnabled = true;
            this.CBX_Project.Location = new System.Drawing.Point(75, 29);
            this.CBX_Project.Name = "CBX_Project";
            this.CBX_Project.Size = new System.Drawing.Size(280, 21);
            this.CBX_Project.Sorted = true;
            this.CBX_Project.TabIndex = 8;
            // 
            // DTP_StartDate
            // 
            this.DTP_StartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTP_StartDate.Location = new System.Drawing.Point(75, 56);
            this.DTP_StartDate.Name = "DTP_StartDate";
            this.DTP_StartDate.Size = new System.Drawing.Size(280, 20);
            this.DTP_StartDate.TabIndex = 9;
            // 
            // DTP_EndDate
            // 
            this.DTP_EndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTP_EndDate.Location = new System.Drawing.Point(75, 82);
            this.DTP_EndDate.Name = "DTP_EndDate";
            this.DTP_EndDate.Size = new System.Drawing.Size(280, 20);
            this.DTP_EndDate.TabIndex = 10;
            // 
            // TaskForm
            // 
            this.AcceptButton = this.BTN_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(358, 255);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TaskForm";
            this.Text = "Tâche";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Project;
        private System.Windows.Forms.Label LBL_StartDate;
        private System.Windows.Forms.Label LBL_EndDate;
        private System.Windows.Forms.Label LBL_Description;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.TextBox TXT_Description;
        private System.Windows.Forms.TextBox TXT_Title;
        private System.Windows.Forms.ComboBox CBX_Project;
        private System.Windows.Forms.DateTimePicker DTP_StartDate;
        private System.Windows.Forms.DateTimePicker DTP_EndDate;
    }
}