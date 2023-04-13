/**
 * Summary: Defines the data associated with each tea
 *          (name, type, brewing time, brewing temp, notes, etc.)
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaJournal
{
    class Tea
    {
        public enum teaType
        {
            Green,
            Black,
            White,
            Herbal,
            Oolong,
            Other
        }
        public teaType type { get; set; }
        public string name { get; set; }
        public DateTime brewTime { get; set; }
        public string otherInstructions { get; set; }
        public string notes { get; set; }

        public Tea(teaType type, string name, string instructions, string notes)
        {
            this.type = type;
            this.name = name;
            DateTime date = new DateTime(2001, 1, 1, 1, 0, 0);
            this.brewTime = date;
            this.otherInstructions = instructions;
            this.notes = notes;
        }

        public bool Equals(Tea otherTea)
        {
            bool equal = true;
            if (otherTea.type != this.type || otherTea.name != this.name)
            {
                equal = false;
            }
            if (!otherTea.brewTime.Equals(this.brewTime))
            {
                equal = false;
            }
            if (otherTea.otherInstructions != this.otherInstructions || otherTea.notes != this.notes)
            {
                equal = false;
            }
            return equal;
        }

        public static teaType stringToEnum(string s)
        {
            teaType newType;
            if (Enum.TryParse<teaType>(s, out newType))
            {
                return newType;
            }
            else
            {
                return teaType.Black; // Default
            }
        }
    }
}
