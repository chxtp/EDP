using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDPCheck
{
    class NetData
    {
        EDPDataDataContext db = new EDPDataDataContext();

        public string GetSTName(int stid) 
        {
            var st = from s in db.T_ST where s.STID == stid select s;
            return st.FirstOrDefault().ST;
        }
        public T_ST GetSTInfo(int stid) 
        {
            var st = from s in db.T_ST where s.STID == stid select s;
            return st.FirstOrDefault();
        }

        public static void UpdateMsg() 
        {

        }

        public static void Err() 
        {

        }
        public static void ReBack() 
        {

        }
    }
}
