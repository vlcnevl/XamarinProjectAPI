using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfWorkReferenceDal : EfEntityRepositoryBase<WorkReference, WorkApplicationContext>, IWorkReferenceDal
    {
        public List<WorkDetailDto> GetWorkDetails(int workId)
        {
           using (WorkApplicationContext context = new WorkApplicationContext())
            {
                var result = from references in context.WorkReferences.Where(w => w.WorkId == workId)
                             from user in context.Users.Where(u=> u.Id == references.UserId)


                             select new WorkDetailDto()
                             {
                                
                                Id = user.Id,
                                AboutMe = user.AboutMe,
                                Address = user.Address,
                                BirthDate = user.BirthDate, 
                                CvPath = user.CvPath , 
                                Email = user.Email, 
                                FirstName = user.FirstName, 
                                LastName = user.LastName ,
                                Mobile = user.Mobile, 
                                PasswordHash = user.PasswordHash, 
                                PasswordSalt = user.PasswordSalt, 
                                Status =user.Status ,
                                UserName = user.UserName

                             };
                return result.ToList();
                             

                             //select new WorkDetailDto
                             //{ 

                             //    Users = (from users in context.Users
                             //             where (references.UserId == users.Id)
                             //             select new User { Id = users.Id, AboutMe = users.AboutMe , Address = users.Address ,
                             //                 BirthDate = users.BirthDate, CvPath = users.CvPath , Email = users.Email, 
                             //                 FirstName = users.FirstName, LastName = users.LastName , Mobile = users.Mobile, 
                             //                 PasswordHash = users.PasswordHash, PasswordSalt = users.PasswordSalt, Status =users.Status ,
                             //                 UserName = users.UserName}).ToList()

                             //};

            
            }

        }


        public List<Work>GetUserApplication(int userId)
        {
            using (WorkApplicationContext context = new WorkApplicationContext())
            {
                var result = from references in context.WorkReferences.Where(r => r.UserId == userId)
                             from work in context.Works.Where(w => w.Id == references.WorkId)

                             select new Work()
                             {
                                 Id = work.Id,
                                 Address = work.Address,
                                 AddressLatitude = work.AddressLatitude,
                                 AddressLongitude = work.AddressLongitude,
                                 Category = work.Category,
                                 CompanyMail = work.CompanyMail,
                                 CompanyName = work.CompanyName,
                                 CompanyPhone = work.CompanyPhone,
                                 EducationStatus = work.EducationStatus,
                                 Experience = work.Experience,
                                 Explanation = work.Explanation,
                                 Hıw = work.Explanation,
                                 PositionLevel = work.PositionLevel,
                                 Tittle = work.Tittle,
                                 UserId = work.UserId
                             };
                return result.ToList();
            }
        }



    }
}
