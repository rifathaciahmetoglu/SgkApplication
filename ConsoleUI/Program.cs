using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities;

namespace ConsoleUI
{
    class Program
    {
        static void Main()
        {
        }
        #region Company
        public static void CompanyAdd(string name, string shortName, bool status)
        {
            CompanyManager companyManager = new(new EfCompanyDal());
            var result = companyManager.Add(new Company { Name = name, ShortName = shortName, Status = status });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message.ToString());
            }
            else
                Console.WriteLine("Başarısız");
        }
        public static void CompanyUpdate(int id, string name, string shortName, bool status)
        {
            CompanyManager companyManager = new(new EfCompanyDal());
            var result = companyManager.Update(new Company { Id = id, Name = name, ShortName = shortName, Status = status });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message.ToString());
            }
            else
                Console.WriteLine("Başarısız");
        }
        public static void CompanyDelete(int id)
        {
            CompanyManager companyManager = new(new EfCompanyDal());
            var result = companyManager.Delete(new Company { Id = id });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message.ToString());
            }
            else
                Console.WriteLine("Başarısız");
        }
        public static void CompanyGetList()
        {
            CompanyManager companyManager = new(new EfCompanyDal());
            var result = companyManager.GetList();

            if (result.Success == true)
            {
                foreach (var item in companyManager.GetList().Data)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
                Console.WriteLine("Başarısız");
        }
        public static void CompanyGetById(int id)
        {
            CompanyManager companyManager = new(new EfCompanyDal());
            var result = companyManager.GetById(id);
            if (result.Success == true)
            {
                Console.WriteLine(result.Data.Name);
            }
            else { Console.WriteLine("Başarısız"); }
        }

        public static void CompanyGetByShortName(string name)
        {
            CompanyManager companyManager = new(new EfCompanyDal());
            var result = companyManager.GetByShortName(name);
            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else { Console.WriteLine("Başarısız"); }

        }
        #endregion
    }
}
