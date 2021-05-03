using CPSConnectModel;
using System.Collections.Generic;
using System.IO;
using System.Net;
using CPSConnectService.Utility;
using CPSConnectService.Interfaces;
using System;

namespace CPSConnectService.Services
{
    public class CPSCalenderListService: ICPSCalenderListService
    {

        /// <summary>
        /// GetCalendesResult - Calls the extenal API and returns the response 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public IEnumerable<CalendarsResult> GetCalendesResult(string url)
        {
            var externalServiceData = GetData<IEnumerable<CalendarsResult>>(url);
            return externalServiceData;
        }
        /// <summary>
        /// Private method implements the Service call and JSON deserialization
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="apiURL"></param>
        /// <returns></returns>

        private T GetData<T>(string apiURL) where T : class
        {
            var content = string.Empty;
            try
            {
                //Initialize the web request from URL and set the method 
                var request = (HttpWebRequest)WebRequest.Create(apiURL);
                request.Method = "GET";
                //Get the response and read the contet as string
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (var stream = response?.GetResponseStream())
                        {
                            using (var sr = new StreamReader(stream))
                            {
                                content = sr.ReadToEnd();
                            }
                        } 
                    }
                }
            }
            catch(Exception ex)
            {
                string message = ex.Message;
                
            }
            //Deserialize the json string calling the extention method ToType defined in this project
            return content.ToType<T>();
        }


    }
}
