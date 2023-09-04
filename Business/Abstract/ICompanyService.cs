using Core.Utilities.Results;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        IResult Add(Company company);
        IResult Update(Company company);
        IResult Delete(Company company);
        IDataResult<List<Company>> GetList();
        IDataResult<Company> GetById(int id);
        IDataResult<List<Company>> GetByShortName(string shortName);
    }
}
