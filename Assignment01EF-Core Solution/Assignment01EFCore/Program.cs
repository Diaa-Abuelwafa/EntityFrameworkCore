using Assignment01EFCore.Data;
using Assignment01EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment01EFCore
{
    internal class Program
    {
        public static void Main()
        {
            using(AppDbContext Context = new AppDbContext())
            {
                // CURD Operation

                #region Create

                // Create
                //Student St = new Student()
                //{
                //    FName = "Diaa",
                //    Lname = "Ehab",
                //    Address = "Elmahmudia",
                //    Age = 24
                //};

                ////Context.Students.Add(St);

                //Instructor I1 = new Instructor()
                //{
                //    Name = "Ahmed Ali",
                //    Bonus = 10000,
                //    Salary = 14.5,
                //    Address = "Cairo",
                //    HourRate = 14,
                //};

                ////Context.Instructors.Add(I1);

                //Department D1 = new Department()
                //{
                //    Name = "Back-End",
                //    HiringDate = new DateTime(2002, 10, 10),
                //    Manager = I1,
                //};

                //Context.Departments.Add(D1);

                #endregion

                #region Update

                //var student = Context.Students.Single();

                //student.FName = "Saad";

                //Context.SaveChanges();

                #endregion

                #region Read

                //var Result1 = Context.Students.Single().FName;

                //Console.WriteLine(Result1);

                //var Result2 = Context.Departments.Include("Manager").Single();

                //Console.WriteLine(Result2.Name);

                #endregion

                #region Delete

                //var student = Context.Students.Single();

                //Context.Students.Remove(student);

                //Context.SaveChanges();

                #endregion

            }
        }
    }
}
