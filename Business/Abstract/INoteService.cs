using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface INoteService
    {
        IResult Add(Note note);
        IResult Update(Note note);
        IResult Delete(Note note);
        IDataResult<List<Note>> GetAll();
        IDataResult<List<Note>> GetByTopNotes(int Count);
    }
}
