using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.DAL
{
    /// <summary>
    ///     Représente une tâche d'un projet.
    /// </summary>
    public class Task
    {
        #region Fields

        private DateTime _StartDate;
        private DateTime _EndDate;
        private string _Title;
        private string _Description;
        private Project _Project;

        #endregion

        #region Properties

        /// <summary>
        ///     Obtient ou définit la date de début de la tâche.
        /// </summary>
        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        /// <summary>
        ///     Obtient ou définit la date de fin de la tâche.
        /// </summary>
        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        /// <summary>
        ///     Obtient ou définit le titre de la tâche.
        /// </summary>
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        /// <summary>
        ///     Obtient ou définit la description de la tâche.
        /// </summary>
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        /// <summary>
        ///     Obtient ou définit le projet associé.
        /// </summary>
        public Project Project
        {
            get { return _Project; }
            set { _Project = value; }
        }

        #endregion
    }
}
