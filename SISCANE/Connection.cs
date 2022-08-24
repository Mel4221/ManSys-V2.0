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
    /// This Class allow you to temporally cache in memory some datas
    /// </summary>
    public  class Cache
    {

        /// <summary>
        /// Specify if a data has been cached 
        /// </summary>
        static public bool IsCached = false;
        /// <summary>
        /// set the data that has to be cached 
        /// </summary>
        static public string Data = null;

        /// <summary>
        /// Cache Data into a list
        /// </summary>
        public static List<string> DataList = new List<string>();  

        /// <summary>
        /// This Allow modification on hwo the data is cached and if is cached or not 
        /// </summary>
        public virtual void Controller()
        { 
        
        }
        
    }
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
                if (Cache.IsCached == false)
                {
                    Console.Title = "Stablishing Connection With The Online API";
                    string connection = null;


                    string token = "i-am-allowed-to-have-access";
                    string link = String.Format($"http://mbvapps.xyz/api/connect?user={Environment.UserName}&token={token}");



                    WebRequest request = WebRequest.Create(link);
                    request.Method = "GET";
                    //  request.Headers["Token"] = "123-456-789";
                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                    HttpWebResponse responceObj = null;

                    responceObj = (HttpWebResponse)request.GetResponse();
                    request.Timeout = (System.Int32)TimeSpan.FromSeconds(10).TotalMilliseconds; 
                    string result = null;
                    using (Stream stream = responceObj.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(stream);
                        result = reader.ReadToEnd();
                    }
                    // this is  a quick fix because is comming as a json format
                    // and i just need the string 
                     
                    connection = result.LastIndexOf("]") == result.Length - 1 || result.IndexOf("[") == 0 ? result.Substring(1, result.Length - 1) : result;

                    Get.WaitTime(2000);

                    connectionString = connection;

                    Cache.IsCached = true;
                    Cache.Data = connectionString; 
                    return;
                }
                if (Cache.IsCached == true) {
                    connectionString = Cache.Data; 
                
                }


            }
            catch (Exception e)
            {

                Log.Event("API", e);
                Get.Yellow("There was an error while trying to get in contact with The Server ");
             
                connectionString =  null;
            }

        }

    }
}
