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

                //TEMP Initial Values
                String name = ((Tea.teaType)i).ToString();
                Tea tempTea = new Tea((Tea.teaType) i, name+"1", "Test 1 Instructions", "Test notes");
                Tea tempTea2 = new Tea((Tea.teaType)i, name+"2", "Test 2 Instructions", "Test notes");

                teaList[i].Add(tempTea);
                teaList[i].Add(tempTea2);
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
            int type = getTypeInt(tea);
            if (AlreadyExists(tea, type) || teaList.Capacity < type)
            {
                Debug.WriteLine("TeaList.cs: AddTea: Tea exists already in teaList!");
                return false;
            }
            teaList[type].Add(tea);
            teaList[type] = teaList[type].OrderBy(t => t.name).ToList();
            Debug.WriteLine("Tealist.cs: AddTea: List so far: \n");
            Debug.WriteLine(String.Join(", ", teaList[type]));
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
            int typeIndex = getTypeInt(tea);
            return teaList[typeIndex].Remove(tea);
            /**
            foreach (Tea t in teaList[typeIndex])
            {
                if (tea.Equals(t))
                {
                    teaList[typeIndex].Remove(tea);
                    return true;
                }
            }
            return false;**/
        }

        public List<Tea> GetTeaOfType(Tea.teaType type)
        {
            return teaList[getTypeInt(type)];
        }

        private int getTypeInt(Tea tea)
        {
            return (int) tea.type;
        }
        private int getTypeInt(Tea.teaType type)
        {
            return (int) type;
        }
    }
}
