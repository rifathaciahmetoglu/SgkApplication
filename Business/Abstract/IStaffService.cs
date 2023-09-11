using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStaffService
    {
        IResult Add(Staff staff);
        IResult Update(Staff staff);
        IResult Delete(Staff staff);
        IDataResult<List<Staff>> GetAll();
        IDataResult<Staff> GetById(int id);
    }
}
