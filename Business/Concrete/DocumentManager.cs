using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class DocumentManager : IDocumentService
    {
        readonly IDocumentDal _documentDal;
        public DocumentManager(IDocumentDal documentDal)
        {
            _documentDal = documentDal;
        }

        [SecuredOperation("admin,moderator")]
        public IResult Add(Document document)
        {
            _documentDal.Add(document);
            return new Result(true, Messages.DocumentAdded);
        }

        [SecuredOperation("admin,moderator")]
        public IResult Update(Document document)
        {
            _documentDal.Update(document);
            return new Result(true, Messages.DocumentUpdated);
        }

        [SecuredOperation("admin,moderator")]
        public IResult Delete(Document document)
        {
            _documentDal.Delete(document);
            return new Result(true, Messages.DocumentDeleted);
        }

        [SecuredOperation("admin,moderator")]
        public IDataResult<List<Document>> GetAll()
        {
            return new SuccessDataResult<List<Document>>(_documentDal.GetAll(), Messages.DocumentListed);
        }

    }
}
