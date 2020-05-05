using IBO.Core.BusinessService.Domain;
using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static IBO.Core.BusinessService.Services.Enums;

namespace IBO.Core.BusinessService.Services
{
    public class SchoolService : ISchoolService
    {
        private IUnitOfWork _unitOfWork;
        private ILoggerService _loggerService;
        public SchoolService(IUnitOfWork unitOfWork, ILoggerService loggerService)
        {
            _unitOfWork = unitOfWork;
            _loggerService = loggerService;
        }

        /// <summary>
        /// Get All the school from tblSchool
        /// </summary>
        /// <returns></returns>
        public async Task<ICollection<School>> GetAllSchoolAsync()
        {
            try
            {
                return await Task.FromResult<ICollection<School>>(_unitOfWork.Schools.GetAll().ToList());
            }
            catch (Exception ex)
            {
                await _loggerService.InsertIntoLog(ExceptionHelperService.HandleException(ErrorLevel.Error.ToString(), ex.ToString(), $"Failed to get Schools."));
                return null;
            }

        }
        /// <summary>
        /// Get All School By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ICollection<School>> GetAllSchoolByIdAsync(int id)
        {
            try
            {
                return await _unitOfWork.Schools.FindAllAsync(c => c.Id == id);
            }
            catch (Exception ex)
            {
                await _loggerService.InsertIntoLog(ExceptionHelperService.HandleException(ErrorLevel.Error.ToString(), ex.ToString(), $"Failed to get School details by Id"));
                return null;
            }

        }
        /// <summary>
        /// Get School
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<School> GetSchoolAsync(int id)
        {
            try
            {
                return await _unitOfWork.Schools.FindAsync(c => c.Id == id);
            }
            catch (Exception ex)
            {
                await _loggerService.InsertIntoLog(ExceptionHelperService.HandleException(ErrorLevel.Error.ToString(), ex.ToString(), $"Failed to get School detail."));
                return null;
            }
        }

        /// <summary>
        /// Updates School
        /// </summary>
        /// <param name="t"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<School> UpdateSchoolAsync(School t, int key)
        {
            try
            {
                var result = _unitOfWork.Schools.UpdateStudent(t, (object)key);
                await _unitOfWork.Schools.SaveAsync();
                return result;
            }
            catch (Exception ex)
            {
                await _loggerService.InsertIntoLog(ExceptionHelperService.HandleException(ErrorLevel.Error.ToString(), ex.ToString(), $"Failed to update School detail."));
                return null;
            }
        }
        /// <summary>
        /// Add School in Db
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public async Task<School> AddSchoolAsync(School t)
        {
            try
            {
                return await _unitOfWork.Schools.AddAsync(t);
            }
            catch (Exception ex)
            {
                await _loggerService.InsertIntoLog(ExceptionHelperService.HandleException(ErrorLevel.Error.ToString(), ex.ToString(), $"Failed to Add School detail."));
                return null;
            }
        }
        /// <summary>
        /// Delete School
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<int> DeleteSchoolAsync(int id)
        {
            try
            {
                School itemSchool = _unitOfWork.Schools.Find(c => c.Id == id);
                return await _unitOfWork.Schools.DeleteAsync(itemSchool);
            }
            catch (Exception ex)
            {
                await _loggerService.InsertIntoLog(ExceptionHelperService.HandleException(ErrorLevel.Error.ToString(), ex.ToString(), $"Failed to Delete School."));
                return 0;
            }

        }

    }
}
