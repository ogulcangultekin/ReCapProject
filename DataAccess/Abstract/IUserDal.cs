using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Concrete.EntityFramewok.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal: IEntityRepository<User>
    {
    }
}
