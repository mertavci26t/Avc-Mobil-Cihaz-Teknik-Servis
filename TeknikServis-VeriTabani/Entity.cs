using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServis_VeriTabani
{
    public  class musteri {

        public Guid ID{ get; set; }
        public string mus_ad { get; set; }
        public string mus_soyad { get; set; }
        public string mus_tel { get; set; }
        public string mus_mail { get; set; }
        public string mus_adres { get; set; }

        public override string ToString()
        {
            return $"{mus_ad} {mus_soyad}";
        }
    }

    public class calisanlar {
        public Guid ID { get; set; }
        public string cal_ad { get; set; }
        public string cal_soyad { get; set; }
        public string cal_tel { get; set; }
        public string cal_mail { get; set; }
        public string cal_adres { get; set; }

        public override string ToString()
        {
            return $"{cal_ad} {cal_soyad}";
        }
    }

    public class marka {
        public Guid ID{ get; set; }
        public string mar_ismi{ get; set; }

        public override string ToString()
        {
            return $"{mar_ismi}";
        }
    }

    public class tamirtalep {
        public Guid ID { get; set; }

        //musteri guid
        public Guid musteriID { get; set; }
        public string tm_model { get; set; }    
        public string  tm_islem { get; set; }

        public DateTime tm_tarih { get; set; }

        public override string ToString()
        {
            return $"{ID}";
        }

    }

    public class tamirislem
    {
        public Guid ID { get; set; } 

        public Guid tamirtalepID { get; set;}

        public double tmi_fiyat { get; set; }
        public DateTime tmi_tarih { get; set; }
        public string tmi_islem { get; set; }



        public override string ToString()
        {
            return $"{ID}";
        }
    }
    
    
    
    
    
    public class teslimet1
    {
        public Guid ID { get; set; }

        public Guid tamirislemID { get; set; }

        public Guid musteriID { get; set; }

        public double teslimet_fiyat { get; set; }
        public DateTime teslimet_tarih { get; set; }
        public string teslimet_odemeturu { get; set; }
        public string tmi_islem { get; set; }
        public Guid tamirtalepID { get; set; }
        public override string ToString()
        {
            return $"{ID}";
        }
    }
}
