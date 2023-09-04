using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStaffJobDal : EfEntityRepositoryBase<StaffJob, SgkContext>, IStaffJobDal
    {
    }
}
