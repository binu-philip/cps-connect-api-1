using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSConnectService.Utility
{
    public static class Extensions
    {
        /// <summary>
        /// ToType- Deserialize the json string to object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        public static T ToType<T>(this string jsonString)
        {
            return JsonConvert.DeserializeObject<T>(jsonString,
                new JsonSerializerSettings
                {
                    Error = delegate (Object sender, ErrorEventArgs args)
                    {
                        args.ErrorContext.Handled = true;
                    }
                });
        }

    }
}
