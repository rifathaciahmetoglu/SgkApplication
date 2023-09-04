using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class CompanyManager : ICompanyService
    {
        readonly ICompanyDal _companyDal;
        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        [ValidationAspect(typeof(CompanyValidator))]
        public IResult Add(Company company)
        {
            IResult? result = BusinessRules.Run(CheckIfCompanyNameExists(company.Name),
                CheckIfCompanyShortNameExists(company.ShortName));

            if (result != null)
            {
                return result;
            }
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
        private IResult CheckIfCompanyNameExists(string companyName)
        {
            var result = _companyDal.GetAll(c => c.Name == companyName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CompanyNameAlreadyExists);
            }
            return new SuccessResult();
        }
        private IResult CheckIfCompanyShortNameExists(string shortName)
        {
            var result = _companyDal.GetAll(c => c.ShortName == shortName).Any();
            if (result)
            {
                return new ErrorResult(Messages.CompanyShortNameAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
