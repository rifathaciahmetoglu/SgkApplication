using Core.Utilities.Results;
using Entities;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IDocumentService
    {
        IResult Add(Document document);
        IResult Update(Document document);
        IResult Delete(Document document);
        IDataResult<List<Document>> GetAll();
    }
}
