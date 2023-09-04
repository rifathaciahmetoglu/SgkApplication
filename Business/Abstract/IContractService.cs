using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IContractService
    {
        IResult Add(Contract contract);
        IResult Update(Contract contract);
        IResult Delete(Contract contract);
        IDataResult<List<Contract>> GetAll();
        IDataResult<Contract> GetById(int id);
    }
}
