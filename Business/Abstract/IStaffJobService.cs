using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStaffJobService
    {
        IResult Add(StaffJob staffJob);
        IResult Update(StaffJob staffJob);
        IResult Delete(StaffJob staffJob);
        IDataResult<List<StaffJob>> GetAll();
        IDataResult<List<StaffJob>> GetById(int id);
    }
}
