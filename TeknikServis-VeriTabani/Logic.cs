using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknikServis_VeriTabani
{
    public static class Logic
    {

        public static bool musekle(musteri a)
        {
            try {
                int snc = DataLayer.musekle(a);

                return (snc > 0);
            }
            catch (Exception e)
            {
                return false;
            }
           
        }

        internal static DataSet musterigor(string v)
        {
            try
            {
                DataSet mg = DataLayer.musterigor(v);

                return mg;
            }
            catch (Exception)
            {
                return null;
            
            }

            
        }
    
        internal static bool musguncelle(musteri a) {

            try
            {
                int snc = DataLayer.musguncelle(a);

                return (snc > 0);
            }
            catch (Exception e)
            {
                return false;
            }



        }

        internal static bool musterisil(string id)

        {
            try
            {
                int snc = DataLayer.musterisil(id);

                return (snc > 0);
            }
            catch (Exception e)
            {
                return false;
            }


        }


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///

        public static bool calekle(calisanlar a)
        {
            try
            {
                int snc = DataLayer.calekle(a);

                return (snc > 0);
            }
            catch (Exception e)
            {
                return false;
            }

        }

        internal static DataSet calgor(string v)
        {
            try
            {
                DataSet mg = DataLayer.calgor(v);

                return mg;
            }
            catch (Exception)
            {
                return null;

            }


        }

        internal static bool calguncelle(calisanlar a)
        {

            try
            {
                int snc = DataLayer.calguncelle(a);

                return (snc > 0);
            }
            catch (Exception e)
            {
                return false;
            }



        }

        internal static bool calsil(string id)

        {
            try
            {
                int snc = DataLayer.calsil(id);

                return (snc > 0);
            }
            catch (Exception e)
            {
                return false;
            }


        }

        internal static bool ttalepekle(tamirtalep s)
        {
            try
            {
                int snc = DataLayer.ttalepekle(s);
                

                return (snc > 0);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        internal static bool tamirtalepsil(string id)
        {
            try
            {
                int snc = DataLayer.tamirtalepsil(id);

                return (snc > 0);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        internal static DataSet teslimetlerigor(string v)
        {
            try
            {
                DataSet tg = DataLayer.teslimetlerigor(v);

                return tg;
            }
            catch (Exception)
            {
                return null;

            }
        }




        internal static bool tiekle(tamirislem s)
        {
            try
            {
                int snc = DataLayer.tiekle(s);


                return (snc > 0);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        internal static DataSet talepislemgor(string text)
        {

            try
            {
                DataSet tg = DataLayer.talepislemgor(text);

                return tg;
            }
            catch (Exception)
            {
                return null;

            }
        }

        internal static bool talisil(string id)
        {
            try
            {
                int snc = DataLayer.talisil(id);

                return (snc > 0);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        internal static bool teslimetlg(teslimet1 teslimet1)
        {
            try
            {
                int snc = DataLayer.teslimets(teslimet1);

                return (snc > 0);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        internal static DataSet taleplerigor(string text)
        {
            try
            {
                DataSet tg = DataLayer.taleplerigor(text);

                return tg;
            }
            catch (Exception)
            {
                return null;

            }
        }
    }
}
