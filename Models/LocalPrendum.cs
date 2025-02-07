﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PracticaConBDD.Models
{
    public partial class LocalPrendum
    {
        public int IdPrenda { get; set; }
        public int IdLocal { get; set; }

        public virtual Local IdLocalNavigation { get; set; }
        public virtual Prendum IdPrendaNavigation { get; set; }
    }
}
