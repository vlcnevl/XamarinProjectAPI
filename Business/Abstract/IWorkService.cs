using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IWorkService
    {
        IResult Add(Work work);
        IResult Delete(Work work);
        IResult Update(Work work);
        IDataResult<List<Work>> GetAll();
        IDataResult<Work> GetById(int id);
        IDataResult<List<Work>> GetByUserId(int UserId);
        IDataResult<List<Work>> GetByTittle(string tittle);

        //   IDataResult<Work> GetUserByEmail(string email);
    }
}
