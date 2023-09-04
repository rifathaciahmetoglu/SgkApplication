using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ContractManager : IContractService
    {
        readonly IContractDal _contractDal;
        public ContractManager(IContractDal contractDal)
        {
            _contractDal = contractDal;
        }
        public IResult Add(Contract contract)
        {
            _contractDal.Add(contract);
            return new Result(true, Messages.ContractAdded);
        }
        public IResult Update(Contract contract)
        {
            _contractDal.Update(contract);
            return new Result(true, Messages.ContractUpdated);
        }

        public IResult Delete(Contract contract)
        {
            _contractDal.Delete(contract);
            return new Result(true, Messages.ContractDeleted);
        }

        public IDataResult<List<Contract>> GetAll()
        {
            return new SuccessDataResult<List<Contract>>(_contractDal.GetAll(), Messages.ContractListed);
        }

        public IDataResult<Contract> GetById(int id)
        {
            return new SuccessDataResult<Contract>(_contractDal.Get(c => c.Id == c.Id));
        }

    }
}
