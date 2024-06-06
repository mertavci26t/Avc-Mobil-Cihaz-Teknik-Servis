using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace TeknikServis_VeriTabani
{
    public static class DataLayer
{

        /* "server=127.0.0.1;datebase=teknikservis;uid=root;password=alieren" */


        static MySqlConnection baglanti = new MySqlConnection(

      new MySqlConnectionStringBuilder()
      {

          Server = "127.0.0.1"  , Database = "avciteknikservis", UserID = "root", Password = "12345",

      }.ConnectionString
      ); 

    public static int musekle(musteri a) {

            try {
            
                if (baglanti.State != System.Data.ConnectionState.Open) 
                    baglanti.Open();
                
                MySqlCommand eklekomut = new MySqlCommand("musteriekle",baglanti);
                eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                eklekomut.Parameters.AddWithValue("@id", a.ID);
                eklekomut.Parameters.AddWithValue("@ad", a.mus_ad);
                eklekomut.Parameters.AddWithValue("@soyad", a.mus_soyad);
                eklekomut.Parameters.AddWithValue("@tel", a.mus_tel);
                eklekomut.Parameters.AddWithValue("@mail", a.mus_mail);
                eklekomut.Parameters.AddWithValue("@adres", a.mus_adres);

                int snc = eklekomut.ExecuteNonQuery();  
            }
            catch (Exception e){
               return -1;   
            }
            finally {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }



            return -1;
        
        }


        public static DataSet musterigor(string v)
        {

            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand eklekomut;
                if (string.IsNullOrEmpty(v))
                {
                    eklekomut = new MySqlCommand("musterigor", baglanti);
                    eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else {

                    eklekomut = new MySqlCommand("musteribul", baglanti);
                    eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                    eklekomut.Parameters.AddWithValue("@v", v);
                }
                DataSet dataset = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(eklekomut);
                adp.Fill(dataset);

                return dataset;
            }

          
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }


        }

        internal static int musguncelle(musteri a)
        {

            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand eklekomut = new MySqlCommand("musteriguncelle", baglanti);
                eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                eklekomut.Parameters.AddWithValue("@id", a.ID);
                eklekomut.Parameters.AddWithValue("@ad", a.mus_ad);
                eklekomut.Parameters.AddWithValue("@soyad", a.mus_soyad);
                eklekomut.Parameters.AddWithValue("@tel", a.mus_tel);
                eklekomut.Parameters.AddWithValue("@mail", a.mus_mail);
                eklekomut.Parameters.AddWithValue("@adres", a.mus_adres);

                int snc = eklekomut.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }



            return -1;

        }

        internal static int musterisil(string id)
        {

            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand eklekomut = new MySqlCommand("musterisil", baglanti);
                eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                eklekomut.Parameters.AddWithValue("@id", id);

                int snc = eklekomut.ExecuteNonQuery();
                return snc; 
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }

           

        }


        //////////////////////////////////////calısanlar///////////////////////////////////////////////////////////
        ///

        public static int calekle(calisanlar a)
        {

            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand eklekomut = new MySqlCommand("calekle", baglanti);
                eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                eklekomut.Parameters.AddWithValue("@id", a.ID);
                eklekomut.Parameters.AddWithValue("@ad", a.cal_ad);
                eklekomut.Parameters.AddWithValue("@soyad", a.cal_soyad);
                eklekomut.Parameters.AddWithValue("@tel", a.cal_tel);
                eklekomut.Parameters.AddWithValue("@mail", a.cal_mail);
                eklekomut.Parameters.AddWithValue("@adres", a.cal_adres);

                int snc = eklekomut.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }



            return -1;

        }


        public static DataSet calgor(string v)
        {

            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand eklekomut;
                if (string.IsNullOrEmpty(v))
                {
                    eklekomut = new MySqlCommand("calgor", baglanti);
                    eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {

                    eklekomut = new MySqlCommand("calbul", baglanti);
                    eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                    eklekomut.Parameters.AddWithValue("@v", v);
                }
                DataSet dataset = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(eklekomut);
                adp.Fill(dataset);

                return dataset;
            }


            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }


        }

        internal static int calguncelle(calisanlar a)
        {

            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand eklekomut = new MySqlCommand("calguncelle", baglanti);
                eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                eklekomut.Parameters.AddWithValue("@id", a.ID);
                eklekomut.Parameters.AddWithValue("@ad", a.cal_ad);
                eklekomut.Parameters.AddWithValue("@soyad", a.cal_soyad);
                eklekomut.Parameters.AddWithValue("@tel", a.cal_tel);
                eklekomut.Parameters.AddWithValue("@mail", a.cal_mail);
                eklekomut.Parameters.AddWithValue("@adres", a.cal_adres);

                int snc = eklekomut.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }



            return -1;

        }

        internal static int calsil(string id)
        {

            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand eklekomut = new MySqlCommand("calsil", baglanti);
                eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                eklekomut.Parameters.AddWithValue("@id", id);

                int snc = eklekomut.ExecuteNonQuery();
                return snc;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }



        }

        internal static int ttalepekle(tamirtalep s)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand eklekomut1 = new MySqlCommand("ekleme", baglanti);
                eklekomut1.CommandType = System.Data.CommandType.StoredProcedure;
                eklekomut1.Parameters.AddWithValue("@tm2_id", s.ID);
                eklekomut1.Parameters.AddWithValue("@mus2_id", s.musteriID);
                eklekomut1.Parameters.AddWithValue("@tm2_model",s.tm_model);
                eklekomut1.Parameters.AddWithValue("@tm2_islem",s.tm_islem);
                eklekomut1.Parameters.AddWithValue("@tm2_tarih", s.tm_tarih);

                int snc = eklekomut1.ExecuteNonQuery();
                Console.WriteLine(snc);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }



            return -1;
        }

        internal static int tamirtalepsil(string id)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand eklekomut = new MySqlCommand("tamirtalepsil", baglanti);
                eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                eklekomut.Parameters.AddWithValue("@id", id);

                int snc = eklekomut.ExecuteNonQuery();
                return snc;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }

        }

        internal static DataSet taleplerigor(string v)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand eklekomut;
                if (string.IsNullOrEmpty(v))
                {
                    eklekomut = new MySqlCommand("talepgor", baglanti);
                    eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {

                    eklekomut = new MySqlCommand("talepbul", baglanti);
                    eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                    eklekomut.Parameters.AddWithValue("@v", v);
                }
                DataSet dataset = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(eklekomut);
                adp.Fill(dataset);

                return dataset;
            }


            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }

        }




        internal static int tiekle(tamirislem s)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand eklekomut1 = new MySqlCommand("tmiekleme", baglanti);
                eklekomut1.CommandType = System.Data.CommandType.StoredProcedure;
                eklekomut1.Parameters.AddWithValue("@tmi_id", s.ID);
                eklekomut1.Parameters.AddWithValue("@tm_id", s.tamirtalepID);
                eklekomut1.Parameters.AddWithValue("@tmi_tarih", s.tmi_tarih);
                eklekomut1.Parameters.AddWithValue("@tmi_islem", s.tmi_islem);
                eklekomut1.Parameters.AddWithValue("@tmi_fiyat", s.tmi_fiyat);

                int snc = eklekomut1.ExecuteNonQuery();
                Console.WriteLine(snc);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }



            return -1;
        }

        internal static DataSet talepislemgor(string text)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand eklekomut;
                if (string.IsNullOrEmpty(text))
                {
                    eklekomut = new MySqlCommand("tigors", baglanti);
                    eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {

                    eklekomut = new MySqlCommand("tigor", baglanti);
                    eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                    eklekomut.Parameters.AddWithValue("@v", text);
                }
                DataSet dataset = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(eklekomut);
                adp.Fill(dataset);

                return dataset;
            }


            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }

        }

        internal static int talisil(string id)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand eklekomut = new MySqlCommand("talisil", baglanti);
                eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                eklekomut.Parameters.AddWithValue("@id", id);

                int snc = eklekomut.ExecuteNonQuery();
                return snc;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }
        }

        internal static int teslimets(teslimet1 teslimet1)
        {

            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand eklekomut = new MySqlCommand("teslimetekle", baglanti);
                eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                eklekomut.Parameters.AddWithValue("@teslimet_id", teslimet1.ID);
                eklekomut.Parameters.AddWithValue("@tmi_id", teslimet1.tamirislemID);
                eklekomut.Parameters.AddWithValue("@mus_id", teslimet1.musteriID);
                eklekomut.Parameters.AddWithValue("@teslimet_fiyat", teslimet1.teslimet_fiyat);
                eklekomut.Parameters.AddWithValue("@teslimet_tarih", teslimet1.teslimet_tarih);
                eklekomut.Parameters.AddWithValue("@teslimet_odemeturu", teslimet1.teslimet_odemeturu);
                eklekomut.Parameters.AddWithValue("@tmi_islem", teslimet1.tmi_islem);



        
                int snc = eklekomut.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }



            return -1;


        }

        internal static DataSet teslimetlerigor(string v)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand eklekomut;
                if (string.IsNullOrEmpty(v))
                {
                    eklekomut = new MySqlCommand("teslimgor", baglanti);
                    eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {

                    eklekomut = new MySqlCommand("teslimbul", baglanti);
                    eklekomut.CommandType = System.Data.CommandType.StoredProcedure;
                    eklekomut.Parameters.AddWithValue("@v", v);
                }
                DataSet dataset = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(eklekomut);
                adp.Fill(dataset);

                return dataset;
            }


            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }

        }
    }

}
