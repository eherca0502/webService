using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace webService
{
    /// <summary>
    /// Descripción breve de ConsultaNorthwind
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ConsultaNorthwind : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }


        [WebMethod]
        public DataSet GetData()
        {
            //"Data Sourse=DESKTOP-KE2G5CS\\SQLEXPRESS;Initial Catalog=Nortwind;Persist Security Info=True;Integrated Security=SSPI";
            //@"Server=DESKTOP-KE2G5CS\SQLEXPRESS;Database=Nortwind;Integrated Security=True;"
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-KE2G5CS\\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = SSPI";
            SqlDataAdapter da = new SqlDataAdapter("Select * from customers",con); 
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
            
        }
    }
}
