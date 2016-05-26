using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AntiCEDriver;

namespace AntiCEDriver
{
    public class ObfuscInt
    {
        public SafeInteger _sf { get; set; }

        public ObfuscInt()
        {
            _sf = new SafeInteger();
        }

        public ObfuscInt(int a)
        {
            _sf = new SafeInteger(a);
        }

        public void Add(int a)
        {
            if (_sf.val1 != (_sf.val2[_sf._rand] - _sf._rand))
            {
                throw new Exception("Fuck You Asshole");
            }
            _sf.val1 += a;
            _sf.val2[_sf._rand] = (_sf.val1 + _sf._rand);
        }

        public static ObfuscInt operator +(ObfuscInt oi, int a)
        {
            ObfuscInt oii = oi;
            oii.Add(a);
            return oii;
        }
    }
}
