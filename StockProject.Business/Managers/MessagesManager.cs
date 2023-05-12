using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProject.Business.Managers
{
   public class MessagesManager
    {
        public string Successful(string name, string crud)/* Başarılı Ekleme*/
        {
            string returnvalue = name + "" + crud + " Başarılı ";
            return returnvalue;

        }

        public string Unsuccessful(string name, string crud)/*Başarısız ekleme*/
        {
            string returnvalue = name + "" + crud + " Başarısız ";
            return returnvalue;
        }
        public string Incorrect()/*Hatalı Giriş*/
        {
            string returnvalue = " Hatalı Giriş ";
            return returnvalue;
        }

        public string ControlMail()/*Kontrol*/
        {
            string returnvalue = "Girmiş Olduğunuz Mail Adresi Kullanılmaktadır";
            return returnvalue;
        }

        public string NullBox()/*Kontrol*/
        {
            string NullBox = "Boş Alanları Doldurun";
            return NullBox;
        }

        public string PasswordControl()/*Kontrol*/
        {
            string NullBox = "Şifre Uyuşmazlığı";
            return NullBox;
        }

        public string CheckControl()/*Kontrol*/
        {
            string check = "Mail Adresi Blokeli";
            return check;
        }
    }
}
