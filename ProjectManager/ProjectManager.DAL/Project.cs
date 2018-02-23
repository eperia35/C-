using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.DAL
{
    /// <summary>
    ///     Représente un projet.
    /// </summary>
    public class Project
    {
        #region Fields

        private string _Name;
        private bool _IsEnded;
        private double _EstimatedCost;
        private DateTime _Deadline;

        #endregion

        #region Properties

        /// <summary>
        ///     Obtient ou définit le nom du projet.
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        /// <summary>
        ///     Obtient ou définit si le projet est terminé.
        /// </summary>
        public bool IsEnded
        {
            get { return _IsEnded; }
            set { _IsEnded = value; }
        }

        /// <summary>
        ///     Obtient ou définit le coût estimé du projet.
        /// </summary>
        public double EstimatedCost
        {
            get { return _EstimatedCost; }
            set { _EstimatedCost = value; }
        }

        /// <summary>
        ///     Obtient ou définit la date limite de livraison du projet.
        /// </summary>
        public DateTime Deadline
        {
            get { return _Deadline; }
            set { _Deadline = value; }
        }

        #endregion
    }
}
