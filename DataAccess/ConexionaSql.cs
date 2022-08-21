using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net; 
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConexionaSql
    {
        private readonly string connectionString;
        public ConexionaSql() {
            string connection = null;
           
            string link = String.Format($"http://mbvapps.xyz/app/api/Worker?user={Environment.UserName}&token=F%5E)Enurc)%5E0A%26%2B)aeW5%3F%26!(!1%2Bm(1%3FnZ");



            WebRequest request = WebRequest.Create(link);
            request.Method = "GET";
            //  request.Headers["Token"] = "123-456-789";
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            HttpWebResponse responceObj = null;

            responceObj = (HttpWebResponse)request.GetResponse();
            request.Timeout = 1;
            string result = null;
            using (Stream stream = responceObj.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream);
                result = reader.ReadToEnd();
            }
            // this is  a quick fix because is comming as a json format
            // and i just need the string 

            connection = result.Substring(2, result.Length - 4);
            connectionString = connection; 


        }
        protected SqlConnection GetConnection(){
            return new SqlConnection(connectionString);
        }
    }
}
