using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IWorkReferenceService
    {
        IResult Add(WorkReference workReference);
        IResult Delete(WorkReference workReference);
        IResult Update(WorkReference workReference);
        IDataResult<List<WorkReference>> GetAll();
        IDataResult<WorkReference> GetById(int id);
        IDataResult<List<WorkReference>> GetByUserId(int userId);
        IDataResult<WorkReference> GetByWorkId(int workId);
        IDataResult<List<WorkDetailDto>> GetWorkDetails(int workId);
        IDataResult<List<Work>> GetUserApplication(int userId);
    }
}
