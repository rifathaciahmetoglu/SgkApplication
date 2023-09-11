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
    public class ProfessionalPracticeTrainingManager : IProfessionalPracticeTrainingService
    {
        readonly IProfessionalPracticeTrainingDal _trainingDal;
        public ProfessionalPracticeTrainingManager(IProfessionalPracticeTrainingDal trainingDal)
        {
            _trainingDal = trainingDal; 
        }

        [SecuredOperation("admin,moderator")]
        public IResult Add(ProfessionalPracticeTraining practiceTraining)
        {
            _trainingDal.Add(practiceTraining);
            return new Result(true, Messages.TrainingAdded);
        }

        [SecuredOperation("admin,moderator")]
        public IResult Delete(ProfessionalPracticeTraining practiceTraining)
        {
            _trainingDal.Delete(practiceTraining);
            return new Result(true, Messages.TrainingDeleted);
        }

        [SecuredOperation("admin,moderator")]
        public IDataResult<List<ProfessionalPracticeTraining>> GetAll()
        {
            return new SuccessDataResult<List<ProfessionalPracticeTraining>>(_trainingDal.GetAll(),Messages.TrainingListed);    
        }

        [SecuredOperation("admin,moderator")]
        public IDataResult<ProfessionalPracticeTraining> GetById(int Id)
        {
            return new SuccessDataResult<ProfessionalPracticeTraining>(_trainingDal.Get(t => t.Id == Id));
        }

        [SecuredOperation("admin,moderator")]
        public IResult Update(ProfessionalPracticeTraining practiceTraining)
        {
            _trainingDal.Update(practiceTraining);
            return new Result(true, Messages.TrainingUpdated);
        }
    }
}
