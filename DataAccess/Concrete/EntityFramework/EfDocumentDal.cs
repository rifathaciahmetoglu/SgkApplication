using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDocumentDal : EfEntityRepositoryBase<Document, SgkContext>, IDocumentDal
    {
    }
}
