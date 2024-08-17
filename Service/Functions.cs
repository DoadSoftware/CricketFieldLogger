using CricketFieldLogger.Helper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketFieldLogger.Service
{
    public class Functions
    {
        public static T DeserializeToObject<T>(string filepath) where T : class
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(File.ReadAllText(filepath));

            }
            catch (System.Text.Json.JsonException ex) when (ex is IOException || ex is InvalidOperationException || ex is NullReferenceException || ex is ArgumentOutOfRangeException)
            {
                System.Diagnostics.Debug.WriteLine("Message = " + ex.Message);
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        public static List<T> DeserializeToArray<T>(string filepath) where T : class
        {
            try
            {
                return JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(filepath));
                 //JsonConvert.DeserializeObject<T>(File.ReadAllText(filepath));

            }
            catch (System.Text.Json.JsonException ex) when (ex is IOException || ex is InvalidOperationException || ex is NullReferenceException || ex is ArgumentOutOfRangeException)
            {
                System.Diagnostics.Debug.WriteLine("Message = " + ex.Message);
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        
    }
}
