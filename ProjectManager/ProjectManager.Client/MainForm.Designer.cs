namespace ProjectManager.Client
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.MEN_Menu = new System.Windows.Forms.MenuStrip();
            this.MIT_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MIT_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.MIT_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.MIT_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.MIT_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.MIT_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.MIT_Projects = new System.Windows.Forms.ToolStripMenuItem();
            this.MIT_AddProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.MIT_OpenProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.MIT_DeleteProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.MIT_Tasks = new System.Windows.Forms.ToolStripMenuItem();
            this.MIT_AddTask = new System.Windows.Forms.ToolStripMenuItem();
            this.MIT_OpenTask = new System.Windows.Forms.ToolStripMenuItem();
            this.MIT_DeleteTask = new System.Windows.Forms.ToolStripMenuItem();
            this.TCT_MainTabControl = new System.Windows.Forms.TabControl();
            this.TAB_Projects = new System.Windows.Forms.TabPage();
            this.LST_Projects = new System.Windows.Forms.ListBox();
            this.TAB_Tasks = new System.Windows.Forms.TabPage();
            this.LST_Tasks = new System.Windows.Forms.ListBox();
            this.MEN_Menu.SuspendLayout();
            this.TCT_MainTabControl.SuspendLayout();
            this.TAB_Projects.SuspendLayout();
            this.TAB_Tasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // MEN_Menu
            // 
            this.MEN_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIT_File,
            this.MIT_Edit,
            this.MIT_Projects,
            this.MIT_Tasks});
            this.MEN_Menu.Location = new System.Drawing.Point(0, 0);
            this.MEN_Menu.Name = "MEN_Menu";
            this.MEN_Menu.Size = new System.Drawing.Size(697, 24);
            this.MEN_Menu.TabIndex = 0;
            this.MEN_Menu.Text = "menuStrip1";
            // 
            // MIT_File
            // 
            this.MIT_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIT_Exit});
            this.MIT_File.Name = "MIT_File";
            this.MIT_File.Size = new System.Drawing.Size(54, 20);
            this.MIT_File.Text = "&Fichier";
            // 
            // MIT_Exit
            // 
            this.MIT_Exit.Name = "MIT_Exit";
            this.MIT_Exit.Size = new System.Drawing.Size(152, 22);
            this.MIT_Exit.Text = "&Quitter";
            this.MIT_Exit.Click += new System.EventHandler(this.MIT_Exit_Click);
            // 
            // MIT_Edit
            // 
            this.MIT_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIT_Add,
            this.MIT_Open,
            this.MIT_Delete});
            this.MIT_Edit.Name = "MIT_Edit";
            this.MIT_Edit.Size = new System.Drawing.Size(56, 20);
            this.MIT_Edit.Text = "Edition";
            // 
            // MIT_Add
            // 
            this.MIT_Add.Name = "MIT_Add";
            this.MIT_Add.Size = new System.Drawing.Size(152, 22);
            this.MIT_Add.Text = "Ajouter";
            this.MIT_Add.Click += new System.EventHandler(this.MIT_Add_Click);
            // 
            // MIT_Open
            // 
            this.MIT_Open.Name = "MIT_Open";
            this.MIT_Open.Size = new System.Drawing.Size(152, 22);
            this.MIT_Open.Text = "Ouvrir";
            this.MIT_Open.Click += new System.EventHandler(this.MIT_Open_Click);
            // 
            // MIT_Delete
            // 
            this.MIT_Delete.Name = "MIT_Delete";
            this.MIT_Delete.Size = new System.Drawing.Size(152, 22);
            this.MIT_Delete.Text = "Supprimer";
            this.MIT_Delete.Click += new System.EventHandler(this.MIT_Delete_Click);
            // 
            // MIT_Projects
            // 
            this.MIT_Projects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIT_AddProjects,
            this.MIT_OpenProjects,
            this.MIT_DeleteProjects});
            this.MIT_Projects.Name = "MIT_Projects";
            this.MIT_Projects.Size = new System.Drawing.Size(55, 20);
            this.MIT_Projects.Text = "&Projets";
            // 
            // MIT_AddProjects
            // 
            this.MIT_AddProjects.Name = "MIT_AddProjects";
            this.MIT_AddProjects.Size = new System.Drawing.Size(129, 22);
            this.MIT_AddProjects.Text = "&Ajouter";
            this.MIT_AddProjects.Click += new System.EventHandler(this.MIT_AddProjects_Click);
            // 
            // MIT_OpenProjects
            // 
            this.MIT_OpenProjects.Name = "MIT_OpenProjects";
            this.MIT_OpenProjects.Size = new System.Drawing.Size(129, 22);
            this.MIT_OpenProjects.Text = "Ouvrir";
            this.MIT_OpenProjects.Click += new System.EventHandler(this.MIT_OpenProjects_Click);
            // 
            // MIT_DeleteProjects
            // 
            this.MIT_DeleteProjects.Name = "MIT_DeleteProjects";
            this.MIT_DeleteProjects.Size = new System.Drawing.Size(129, 22);
            this.MIT_DeleteProjects.Text = "Supprimer";
            this.MIT_DeleteProjects.Click += new System.EventHandler(this.MIT_DeleteProjects_Click);
            // 
            // MIT_Tasks
            // 
            this.MIT_Tasks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MIT_AddTask,
            this.MIT_OpenTask,
            this.MIT_DeleteTask});
            this.MIT_Tasks.Name = "MIT_Tasks";
            this.MIT_Tasks.Size = new System.Drawing.Size(55, 20);
            this.MIT_Tasks.Text = "Tâches";
            // 
            // MIT_AddTask
            // 
            this.MIT_AddTask.Name = "MIT_AddTask";
            this.MIT_AddTask.Size = new System.Drawing.Size(129, 22);
            this.MIT_AddTask.Text = "Ajouter";
            this.MIT_AddTask.Click += new System.EventHandler(this.MIT_AddTasks_Click);
            // 
            // MIT_OpenTask
            // 
            this.MIT_OpenTask.Name = "MIT_OpenTask";
            this.MIT_OpenTask.Size = new System.Drawing.Size(129, 22);
            this.MIT_OpenTask.Text = "Ouvrir";
            this.MIT_OpenTask.Click += new System.EventHandler(this.MIT_OpenTasks_Click);
            // 
            // MIT_DeleteTask
            // 
            this.MIT_DeleteTask.Name = "MIT_DeleteTask";
            this.MIT_DeleteTask.Size = new System.Drawing.Size(129, 22);
            this.MIT_DeleteTask.Text = "Supprimer";
            this.MIT_DeleteTask.Click += new System.EventHandler(this.MIT_DeleteTasks_Click);
            // 
            // TCT_MainTabControl
            // 
            this.TCT_MainTabControl.Controls.Add(this.TAB_Projects);
            this.TCT_MainTabControl.Controls.Add(this.TAB_Tasks);
            this.TCT_MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TCT_MainTabControl.Location = new System.Drawing.Point(0, 24);
            this.TCT_MainTabControl.Name = "TCT_MainTabControl";
            this.TCT_MainTabControl.SelectedIndex = 0;
            this.TCT_MainTabControl.Size = new System.Drawing.Size(697, 358);
            this.TCT_MainTabControl.TabIndex = 1;
            // 
            // TAB_Projects
            // 
            this.TAB_Projects.Controls.Add(this.LST_Projects);
            this.TAB_Projects.Location = new System.Drawing.Point(4, 22);
            this.TAB_Projects.Name = "TAB_Projects";
            this.TAB_Projects.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_Projects.Size = new System.Drawing.Size(689, 332);
            this.TAB_Projects.TabIndex = 0;
            this.TAB_Projects.Text = "Projets";
            this.TAB_Projects.UseVisualStyleBackColor = true;
            // 
            // LST_Projects
            // 
            this.LST_Projects.DisplayMember = "Name";
            this.LST_Projects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LST_Projects.FormattingEnabled = true;
            this.LST_Projects.Location = new System.Drawing.Point(3, 3);
            this.LST_Projects.Name = "LST_Projects";
            this.LST_Projects.Size = new System.Drawing.Size(683, 326);
            this.LST_Projects.Sorted = true;
            this.LST_Projects.TabIndex = 0;
            this.LST_Projects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LST_Projects_MouseDoubleClick);
            // 
            // TAB_Tasks
            // 
            this.TAB_Tasks.Controls.Add(this.LST_Tasks);
            this.TAB_Tasks.Location = new System.Drawing.Point(4, 22);
            this.TAB_Tasks.Name = "TAB_Tasks";
            this.TAB_Tasks.Padding = new System.Windows.Forms.Padding(3);
            this.TAB_Tasks.Size = new System.Drawing.Size(689, 332);
            this.TAB_Tasks.TabIndex = 1;
            this.TAB_Tasks.Text = "Tâches";
            this.TAB_Tasks.UseVisualStyleBackColor = true;
            // 
            // LST_Tasks
            // 
            this.LST_Tasks.DisplayMember = "Title";
            this.LST_Tasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LST_Tasks.FormattingEnabled = true;
            this.LST_Tasks.Location = new System.Drawing.Point(3, 3);
            this.LST_Tasks.Name = "LST_Tasks";
            this.LST_Tasks.Size = new System.Drawing.Size(683, 326);
            this.LST_Tasks.Sorted = true;
            this.LST_Tasks.TabIndex = 0;
            this.LST_Tasks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LST_Tasks_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 382);
            this.Controls.Add(this.TCT_MainTabControl);
            this.Controls.Add(this.MEN_Menu);
            this.MainMenuStrip = this.MEN_Menu;
            this.Name = "MainForm";
            this.Text = "Project Manager";
            this.MEN_Menu.ResumeLayout(false);
            this.MEN_Menu.PerformLayout();
            this.TCT_MainTabControl.ResumeLayout(false);
            this.TAB_Projects.ResumeLayout(false);
            this.TAB_Tasks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MEN_Menu;
        private System.Windows.Forms.ToolStripMenuItem MIT_File;
        private System.Windows.Forms.ToolStripMenuItem MIT_Exit;
        private System.Windows.Forms.TabControl TCT_MainTabControl;
        private System.Windows.Forms.TabPage TAB_Projects;
        private System.Windows.Forms.ListBox LST_Projects;
        private System.Windows.Forms.ToolStripMenuItem MIT_Projects;
        private System.Windows.Forms.ToolStripMenuItem MIT_AddProjects;
        private System.Windows.Forms.ToolStripMenuItem MIT_OpenProjects;
        private System.Windows.Forms.ToolStripMenuItem MIT_DeleteProjects;
        private System.Windows.Forms.TabPage TAB_Tasks;
        private System.Windows.Forms.ListBox LST_Tasks;
        private System.Windows.Forms.ToolStripMenuItem MIT_Tasks;
        private System.Windows.Forms.ToolStripMenuItem MIT_AddTask;
        private System.Windows.Forms.ToolStripMenuItem MIT_OpenTask;
        private System.Windows.Forms.ToolStripMenuItem MIT_DeleteTask;
        private System.Windows.Forms.ToolStripMenuItem MIT_Edit;
        private System.Windows.Forms.ToolStripMenuItem MIT_Add;
        private System.Windows.Forms.ToolStripMenuItem MIT_Open;
        private System.Windows.Forms.ToolStripMenuItem MIT_Delete;
    }
}

