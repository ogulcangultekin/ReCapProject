using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramewok.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramewok
{
    public class EfUserDal: EfEntityRepositoryBase<User, EfDbContext>, IUserDal
    {
    }
}
