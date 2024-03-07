using DataAccess;

namespace Business
{
    public class PeopleService(Repository repository) : ServiceBase(repository)
    {
    }

}
