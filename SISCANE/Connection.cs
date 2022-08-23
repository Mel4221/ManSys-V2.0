using System;
using System.Net;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickTools; 

namespace SISCANE
{

    /// <summary>
    /// This Class give you asccess to the api that controls the connection string 
    /// </summary>
    public class ConnectionString
    {
        private string  connectionString = null;

        public string Connection()
        {
            return connectionString; 
        }
        public ConnectionString()
        {


            try
            {

                Console.Title = "Stablishing Connection With The Server...";
                string connection = null;
               
            
                string token = "i-am-allowed-to-have-access";
                string link = String.Format($"http://mbvapps.xyz/api/connect?user={Environment.UserName}&token={token}");



                WebRequest request = WebRequest.Create(link);
                request.Method = "GET";
                //  request.Headers["Token"] = "123-456-789";
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                HttpWebResponse responceObj = null;

                responceObj = (HttpWebResponse)request.GetResponse();
              //  request.Timeout = 5000;
                string result = null;
                using (Stream stream = responceObj.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);
                    result = reader.ReadToEnd();
                }
                // this is  a quick fix because is comming as a json format
                // and i just need the string 
                string newParser = "";
                connection = result.LastIndexOf("]") == result.Length - 1 || result.IndexOf("[") == 0 ? result.Substring(1, result.Length - 1) : result;

                Get.WaitTime(2000);

                connectionString = connection;
            
                
            
            }
            catch (Exception e)
            {

                Log.Event("ErrorException", e);
                Get.Alert("There was an error while trying to get in contact with The Server ");
             
                connectionString =  null;
            }

        }

    }
}
