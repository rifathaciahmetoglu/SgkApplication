using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        readonly ICompanyDal _companyDal;
        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public IResult Add(Company company)
        {  
            _companyDal.Add(company);
            return new Result(true, Messages.CompanyAdded);
        }
        public IResult Update(Company company)
        {
            _companyDal.Update(company);
            return new Result(true, Messages.CompanyUpdated);
        }

        public IResult Delete(Company company)
        {
            _companyDal.Delete(company);
            return new Result(true, Messages.CompanyDeleted);
        }

        public IDataResult<List<Company>> GetList()
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetAll(), Messages.CompanyListed);
        }

        public IDataResult<Company> GetById(int id)
        {
            return new SuccessDataResult<Company>(_companyDal.Get(c => c.Id == id));
        }

        public IDataResult<List<Company>> GetByShortName(string shortName)
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetAll(c => c.ShortName == shortName));
        }

    }
}
