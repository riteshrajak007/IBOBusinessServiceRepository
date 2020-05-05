using IBO.Core.BusinessService.Domain;
using IBO.Core.BusinessService.Domain.Models;
using IBO.Core.BusinessService.Domain.Repositories;
using IBO.Core.BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static IBO.Core.BusinessService.Services.Enums;

namespace IBO.Core.BusinessService.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private ILoggerService _loggerService;
        public StudentService(IUnitOfWork unitOfWork, ILoggerService loggerService)
        {
            _unitOfWork = unitOfWork;
            _loggerService = loggerService;
        }

        /// <summary>
        /// GetAllStudentAsync
        /// </summary>
        /// <returns></returns>
        public async Task<ICollection<Student>> GetAllStudentAsync()
        {
            try
            {
                return await _unitOfWork.Students.GetAllAsync();
            }
            catch (Exception ex)
            {
                await _loggerService.InsertIntoLog(ExceptionHelperService.HandleException(ErrorLevel.Error.ToString(), ex.ToString(), $"Failed to get Students."));
                return null;
            }
        }
        /// <summary>
        /// GetAllStudentByIdAsync
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ICollection<Student>> GetAllStudentByIdAsync(int id)
        {
            try
            {
                return await _unitOfWork.Students.FindAllAsync(c => c.Id == id);
            }
            catch (Exception ex)
            {
                await _loggerService.InsertIntoLog(ExceptionHelperService.HandleException(ErrorLevel.Error.ToString(), ex.ToString(), $"Failed to get Student details by Id"));
                return null;
            }
        }
        /// <summary>
        /// GetStudentAsync
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Student> GetStudentAsync(int id)
        {
            try
            {
                return await _unitOfWork.Students.FindAsync(c => c.Id == id);
            }
            catch (Exception ex)
            {
                await _loggerService.InsertIntoLog(ExceptionHelperService.HandleException(ErrorLevel.Error.ToString(), ex.ToString(), $"Failed to get Student detail."));
                return null;
            }
        }

        /// <summary>
        /// Updates the students
        /// </summary>
        /// <param name="t">Student Entity</param>
        /// <param name="key">Key</param>
        /// <returns></returns>
        public async Task<Student> UpdateStudentAsync(Student t, int key)
        {
            try
            {
                var result = _unitOfWork.Students.UpdateStudent(t, (object)key);
                await _unitOfWork.Students.SaveAsync();
                return result;
            }
            catch (Exception ex)
            {
                await _loggerService.InsertIntoLog(ExceptionHelperService.HandleException(ErrorLevel.Error.ToString(), ex.ToString(), $"Failed to update Student detail."));
                return null;
            }
        }

        /// <summary>
        /// Add Student in tblStudent
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public async Task<Student> AddStudentAsync(Student t)
        {
            try
            {
                return await _unitOfWork.Students.AddAsync(t);
            }
            catch (Exception ex)
            {
                await _loggerService.InsertIntoLog(ExceptionHelperService.HandleException(ErrorLevel.Error.ToString(), ex.ToString(), $"Failed to Add Student detail."));
                return null;
            }
        }

        /// <summary>
        /// Delete Student
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<int> DeleteStudentAsync(int id)
        {
            try
            {
                Student itemStudent = _unitOfWork.Students.Find(c => c.Id == id);
                return await _unitOfWork.Students.DeleteAsync(itemStudent);
            }
            catch (Exception ex)
            {
                await _loggerService.InsertIntoLog(ExceptionHelperService.HandleException(ErrorLevel.Error.ToString(), ex.ToString(), $"Failed to Delete Student."));
                return 0;
            }
        }
    }
}
