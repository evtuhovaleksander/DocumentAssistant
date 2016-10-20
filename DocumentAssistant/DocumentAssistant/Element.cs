using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAssistant
{
    class Element2
    {
        int ID;
        string Serial1;
        string Serial2;
        string Type;
        string Mark;
        string Status;
        string Place;
        string Coments;
        int Typeid;
        int Markid;
        int Statusid;
        int Placeid;
    }

    class Element
    {
        public Element(string table, string name, bool cons, bool cmbox, string addtable)
        {
            this.table = table;
            this.name = name;
            this.cons = cons;
            this.cmbox = cmbox;
            this.addtable = addtable;
            if(this.cmbox)innerpart= "inner join "+this.addtable+" on "+this.table+"."+this.name+"="+
            this.addtable + "."  + "ID ";
        }

        public string table;
        public string name;

        public bool cons;

        public bool cmbox;
        public string addtable;
        public string innerpart;
    }
}
