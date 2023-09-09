﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment2_Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class StudentMVCEntities : DbContext
    {
        public StudentMVCEntities()
            : base("name=StudentMVCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_Course> Tbl_Course { get; set; }
        public virtual DbSet<Tbl_Dept> Tbl_Dept { get; set; }
        public virtual DbSet<Tbl_Student> Tbl_Student { get; set; }
    
        public virtual int AddNewStudent(string stud_name, string email, string phone, Nullable<int> dept_id, Nullable<int> course_id)
        {
            var stud_nameParameter = stud_name != null ?
                new ObjectParameter("Stud_name", stud_name) :
                new ObjectParameter("Stud_name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var dept_idParameter = dept_id.HasValue ?
                new ObjectParameter("Dept_id", dept_id) :
                new ObjectParameter("Dept_id", typeof(int));
    
            var course_idParameter = course_id.HasValue ?
                new ObjectParameter("Course_id", course_id) :
                new ObjectParameter("Course_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddNewStudent", stud_nameParameter, emailParameter, phoneParameter, dept_idParameter, course_idParameter);
        }
    
        public virtual int DeleteStudent(Nullable<int> stud_ID)
        {
            var stud_IDParameter = stud_ID.HasValue ?
                new ObjectParameter("Stud_ID", stud_ID) :
                new ObjectParameter("Stud_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteStudent", stud_IDParameter);
        }
    
        public virtual ObjectResult<GetStudentDetails_Result> GetStudentDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStudentDetails_Result>("GetStudentDetails");
        }
    
        public virtual ObjectResult<GetStudentDetailsByDepartment_Result> GetStudentDetailsByDepartment(Nullable<int> deptID)
        {
            var deptIDParameter = deptID.HasValue ?
                new ObjectParameter("DeptID", deptID) :
                new ObjectParameter("DeptID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStudentDetailsByDepartment_Result>("GetStudentDetailsByDepartment", deptIDParameter);
        }
    
        public virtual int UpdateStudentDetails(Nullable<int> stud_ID, string stud_name, string email, string phone, Nullable<int> dept_id, Nullable<int> course_id)
        {
            var stud_IDParameter = stud_ID.HasValue ?
                new ObjectParameter("Stud_ID", stud_ID) :
                new ObjectParameter("Stud_ID", typeof(int));
    
            var stud_nameParameter = stud_name != null ?
                new ObjectParameter("Stud_name", stud_name) :
                new ObjectParameter("Stud_name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var dept_idParameter = dept_id.HasValue ?
                new ObjectParameter("Dept_id", dept_id) :
                new ObjectParameter("Dept_id", typeof(int));
    
            var course_idParameter = course_id.HasValue ?
                new ObjectParameter("Course_id", course_id) :
                new ObjectParameter("Course_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateStudentDetails", stud_IDParameter, stud_nameParameter, emailParameter, phoneParameter, dept_idParameter, course_idParameter);
        }
    }
}
