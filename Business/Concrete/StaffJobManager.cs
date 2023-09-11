using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class StaffJobManager : IStaffJobService
    {
        IStaffJobDal _staffJobDal;
        public StaffJobManager(IStaffJobDal staffJobDal)
        {
            _staffJobDal = staffJobDal;
        }

        [SecuredOperation("admin,moderator")]
        public IResult Add(StaffJob staffJob)
        {
            _staffJobDal.Add(staffJob);
            return new Result(true, Messages.StaffJobAdded);
        }

        [SecuredOperation("admin,moderator")]
        public IResult Delete(StaffJob staffJob)
        {
            _staffJobDal.Update(staffJob);
            return new Result(true, Messages.StaffJobDeleted);
        }

        [SecuredOperation("admin,moderator")]
        public IDataResult<List<StaffJob>> GetAll()
        {
            return new SuccessDataResult<List<StaffJob>>(_staffJobDal.GetAll(),Messages.StaffJobListed);
        }

        [SecuredOperation("admin,moderator")]
        public IDataResult<StaffJob> GetById(int id)
        {
            return new SuccessDataResult<StaffJob>(_staffJobDal.Get(s=>s.Id==id));
        }

        [SecuredOperation("admin,moderator")]
        public IResult Update(StaffJob staffJob)
        {
            _staffJobDal.Update(staffJob);
            return new Result(true, Messages.StaffJobUpdated);
        }
    }
}
