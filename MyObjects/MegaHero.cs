﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObjects {
    class MegaHero : SuperHero {
        public MegaHero(string f, string l):base(f,l) {

        }

        public override string Sing() {
            return base.Sing() + " Fa La La La"; 
        }

    }
}
