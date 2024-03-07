using DataAccess;
using DataAccess.Models;

namespace Business
{
    public class ServiceBase(Repository repository)
    {
        internal readonly Repository _repository = repository;

        internal static int? GetPersonIdByName(string name)
        {
            return Repository.GetAllPeople().FirstOrDefault(x => x.Name == name)?.Id;
        }

        internal static List<People>? GetAllActivePeople()
        {
            return Repository.GetAllPeople().Where(x => x.Active).ToList();
        }
    }

    
}
