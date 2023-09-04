using Core.Utilities.Results;
using Entities;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IStaffService
    {
        IResult Add(Staff staff);
        IResult Update(Staff staff);
        IResult Delete(Staff staff);
        IDataResult<List<Staff>> GetAll();
        IDataResult<List<Staff>> GetById(int id);
    }
}
