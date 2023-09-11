using Business.Abstract;
using Business.BusinessAspects.Autofac;
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


        [SecuredOperation("admin,moderator")]
        public IResult Add(Contract contract)
        {
            _contractDal.Add(contract);
            return new Result(true, Messages.ContractAdded);
        }

        [SecuredOperation("admin,moderator")]
        public IResult Update(Contract contract)
        {
            _contractDal.Update(contract);
            return new Result(true, Messages.ContractUpdated);
        }


        [SecuredOperation("admin,moderator")]
        public IResult Delete(Contract contract)
        {
            _contractDal.Delete(contract);
            return new Result(true, Messages.ContractDeleted);
        }


        [SecuredOperation("admin,moderator")]
        public IDataResult<List<Contract>> GetAll()
        {
            return new SuccessDataResult<List<Contract>>(_contractDal.GetAll(), Messages.ContractListed);
        }


        [SecuredOperation("admin,moderator")]
        public IDataResult<Contract> GetById(int id)
        {
            return new SuccessDataResult<Contract>(_contractDal.Get(c => c.Id == c.Id));
        }

    }
}
