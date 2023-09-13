using Common.Core.Services.Contracts;
using Common.Core.ViewModels;
using Common.Data.Context;
using Common.Data.Models;
using Common.Data.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Common.Core.Services
{
    public interface IVehicleService
    {
        DriverDataTableResultModel GetDataTable(DriverDataTableModel model);

    }
    public class VehicleService : IVehicleService
    {
        private readonly IGenericRepository<Users> _repository;
        private readonly LogisticContext _dbcontext;
        private readonly IContextHelper _contextHelper;

        public VehicleService(IGenericRepository<Users> repository, LogisticContext dbcontext, IContextHelper contextHelper)
        {
            _repository = repository;
            _dbcontext = dbcontext;
            _contextHelper = contextHelper;
        }

        public DriverDataTableResultModel GetDataTable(DriverDataTableModel model)
        {
            int recordsTotal = 0;
            var list = (from x in _dbcontext.DriverMaster select x).AsQueryable();

            if (!string.IsNullOrWhiteSpace(model.Id))
            {
                list = list.Where(x => (x.Id + "").Contains(model.Id));
            }
            if (!string.IsNullOrWhiteSpace(model.FirstName))
            {
                list = list.Where(x => (x.FirstName + "").Contains(model.FirstName));
            }

            if (DateTime.TryParse(model.CreatedOn.ToString(), out DateTime createdOn))
            {
                list = list.Where(o => o.CreatedOn.HasValue && o.CreatedOn.Value.Date == createdOn.Date);
            }

            recordsTotal = list.Count();
            var data = list.Skip(model.skip).ToList();
            var result = new DriverDataTableResultModel { draw = model.draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data };
            return result;
        }

    }
}
