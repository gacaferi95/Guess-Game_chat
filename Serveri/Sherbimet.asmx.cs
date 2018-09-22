using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Serveri
{
    /// <summary>
    /// Summary description for Sherbimet
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Sherbimet : System.Web.Services.WebService
    {
        static string conneciton_stringu = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\TONI\Documents\databaza.mdf;Integrated Security=True;Connect Timeout=30";

        SqlConnection lidhja = new SqlConnection(conneciton_stringu);

        [WebMethod]
        public bool Regjistrohu(string emri, string mbiemri, string gjinia, string datelindja, string passwordi)
        {

            string query = "insert into Regjistro(Emri,Mbiemri,Gjinia,Datelindja,Fjalkalimi) values('" + emri + "','" + mbiemri + "','" + gjinia + "','" + datelindja + "','" + passwordi + "')";
            try
            {
                lidhja.Open();
                SqlCommand komanda = new SqlCommand(query, lidhja);
                komanda.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                lidhja.Close();
            }
        }

        [WebMethod]
        public DataSet Kyqu(string username, string password)
        {
            string Query = "Select * From Regjistro  Where Emri = '" + username + "' And Fjalkalimi = '" + password + "'";
            try
            {
                lidhja.Open();
                SqlDataAdapter objAdapteri = new SqlDataAdapter(Query, lidhja);
                DataSet shenimet = new DataSet();
                objAdapteri.Fill(shenimet);
                return shenimet;
            }
            finally
            {
                lidhja.Close();
            }
        }
        [WebMethod]
        public bool Rezultatet(string lojtari_1, string lojtar_2, float rezul_1, float rezul_2)
        {

            string query = "insert into Rezultatet(lojtari_1,lojtari_2,rez_1,rez_2) values('" + lojtari_1 + "','" + lojtar_2 + "'," + rezul_1 + "," + rezul_2 + ")";
            try
            {
                lidhja.Open();
                SqlCommand komanda = new SqlCommand(query, lidhja);
                komanda.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                lidhja.Close();
            }
        }
        [WebMethod]
        public DataSet Kush_ka_luajtur(string username)
        {
            string Query = "Select lojtari_1 From Rezultatet  Where lojtari_2 = '" + username + "'";
            try
            {
                lidhja.Open();
                SqlDataAdapter objAdapteri = new SqlDataAdapter(Query, lidhja);
                DataSet shenimet = new DataSet();
                objAdapteri.Fill(shenimet);
                return shenimet;
            }
            finally
            {
                lidhja.Close();
            }
        }
        [WebMethod]
        public bool update_rezultati(string lojtari_1, float rezul_2)
        {

            string query = "update Rezultatet set rez_2=" + rezul_2 + " where lojtari_1='" + lojtari_1 + "'";
            try
            {
                lidhja.Open();
                SqlCommand komanda = new SqlCommand(query, lidhja);
                komanda.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                lidhja.Close();
            }
        }
        [WebMethod]
        public DataSet selekto_Rezultatet(string username)
        {
            string Query = "Select lojtari_1,rez_1,lojtari_2,rez_2 From Rezultatet  Where rez_2>0 and (lojtari_1 = '" + username + "' or lojtari_2 = '" + username + "')";
            try
            {
                lidhja.Open();
                SqlDataAdapter objAdapteri = new SqlDataAdapter(Query, lidhja);
                DataSet shenimet = new DataSet();
                objAdapteri.Fill(shenimet);
                return shenimet;
            }
            finally
            {
                lidhja.Close();
            }
        }

    }
}
