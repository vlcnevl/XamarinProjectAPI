using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IWorkReferenceDal : IEntityRepository<WorkReference>
    {
       List<WorkDetailDto> GetWorkDetails(int workId);
       List<Work> GetUserApplication(int userId);

    }
}
