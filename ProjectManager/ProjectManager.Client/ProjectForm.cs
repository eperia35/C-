using ProjectManager.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager.Client
{
    public partial class ProjectForm : Form
    {
        private Project _Project;

        public ProjectForm(Project project)
        {
            InitializeComponent();

            _Project = project;

            TXT_Name.Text = _Project.Name;
            CKB_IsEnded.Checked = _Project.IsEnded;
            DTP_Deadline.Value = _Project.Deadline;
            TXT_EstimatedCost.Text = _Project.EstimatedCost.ToString();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            _Project.Name = TXT_Name.Text;
            _Project.IsEnded = CKB_IsEnded.Checked;
            _Project.Deadline = DTP_Deadline.Value;

            double result = 0;

            if (double.TryParse(TXT_EstimatedCost.Text, out result))
            {
                _Project.EstimatedCost = result;
            }

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
