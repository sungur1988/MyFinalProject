using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintanceTime = "Bakım nedeniyle istediğiniz işlemi gerçekleştiremiyoruz";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 adet ürün bulunabilir";
        public static string SameProductName="Aynı isimde ürün var";
        public static string CategoryLimitExceded="";
        public static string AuthorizationDenied= "Yetkiniz yok";
    }
}
