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
    public class StaffEducationsManager : IStaffEducationsService
    {
        IStaffEducationsDal _staffEducationsDal;
        public StaffEducationsManager(IStaffEducationsDal educationsDal)
        {
            _staffEducationsDal = educationsDal;
        }

        [SecuredOperation("admin,moderator,member")]
        public IResult Add(StaffEducations staffEducations)
        {
            _staffEducationsDal.Add(staffEducations);
            return new Result(true, Messages.EducationAdded);
        }

        [SecuredOperation("admin,moderator,member")]
        public IResult Update(StaffEducations staffEducations)
        {
            _staffEducationsDal.Update(staffEducations);
            return new Result(true, Messages.EducationUpdated);
        }

        [SecuredOperation("admin,moderator")]
        public IResult Delete(StaffEducations staffEducations)
        {
            _staffEducationsDal.Delete(staffEducations);
            return new Result(true, Messages.EducatinDeleted);
        }

        [SecuredOperation("admin,moderator,member")]
        public IDataResult<List<StaffEducations>> GetAll()
        {
            return new SuccessDataResult<List<StaffEducations>>(_staffEducationsDal.GetAll(),Messages.EducationListed);
        }

        [SecuredOperation("admin,moderator,member")]
        public IDataResult<StaffEducations> GetById(int id)
        {
            return new SuccessDataResult<StaffEducations>(_staffEducationsDal.Get(s=>s.Id== id));
        }


    }
}
