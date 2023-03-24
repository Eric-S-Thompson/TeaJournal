using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaJournal.Infrastructure
{
    class TeaList
    {
        private List<List<Tea>> teaList;
        public TeaList()
        {
            teaList = new List<List<Tea>>();
            PopulateTeaList();
        }
        /// <summary>
        /// Initialize our <see cref="teaList"/> with empty <see cref="List{Tea}"/> of <see cref="Tea"/>s,
        /// one for each <see cref="Tea.teaType"/>.
        /// </summary>
        private void PopulateTeaList()
        {
            foreach (int i in Enum.GetValues(typeof(Tea.teaType)))
            {
                Debug.WriteLine(i);
                teaList.Insert(i, new List<Tea>());
            }
        }
        /// <summary>
        /// Adds a given <see cref="Tea"/> to the <see cref="teaList"/>, with the index based on
        /// the <see cref="Tea.teaType"/> enum.
        /// </summary>
        /// <param name="tea">The <see cref="Tea"/> to be added.</param>
        /// <returns>True if the <see cref="Tea"/> was added, False if the <see cref="Tea"/> already exists.</returns>
        public bool AddTea(Tea tea)
        {
            int type = (int) tea.type;
            if (AlreadyExists(tea, type))
            {
                Debug.WriteLine("TeaList.cs: AddTea: Tea exists already in teaList!");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Finds whether the <see cref="Tea"/> already exists in our <see cref="teaList"/>
        /// </summary>
        /// <param name="tea"></param>
        /// <param name="typeIndex"></param>
        /// <returns></returns>
        private bool AlreadyExists(Tea tea, int typeIndex)
        {
            foreach (Tea t in teaList[typeIndex])
            {
                if (tea.Equals(t))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Finds if a <see cref="Tea"/> with name <see cref="Tea.name"/> exists.
        /// </summary>
        /// <param name="teaName">The name to search for.</param>
        /// <returns>True if a <see cref="Tea"/> is found, False if not.</returns>
        public bool FindTea(string teaName)
        {
            return false;
        }
        /// <summary>
        /// Deletes a given <see cref="Tea"/> from the <see cref="teaList"/> if it exists.
        /// </summary>
        /// <param name="tea">The <see cref="Tea"/> to remove.</param>
        /// <returns>True if the <see cref="Tea"/> is found and deleted, False if not.</returns>
        public bool DeleteTea(Tea tea)
        {
            return false;
        }
    }
}
