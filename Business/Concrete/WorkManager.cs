using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class WorkManager : IWorkService
    {
        IWorkDal _workDal;

        public WorkManager(IWorkDal workDal)
        {
            _workDal = workDal;
        }

        public IResult Add(Work work)
        {
            _workDal.Add(work);
            return new SuccessResult(Messages.AddedWork);
        }

        public IResult Delete(Work work)
        {
            _workDal.Delete(work);
            return new SuccessResult(Messages.DeletedWork);
        }

        public IDataResult<List<Work>> GetAll()
        {
            return new SuccessDataResult<List<Work>>(_workDal.GetAll());
        }

        public IDataResult<Work> GetById(int workId)
        {
            return new SuccessDataResult<Work>(_workDal.Get(w => w.Id== workId));
        }

        public IDataResult<List<Work>>GetByUserId(int userId)
        {
            return new SuccessDataResult<List<Work>>(_workDal.GetAll(w => w.UserId== userId));
        }

        public IResult Update(Work work)
        {
            _workDal.Update(work);
            return new SuccessResult(Messages.UpdatedWork);
        }
        public IDataResult<List<Work>>GetByTittle(string tittle)
        {
            return new SuccessDataResult<List<Work>>(_workDal.GetAll(w => w.Tittle.Contains(tittle)));
        }
    }
}
