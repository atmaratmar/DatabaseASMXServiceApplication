using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DatabaseASMXServiceApplication
{
    /// <summary>
    /// Summary description for DataRetrievalService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DataRetrievalService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetStock(string ThreeLetterISO)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=ealdb1.eal.local;Database=EJL62_DB;User ID=ejl62_usr;Password=Baz1nga62";
            conn.Open();
            string query = "SELECT * FROM db_owner.Stock WHERE ISO='" + ThreeLetterISO + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            string returnStr = "";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read()) { 
                returnStr = "Name: " + reader[0] + "\nISO:" + reader[1]  + "\nValue:" + reader[2];
                }
            }
                conn.Close();
            return returnStr;
        }
    }
}
