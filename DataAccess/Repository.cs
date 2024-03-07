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
                return JsonConvert.DeserializeObject<List<T>>(json);
            }

            return new List<T>();
        }

        private static string GetLocation(string fileName) => Path.Combine(Environment.CurrentDirectory, "Data", fileName);

        public List<People> GetAllPeople()
        {
            return GetAll<People>("people.json");
        }

        public List<Shifts> GetAllShifts()
        {
            return GetAll<Shifts>("shifts.json");
        }
    }
}
