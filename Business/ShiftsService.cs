using DataAccess;
using DataAccess.Models;
using System.Linq;

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

        public static int? GetShiftsByIdCount(int id)
        {
            return Repository.GetAllShifts().Where(x => x.PersonId == id).Count();
        }

        public List<Shifts>? GetShiftsByName(string name)
        {
            if (GetPersonIdByName(name) is { } id)
            {
                return Repository.GetAllShifts().Where(x => x.PersonId == id).ToList();
            }

            return null;
        }

        public List<RoleShiftCount> GetRolesAndShiftCountDescCountOrder()
        {
            return Repository.GetAllShifts()
                              .GroupBy(x => x.Role)
                              .Select(x => new RoleShiftCount { RoleName = x.Key, ShiftCount = x.Count() })
                              .OrderByDescending(x => x.ShiftCount)
                              .ToList();
    }

    public static List<string>? GetUniqueLocations()
    {
        return Repository.GetAllShifts()
                            .Select(x => x.Location)
                            .Distinct()
                            .ToList();
    }

        public List<Shifts>? GetShiftsStartsInDateRangeForActivePeople(DateTime startFirstDate, DateTime startLastDate)
        {
            List<People>? activePeople = GetAllActivePeople();

            if (activePeople != null)
            {
                return Repository.GetAllShifts()
                                .Where(x => activePeople.Any(p => p.Id == x.PersonId))
                                .Where(x => x.Start.Day >= startFirstDate.Day && x.Start.Day <= startLastDate.Day)
                                .ToList();
            }

            return null;
        }

    }
}
