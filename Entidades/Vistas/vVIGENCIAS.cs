﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class vVIGENCIAS
    {
        public short YEAR_VIG { get; set; }
        public System.DateTime FEC_INI_VIG { get; set; }
        public Nullable<System.DateTime> FEC_FIN_VIG { get; set; }
        public byte POR_ADI_VIG { get; set; }
        public string EST_VIG { get; set; }
        public string RAD_AUT { get; set; }
    }
}