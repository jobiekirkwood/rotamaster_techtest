using DataAccess.Models;
using Newtonsoft.Json;

namespace DataAccess
{
    public class Repository
    {
        private static List<T> GetAll<T>(string fileName)
        {
            string fileLocation = GetLocation(fileName);

            if (File.Exists(fileLocation))
            {
                string json = File.ReadAllText(fileLocation);
                try
                {
                    return JsonConvert.DeserializeObject<List<T>>(json);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message, e.InnerException);
                    return new List<T>();
                }

            }

            return new List<T>();
        }

        private static string GetLocation(string fileName) => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", fileName);

        public static List<People> GetAllPeople()
        {
            return GetAll<People>("people.json");
        }

        public static List<Shifts> GetAllShifts()
        {
            return GetAll<Shifts>("shifts.json");
        }
    }
}
