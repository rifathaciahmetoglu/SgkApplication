using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStaffEducationsService
    {
        IResult Add(StaffEducations staffEducations);
        IResult Update(StaffEducations staffEducations);
        IResult Delete(StaffEducations staffEducations);
        IDataResult<List<StaffEducations>> GetAll();
        IDataResult<StaffEducations> GetById(int id);
    }
}
