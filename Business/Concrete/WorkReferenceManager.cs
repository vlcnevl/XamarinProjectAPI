using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class WorkReferenceManager : IWorkReferenceService
    {
        IWorkReferenceDal _workReferenceDal;

        public WorkReferenceManager(IWorkReferenceDal workReferenceDal)
        {
            _workReferenceDal = workReferenceDal;
        }

        public IResult Add(WorkReference workReference)
        {
            _workReferenceDal.Add(workReference);
            return new SuccessResult(Messages.AddedWorkReference);
        }

        public IResult Delete(WorkReference workReference)
        {
            _workReferenceDal.Delete(workReference);
            return new SuccessResult(Messages.DeletedWorkReference);
        }

        public IDataResult<List<WorkReference>> GetAll()
        {
            return new SuccessDataResult<List<WorkReference>>(_workReferenceDal.GetAll());
        }

        public IDataResult<WorkReference> GetById(int id)
        {
            return new SuccessDataResult<WorkReference>(_workReferenceDal.Get(w => w.Id == id));
        }

        public IDataResult<List<WorkReference>> GetByUserId(int userId)
        {
            return new SuccessDataResult<List<WorkReference>>(_workReferenceDal.GetAll(w => w.UserId == userId));
        }

        public IDataResult<WorkReference> GetByWorkId(int workId)
        {
            return new SuccessDataResult<WorkReference>(_workReferenceDal.Get(w => w.WorkId == workId));
        }

        public IDataResult<List<Work>> GetUserApplication(int userId)
        {
            return new SuccessDataResult<List<Work>>(_workReferenceDal.GetUserApplication(userId));
        }

        public IDataResult<List<WorkDetailDto>> GetWorkDetails(int workId)
        {
            return new SuccessDataResult<List<WorkDetailDto>>(_workReferenceDal.GetWorkDetails(workId));
        }

        public IResult Update(WorkReference workReference)
        {
            _workReferenceDal.Update(workReference);
            return new SuccessResult(Messages.UpdatedWorkReference);
        }


    }
}
