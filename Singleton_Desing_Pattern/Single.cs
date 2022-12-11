using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Desing_Pattern
{
    public class Single
    {
        private static Single _single;

        //Sınıf ait öylesine bir prop oluşuruyoruz
        public int Data { get; set; }
        private Single()
        {
            //constructor iptal edildi dışarıdan erişim yok artık
        }

        //constructor görevi görecek static method yazıyoruz


        public static Single CreateObject()
        {
            if (_single == null)
            {
                _single = new Single();
                return _single;
            }
            return _single;
        }
    }
}
