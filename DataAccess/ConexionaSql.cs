using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using QuickTools; 
using System.Data.SqlClient;

namespace DataAccess
{
    public  class ConectionString
    {
        
        private readonly string connectionString;
        public string Connection()
        {
            return connectionString; 
        }
        public ConectionString() {
            string connection = null;
            string token = "i-am-allowed-to-have-access"; 
            string link = String.Format($"http://mbvapps.xyz/api/connect?user={Environment.UserName}&token={token}");


            WebRequest request = WebRequest.Create(link);
            request.Method = "GET";
            //  request.Headers["Token"] = "123-456-789";
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            HttpWebResponse responceObj = null;

            responceObj = (HttpWebResponse)request.GetResponse();
            request.Timeout = 5000;
            string result = null;
            using (Stream stream = responceObj.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream);
                result = reader.ReadToEnd();
            }
            // this is  a quick fix because is comming as a json format
            // and i just need the string 

            connection = result;//.Substring(0, result.Length+1);
         //   Get.Input(connection); 
            connectionString = connection; 


        }
        public ConectionString(string fullApi)
        {
            string connection = null;
            // string token = "i-am-allowed-to-have-access";
            string link = String.Format($"{fullApi}");


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
        public ConectionString(string user,string token)
        {
            string connection = null;
           // string token = "i-am-allowed-to-have-access";
            string link = String.Format($"http://mbvapps.xyz/api/connect?user={user}&token={token}");


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

        public ConectionString(string api,string user, string token)
        {
            string connection = null;
             /// be carefull with those link in string it can cose problems 
            string link = String.Format($"http://mbvapps.xyz/api/connect?user={user}&token={token}");


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


    }
}
