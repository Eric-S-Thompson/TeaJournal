/**
 * Summary: Creates initial data for the list of teas, and handles adding/removing/modifying new entries
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaJournal.Infrastructure;

namespace TeaJournal
{
    class DataInitializer
    {
        public List<Tea> teaList = new List<Tea>();

        /**
         * Read in saved teas for initial list
         */
        public DataInitializer()
        {
            teaList.Add(new Tea(Tea.teaType.Green, "Gyokuru", "Extra instructions", "Extra notes"));
            teaList.Add(new Tea(Tea.teaType.Black, "Earl Grey", "Earl Grey instructions", "Earl Grey notes"));
            TeaList testList = new TeaList();
        }

        public void Start()
        {

        }

        public void AddTea(Tea newTea)
        {
            teaList.Add(newTea);
        }
    }
}
