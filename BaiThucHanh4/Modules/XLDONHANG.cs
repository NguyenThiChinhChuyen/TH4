using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh4.Modules
{
    class XLDONHANG: XLBANG
    {
        public XLDONHANG() : base("DONHANG") { }
        public XLDONHANG(string pQuery) : base("DONHANG", pQuery) { }
    }
}
