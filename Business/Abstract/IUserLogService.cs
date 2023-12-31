﻿using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserLogService
    {
        IResult Add(UserLog userLog);
        IDataResult<List<UserLog>> GetAll();
    }
}
