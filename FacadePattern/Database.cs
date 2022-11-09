using System.Collections.Generic;
using System.IO;

namespace FacadePattern
{
    public static class Database
    {
        public static Dictionary<string, string> GetProperties(string dbname)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            foreach (string v in File.ReadAllLines(dbname))
            {
                string[] arr = v.Split('=');
                result.Add(arr[0], arr[1]);
            }

            return result;
        }
    }
}
