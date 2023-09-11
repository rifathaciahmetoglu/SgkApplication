using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class NoteManager : INoteService
    {
        readonly INoteDal _noteDal;
        public NoteManager(INoteDal noteDal)
        {
            _noteDal = noteDal;
        }

        [SecuredOperation("admin,moderator")]
        public IResult Add(Note note)
        {
            _noteDal.Add(note);
            return new Result(true, Messages.NoteAdded);
        }

        public IResult Delete(Note note)
        {
            _noteDal.Delete(note);
            return new Result(true, Messages.NoteDeleted);
        }

        public IDataResult<List<Note>> GetAll()
        {
            return new SuccessDataResult<List<Note>>(_noteDal.GetAll(),Messages.NoteListed);
        }

        public IDataResult<List<Note>> GetByTopNotes(int Count)
        {
            return new SuccessDataResult<List<Note>>(_noteDal.GetAll().OrderByDescending(n=>n.Description).Take(Count).ToList(),Messages.FilterByTopNotes);
        }

        public IResult Update(Note note)
        {
            _noteDal.Update(note);
            return new Result(true, Messages.NoteUpdated);
        }
    }
}
