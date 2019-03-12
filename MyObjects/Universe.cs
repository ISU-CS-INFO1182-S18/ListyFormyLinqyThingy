using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObjects {
   static class Universe {
        private static List<Person> _People;

        public static List<Person> People {
            get {
                if (_People == null) _People = new List<Person>();
                return _People;
            }
            set { _People = value; }
        }
    }
}
