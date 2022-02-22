﻿using BlazorExample.Common;
using BlazorExample.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorExample.Business.Contracts
{
    public interface ICourseRepository
    {
        public Task<Result<CourseDto>> CreateCourse(CourseDto courseDto);
        public Task<Result<CourseDto>> UpdateCourse(int courseId, CourseDto courseDto);
        public Task<Result<CourseDto>> UpdateCourseImage(int courseId, string imagePath);
        public Task<Result<CourseDto>> GetCourse(int courseId);
        public Task<Result<int>> DeleteCourse(int courseId);
        public Task<Result<IEnumerable<CourseDto>>> GetAllCourse();
    }
}
