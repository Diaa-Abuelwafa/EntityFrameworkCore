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
                // CURD Operations

                #region Create

                //Instructor I1 = new Instructor()
                //{
                //    Name = "Diaa Ehab",
                //    Bonus = 1000,
                //    Salary = 18000,
                //    Address = "Elmahmudia",
                //    HourRate = 7
                //};

                //Instructor I2 = new Instructor()
                //{
                //    Name = "Ahmed Ehab",
                //    Bonus = 1000,
                //    Salary = 7000,
                //    Address = "Cairo",
                //    HourRate = 5
                //};

                //Instructor I3 = new Instructor()
                //{
                //    Name = "Sayed Shamaa",
                //    Bonus = 1000,
                //    Salary = 9000,
                //    Address = "Alex",
                //    HourRate = 9
                //};

                //Instructor I4 = new Instructor()
                //{
                //    Name = "Tareq Elsayed",
                //    Bonus = 1000,
                //    Salary = 6000,
                //    Address = "Giza",
                //    HourRate = 11
                //};

                //Context.Instructors.Add(I1);
                //Context.Instructors.Add(I2);
                //Context.Instructors.Add(I3);
                //Context.Instructors.Add(I4);

                //Department D1 = new Department()
                //{
                //    Name = "Back-End",
                //    HiringDate = new DateTime(2022, 11, 10),
                //    Manager = I1,
                //};

                //Department D2 = new Department()
                //{
                //    Name = "Front-End",
                //    HiringDate = new DateTime(2022, 9, 10),
                //    Manager = I2,
                //};

                //Department D3 = new Department()
                //{
                //    Name = "Full-Stack",
                //    HiringDate = new DateTime(2022, 7, 10),
                //    Manager = I3,
                //};

                //Context.Departments.Add(D1);
                //Context.Departments.Add(D2);
                //Context.Departments.Add(D3);

                //Student S1 = new Student()
                //{
                //    FName = "Said",
                //    Lname = "Ragab",
                //    Address = "Smouha",
                //    Age = 17,
                //    Department = D1,
                //};

                //Student S2 = new Student()
                //{
                //    FName = "Ali",
                //    Lname = "Saad",
                //    Address = "Sedi",
                //    Age = 16,
                //    Department = D1,
                //};

                //Student S3 = new Student()
                //{
                //    FName = "Shimaa",
                //    Lname = "Ehab",
                //    Address = "Myamy",
                //    Age = 18,
                //    Department = D3,
                //};

                //Context.Students.Add(S1);
                //Context.Students.Add(S2);
                //Context.Students.Add(S3);

                //Course C1 = new Course()
                //{
                //    Duration = 30,
                //    Name = "CPP",
                //    Discription = "This Is CPP Course",
                //};

                //Course C2 = new Course()
                //{
                //    Duration = 60,
                //    Name = "DataStructure",
                //    Discription = "This Is DataStructure Course",
                //};

                //Course C3 = new Course()
                //{
                //    Duration = 70,
                //    Name = "Algorithms",
                //    Discription = "This Is Algorithms Course",
                //};

                //Context.Courses.Add(C1);
                //Context.Courses.Add(C2);
                //Context.Courses.Add(C3);

                //Topic T1 = new Topic()
                //{
                //    Name = "Memory",
                //    CourseHasTopic = C1,
                //};

                //Topic T2 = new Topic()
                //{
                //    Name = "Queue",
                //    CourseHasTopic = C2,
                //};

                //Topic T3 = new Topic()
                //{
                //    Name = "Sorting",
                //    CourseHasTopic = C3,
                //};

                //Context.Topics.Add(T1);
                //Context.Topics.Add(T2);
                //Context.Topics.Add(T3);

                //StudentCourse SC1 = new StudentCourse()
                //{
                //    Student = S1,
                //    Course = C1,
                //    Grade = 10
                //};

                //StudentCourse SC2 = new StudentCourse()
                //{
                //    Student = S1,
                //    Course = C2,
                //    Grade = 15
                //};

                //StudentCourse SC3 = new StudentCourse()
                //{
                //    Student = S2,
                //    Course = C3,
                //    Grade = 9
                //};

                //StudentCourse SC4 = new StudentCourse()
                //{
                //    Student = S2,
                //    Course = C1,
                //    Grade = 17
                //};

                //StudentCourse SC5 = new StudentCourse()
                //{
                //    Student = S3,
                //    Course = C1,
                //    Grade = 6
                //};

                //StudentCourse SC6 = new StudentCourse()
                //{
                //    Student = S3,
                //    Course = C2,
                //    Grade = 7
                //};

                //Context.Stud_Course.AddRange(new List<StudentCourse> {
                //    SC1,
                //    SC2,
                //    SC3,
                //    SC4,
                //    SC5,
                //    SC6,
                //});

                //CourseInstructor CI1 = new CourseInstructor()
                //{
                //    Course = C1,
                //    Instructor = I1,
                //};

                //CourseInstructor CI2 = new CourseInstructor()
                //{
                //    Course = C1,
                //    Instructor = I2,
                //};

                //CourseInstructor CI3 = new CourseInstructor()
                //{
                //    Course = C2,
                //    Instructor = I3,
                //};

                //CourseInstructor CI4 = new CourseInstructor()
                //{
                //    Course = C3,
                //    Instructor = I2,
                //};

                //CourseInstructor CI5 = new CourseInstructor()
                //{
                //    Course = C1,
                //    Instructor = I3,
                //};

                //Context.CourseInstructor.AddRange(new List<CourseInstructor>
                //{
                //    CI1,
                //    CI2,
                //    CI3,
                //    CI4,
                //    CI5,
                //});

                //// Save The Seed Data
                //Context.SaveChanges();
                #endregion

                #region Update

                //var Result = Context.Students.FirstOrDefault(s => s.StudentId == 1);

                //if (Result != null)
                //{
                //    Result.FName = "Yasser";
                //}

                //var Ins01 = Context.Instructors.FirstOrDefault(I => I.InstructorId == 1);
                //var Ins02 = Context.Instructors.FirstOrDefault(I => I.InstructorId == 2);
                //var Ins03 = Context.Instructors.FirstOrDefault(I => I.InstructorId == 3);

                //var Dept01 = Context.Departments.FirstOrDefault(D => D.DepartmentId == 1);
                //var Dept02 = Context.Departments.FirstOrDefault(D => D.DepartmentId == 2);
                //var Dept03 = Context.Departments.FirstOrDefault(D => D.DepartmentId == 3);

                //Ins01.DeptWork = Dept01;
                //Ins02.DeptWork = Dept02;
                //Ins03.DeptWork = Dept03;

                //Context.SaveChanges();

                #endregion

                #region Read

                //var Result01 = Context.Students.ToList();

                //foreach (var s in Result01)
                //{
                //    Console.WriteLine(s.FName);
                //}

                //Console.WriteLine("-------------------------");

                //var Result02 = Context.Departments.Include("Manager").ToList();

                //foreach (var d in Result02)
                //{
                //    Console.WriteLine(d.Manager.Name);
                //}

                //Console.WriteLine("-------------------------");

                //var Result03 = Context.Departments.Include(x => x.Students).ToList();

                //foreach (var d in Result03)
                //{
                //    Console.WriteLine(d.Name + ":");
                //    foreach (var s in d.Students)
                //    {
                //        Console.WriteLine(s.FName);
                //    }
                //}

                //Console.WriteLine("-------------------------");

                //var Result04 = Context.Students.Include(x => x.StudentCourse).ThenInclude(sc => sc.Course).ToList();

                //foreach(var s in Result04)
                //{
                //    Console.WriteLine(s.FName + ":");

                //    foreach(var c in s.StudentCourse)
                //    {
                //        Console.WriteLine(c.Course.Name);
                //    }
                //}

                #endregion

                #region Delete

                //var Stu = Context.Students.FirstOrDefault(x => x.StudentId == 1);
                //if(Stu != null)
                //{
                //    Context.Students.Remove(Stu);
                //}

                #endregion

                #region Joining Operators

                var Result01 = Context.Students.Join(Context.Departments,
                        s => s.DeptId,
                        d => d.DepartmentId,
                        // Return For Me Collection Of Annonymous Types
                        (s, d) => new
                        {
                            StudentName = s.FName,
                            DepartmentName = d.Name,
                        }
                    );

                foreach (var c in Result01)
                {
                    Console.WriteLine(c.StudentName + " " + c.DepartmentName);
                }

                var Result02 = Context.Students.GroupJoin(Context.Departments,
                        s => s.DeptId,
                        d => d.DepartmentId,
                        (s, d) => new
                        {
                            s,
                            d = d.DefaultIfEmpty()
                        }
                    ).SelectMany(sc => sc.d,
                        (sc, d) => new
                        {
                            sc.s.FName,
                            d.Name
                        }
                    );

                Console.WriteLine("------------------------------");

                foreach (var c in Result02)
                {
                    Console.WriteLine(c.FName + " " + c.Name);
                }

                var Result03 = Context.Students.SelectMany(stu => Context.Departments,
                        (stu, dept) => new
                        {
                            stu.FName, 
                            dept.Name
                        }
                    );

                Console.WriteLine("------------------------------");


                foreach (var c in Result03)
                {
                    Console.WriteLine(c.FName + " " + c.Name);
                }

                #endregion
            }
        }
    }
}
