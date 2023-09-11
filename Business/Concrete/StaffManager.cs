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
    public class StaffManager : IStaffService
    {
        IStaffDal _staffDal;
        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        [SecuredOperation("admin,moderator,member")]
        public IResult Add(Staff staff)
        {
            _staffDal.Add(staff);
            return new Result(true, Messages.StaffAdded);
        }

        [SecuredOperation("admin,moderator")]
        public IResult Delete(Staff staff)
        {
            _staffDal.Delete(staff);
            return new Result(true, Messages.StaffDeleted);
        }

        [SecuredOperation("admin,moderator")]
        public IDataResult<List<Staff>> GetAll()
        {
            return new SuccessDataResult<List<Staff>>(_staffDal.GetAll(), Messages.StaffListed);
        }

        [SecuredOperation("admin,moderator,member")]
        public IDataResult<Staff> GetById(int id)
        {
            return new SuccessDataResult<Staff>(_staffDal.Get(s=>s.Id==id));
        }

        [SecuredOperation("admin,moderator,member")]
        public IResult Update(Staff staff)
        {
            _staffDal.Update(staff);
            return new Result(true, Messages.StaffUpdated);
        }
    }
}
