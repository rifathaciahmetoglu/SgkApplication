using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProfessionalPracticeTrainingService
    {
        IResult Add(ProfessionalPracticeTraining practiceTraining);
        IResult Update(ProfessionalPracticeTraining practiceTraining);
        IResult Delete(ProfessionalPracticeTraining practiceTraining);
        IDataResult<List<ProfessionalPracticeTraining>> GetAll();
        IDataResult<List<ProfessionalPracticeTraining>> GetById(int Id);
    }
}
