using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class ProductService
    {
        public int CreateProduct(string name, decimal price)
        {
            //DB işlemleri burada gerçekleşiyor
            /*
             * 1. DB'ye bağlan
             * 2. INSERT sorgusu oluştur
             * 3. Sorguya parametre ekle
             * 4. Sorguyu çalıştır.
             * 
             */
            return 1;
        }
    }
}
