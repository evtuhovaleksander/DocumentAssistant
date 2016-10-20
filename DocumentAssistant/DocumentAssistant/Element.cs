using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentAssistant
{
    class Element
    {
        public Element(string name, string rusName, bool cons, bool tbox, bool autocomplete, bool cmbox, string[] collection)
        {
            Name = name;
            RusName = rusName;
            this.cons = cons;
            this.tbox = tbox;
            this.autocomplete = autocomplete;
            this.cmbox = cmbox;
            this.collection = collection;
        }

        public Element(string name, string rusName, bool cons, bool tbox, bool autocomplete, bool cmbox, bool complexQueue, string[] collection, string innerPart)
        {
            Name = name;
            RusName = rusName;
            this.cons = cons;
            this.tbox = tbox;
            this.autocomplete = autocomplete;
            this.cmbox = cmbox;
            this.complexQueue = complexQueue;
            this.collection = collection;
            this.innerPart = innerPart;
        }

        public string Name;
        public string RusName;
        public bool cons;
        public bool tbox;
        public bool autocomplete;
        public bool cmbox;
        public bool complexQueue;
        public string[] collection;
        public string innerPart;
    }
}
