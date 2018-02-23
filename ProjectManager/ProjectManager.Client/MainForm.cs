using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjectManager.DAL;

namespace ProjectManager.Client
{
    public partial class MainForm : Form
    {
        #region Constructors

        /// <summary>
        ///     Initialies une nouvelle instance de la classe <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            LST_Projects.Items.AddRange(DataContext.Projects.ToArray());
            LST_Tasks.Items.AddRange(DataContext.Tasks.ToArray());
        }

        #endregion

        #region Methods

        #region Edit

        private void MIT_Add_Click(object sender, EventArgs e)
        {
            if (TCT_MainTabControl.SelectedTab == TAB_Projects)
            {
                AddProject();
            }
            else if(TCT_MainTabControl.SelectedTab == TAB_Tasks)
            {
                AddTask();
            }
        }

        private void MIT_Open_Click(object sender, EventArgs e)
        {
            if (TCT_MainTabControl.SelectedTab == TAB_Projects)
            {
                OpenSelectedProject();
            }
            else if (TCT_MainTabControl.SelectedTab == TAB_Tasks)
            {
                OpenSelectedTask();
            }
        }

        private void MIT_Delete_Click(object sender, EventArgs e)
        {
            if (TCT_MainTabControl.SelectedTab == TAB_Projects)
            {
                DeleteSelectedProject();
            }
            else if (TCT_MainTabControl.SelectedTab == TAB_Tasks)
            {
                DeleteSelectedTask();
            }
        }

        #endregion

        #region Projects

        private void MIT_AddProjects_Click(object sender, EventArgs e)
        {
            AddProject();
        }

        private void MIT_DeleteProjects_Click(object sender, EventArgs e)
        {
            DeleteSelectedProject();
        }

        private void MIT_OpenProjects_Click(object sender, EventArgs e)
        {
            OpenSelectedProject();
        }

        private void LST_Projects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenSelectedProject();
        }

        private void AddProject()
        {
            Project addedProject = new Project();
            addedProject.Name = "Nouveau";
            addedProject.Deadline = DateTime.Now.Date.AddMonths(1);
            addedProject.IsEnded = false;

            ProjectForm form = new ProjectForm(addedProject);
            form.StartPosition = FormStartPosition.CenterParent;

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LST_Projects.Items.Add(addedProject);
                DataContext.Projects.Add(addedProject);
            }
        }

        private void OpenSelectedProject()
        {
            if (this.LST_Projects.SelectedItem is Project)
            {
                Project project = (Project)this.LST_Projects.SelectedItem;
                ProjectForm form = new ProjectForm(project);
                form.StartPosition = FormStartPosition.CenterParent;

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    LST_Projects.Items.Remove(project);
                    LST_Projects.Items.Add(project);
                }
            }
        }

        private void DeleteSelectedProject()
        {
            if (this.LST_Projects.SelectedItem is Project)
            {
                Project toDeleteProject = (Project)this.LST_Projects.SelectedItem;
                LST_Projects.Items.Remove(toDeleteProject);
                DataContext.Projects.Remove(toDeleteProject);
            }
        }

        #endregion

        #region Tasks

        private void MIT_AddTasks_Click(object sender, EventArgs e)
        {
            AddTask();
        }

        private void MIT_DeleteTasks_Click(object sender, EventArgs e)
        {
            DeleteSelectedTask();
        }

        private void MIT_OpenTasks_Click(object sender, EventArgs e)
        {
            OpenSelectedTask();
        }

        private void LST_Tasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenSelectedTask();
        }

        private void AddTask()
        {
            Task addedTask = new Task();
            addedTask.Title = "Nouveau";
            addedTask.StartDate = DateTime.Now.Date.AddDays(1);
            addedTask.EndDate = DateTime.Now.Date.AddDays(1);

            TaskForm form = new TaskForm(addedTask);
            form.StartPosition = FormStartPosition.CenterParent;

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                LST_Tasks.Items.Add(addedTask);
                DataContext.Tasks.Add(addedTask);
            }
        }

        private void OpenSelectedTask()
        {
            if (this.LST_Tasks.SelectedItem is Task)
            {
                Task Task = (Task)this.LST_Tasks.SelectedItem;
                TaskForm form = new TaskForm(Task);
                form.StartPosition = FormStartPosition.CenterParent;

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    LST_Tasks.Items.Remove(Task);
                    LST_Tasks.Items.Add(Task);
                }
            }
        }

        private void DeleteSelectedTask()
        {
            if (this.LST_Tasks.SelectedItem is Task)
            {
                Task toDeleteTask = (Task)this.LST_Tasks.SelectedItem;
                LST_Tasks.Items.Remove(toDeleteTask);
                DataContext.Tasks.Remove(toDeleteTask);
            }
        }


        #endregion

        #endregion

        private void MIT_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
