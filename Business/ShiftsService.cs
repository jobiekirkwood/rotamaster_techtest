using DataAccess;

namespace Business
{
    public class ShiftsService(Repository repository) : ServiceBase(repository)
    {
        public int? GetShiftsByNameCount(string name)
        {
            if (GetPersonIdByName(name) is { } id)
            {
                return GetShiftsByIdCount(id);
            }

           return null;
           
        }

        public int? GetShiftsByIdCount(int id)
        {
            return _repository.GetAllShifts().Where(x => x.PersonId == id).Count();
        }
    }
}
