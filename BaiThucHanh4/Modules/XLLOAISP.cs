﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh4.Modules
{
    class XLLOAISP: XLBANG
    {
        public XLLOAISP() : base("LOAISP") { }
        public XLLOAISP(string pQuery) : base("LOAISP", pQuery) { }
    }
}
