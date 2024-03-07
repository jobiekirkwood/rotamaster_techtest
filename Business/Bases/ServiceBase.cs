using DataAccess;

namespace Business
{
    public class ServiceBase(Repository repository)
    {
        internal readonly Repository _repository = repository;

        internal int? GetPersonIdByName(string name)
        {
            return _repository.GetAllPeople().FirstOrDefault(x => x.Name == name).Id;
        }
    }

    
}
