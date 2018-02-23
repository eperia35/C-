using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.DAL
{
    /// <summary>
    ///     Contexte d'accès aux données.
    /// </summary>
    public class DataContext
    {
        #region Fields

        private static List<Project> _Projects;
        private static List<Task> _Tasks;

        #endregion

        #region Properties

        /// <summary>
        ///     Obtient ou définit la liste des projets.
        /// </summary>
        public static List<Project> Projects
        {
            get { return _Projects; }
            set { _Projects = value; }
        }

        /// <summary>
        ///     Obtient ou définit la liste des tâches.
        /// </summary>
        public static List<Task> Tasks
        {
            get { return _Tasks; }
            set { _Tasks = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        ///     Constructeur statique de la classe <see cref="DataContext"/>.
        /// </summary>
        static DataContext()
        {
            _Projects = new List<Project>();
            _Tasks = new List<Task>();

            Project p1 = new Project();
            p1.Name = "Carnet d'adresse";
            p1.IsEnded = false;
            p1.Deadline = new DateTime(2017, 11, 30);
            p1.EstimatedCost = 135.58;
            _Projects.Add(p1);

            Task t1 = new Task();
            t1.Project = p1;
            t1.Title = "Ajouter une personne";
            t1.StartDate = new DateTime(2017, 4, 15);
            t1.EndDate = new DateTime(2017, 4, 20);
            t1.Description = "Pouvoir ajouter une personne dans le carnet.";
            _Tasks.Add(t1);

            Task t2 = new Task();
            t2.Project = p1;
            t2.Title = "Modifier une personne";
            t2.StartDate = new DateTime(2017, 5, 15);
            t2.EndDate = new DateTime(2017, 5, 20);
            t2.Description = "Pouvoir modifier une personne dans le carnet.";
            _Tasks.Add(t2);

            Task t3 = new Task();
            t3.Project = p1;
            t3.Title = "Supprimer une personne";
            t3.StartDate = new DateTime(2017, 6, 15);
            t3.EndDate = new DateTime(2017, 6, 20);
            t3.Description = "Pouvoir supprimer une personne dans le carnet.";
            _Tasks.Add(t3);

        }

        #endregion

    }
}
