using ProjectManager.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectManager.Client
{
    public partial class TaskForm : Form
    {
        #region Fields

        /// <summary>
        ///     Tâche à modifier.
        /// </summary>
        private Task _Task;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initialise une nouvelle instance de la classe <see cref="TaskForm"/>.
        /// </summary>
        /// <param name="task">Tâche à modifier.</param>
        public TaskForm(Task task)
        {
            InitializeComponent();

            _Task = task;
            TXT_Title.Text = _Task.Title;
            CBX_Project.Items.AddRange(DataContext.Projects.ToArray());
            CBX_Project.SelectedItem = _Task.Project;
            DTP_StartDate.Value = _Task.StartDate;
            DTP_EndDate.Value = _Task.EndDate;
            TXT_Description.Text = _Task.Description;
        }

        #endregion

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            _Task.Title = TXT_Title.Text;
            _Task.Project = CBX_Project.SelectedItem as Project;
            _Task.StartDate = DTP_StartDate.Value;
            _Task.EndDate = DTP_EndDate.Value;
            _Task.Description = TXT_Description.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
