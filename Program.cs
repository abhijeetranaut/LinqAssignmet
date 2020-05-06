using LINQDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpDbContext dbcontext = new EmpDbContext();

            Console.WriteLine("");

            //Query 2

            Console.WriteLine(" ");


            var empquery2 = from employee in dbcontext.Employee
                            select employee;

            foreach(var emp in empquery2)
            {
                Console.WriteLine(emp.EmployeeId + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Department);
            }


            Console.WriteLine(" ");

            //Query 3

            Console.WriteLine(" ");

            var empquery3 = from employee in dbcontext.Employee
                            select employee;

            foreach (var emp in empquery3)
            {
                Console.WriteLine( emp.FirstName + "--" + emp.LastName );
            }

            Console.WriteLine(" ");

            //Query 4

            Console.WriteLine(" ");

            var empquery4 = from EmployeeName in dbcontext.Employee
                            select EmployeeName;

            foreach (var emp in empquery4)
            {
                Console.WriteLine(emp.FirstName);
            }


            Console.WriteLine(" ");

            //Query 5

            Console.WriteLine(" ");

            var empquery5 = from employee in dbcontext.Employee
                            select employee.FirstName.ToUpper();  

            foreach (var emp in empquery5)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine(" ");

            //Query 6

            Console.WriteLine(" ");

            var empquery6 = from employee in dbcontext.Employee
                            select employee.FirstName.ToLower();

            foreach (var emp in empquery6)
            {
                Console.WriteLine(emp);
            }


            Console.WriteLine(" ");

            //Query 7

            Console.WriteLine(" ");

            var empquery7 = (from employee in dbcontext.Employee
                            select employee.Department).Distinct();
            

            foreach (var emp in empquery7)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine(" ");

            //Query 8

            Console.WriteLine(" ");

            var empquery8 = from employee in dbcontext.Employee
                            select employee.FirstName.Substring(0,3);


            foreach (var emp in empquery8)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine(" ");

            //Query 9

            Console.WriteLine(" ");

            var empquery9 = from employee in dbcontext.Employee
                            where employee.FirstName=="John"
                            select employee;


            foreach (var emp in empquery9)
            {
                Console.WriteLine(emp.FirstName.IndexOf('o'));
            }

            Console.WriteLine(" ");

            //Query 12

            Console.WriteLine(" ");

            var empquery12 = from employee in dbcontext.Employee
                             select employee.FirstName.Length;


            foreach (var emp in empquery12)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine(" ");

            //Query 13

            Console.WriteLine(" ");

            var empquery13 = from employee in dbcontext.Employee
                             select employee.FirstName.Replace('o','$');


            foreach (var emp in empquery13)
            {
                Console.WriteLine(emp);
            }


            Console.WriteLine(" ");

            //Query 16

            Console.WriteLine(" ");

            var empquery16 = from employee in dbcontext.Employee
                             orderby employee.FirstName ascending
                             select employee;
            Console.WriteLine("Ascending order : ");
            foreach (var emp in empquery16)
            {
                Console.WriteLine(emp.FirstName);
            }

            Console.WriteLine(" ");

            //Query 17

            Console.WriteLine(" ");

            var empquery17 = from employee in dbcontext.Employee
                             orderby employee.FirstName descending
                             select employee;
            Console.WriteLine("Descending order : ");
            foreach (var emp in empquery17)
            {
                Console.WriteLine(emp.FirstName);
            }


            Console.WriteLine(" ");

            //Query 18

            Console.WriteLine(" ");

            var empquery18 = from employee in dbcontext.Employee
                             orderby (employee.FirstName), employee.Salary descending
                             select employee;
            
            foreach (var emp in empquery18)
            {
                Console.WriteLine(emp.EmployeeId+"-"+emp.FirstName+"-"+emp.LastName+"-"+emp.Salary+"-"+emp.JoiningDate+"-"+emp.Department);
            }



            Console.WriteLine(" ");

            //Query 19

            Console.WriteLine(" ");

            var empquery19 = from employee in dbcontext.Employee
                             where employee.FirstName=="John"
                             select employee;

            foreach (var emp in empquery19)
            {
                Console.WriteLine(emp.EmployeeId + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Department);
            }


            Console.WriteLine(" ");

            //Query 20

            Console.WriteLine(" ");

            var empquery20 = from employee in dbcontext.Employee
                             where employee.FirstName == "John" || employee.FirstName == "Roy"
                             select employee;

            foreach (var emp in empquery20)
            {
                Console.WriteLine(emp.EmployeeId + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Department);
            }

            Console.WriteLine(" ");

            //Query 21

            Console.WriteLine(" ");

            var empquery21 = from employee in dbcontext.Employee
                             where employee.FirstName != "John" && employee.FirstName != "Roy"
                             select employee;

            foreach (var emp in empquery21)
            {
                Console.WriteLine(emp.EmployeeId + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Department);
            }

            Console.WriteLine(" ");

            //Query 22

            Console.WriteLine(" ");

            var empquery22 = from employee in dbcontext.Employee
                             where employee.FirstName.StartsWith("j")
                             select employee;

            foreach (var emp in empquery22)
            {
                Console.WriteLine(emp.EmployeeId + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Department);
            }


            Console.WriteLine(" ");

            //Query 23"

            Console.WriteLine(" ");

            var empquery23 = from employee in dbcontext.Employee
                             where employee.FirstName.Contains("o")
                             select employee;

            foreach (var emp in empquery23)
            {
                Console.WriteLine(emp.EmployeeId + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Department);
            }

            Console.WriteLine(" ");

            //Query 24

            Console.WriteLine(" ");

            var empquery24 = from employee in dbcontext.Employee
                             where employee.FirstName.EndsWith("n")
                             select employee;

            foreach (var emp in empquery24)
            {
                Console.WriteLine(emp.EmployeeId + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Department);
            }


            Console.WriteLine(" ");

            //Query 25

            Console.WriteLine(" ");

            var empquery25 = from employee in dbcontext.Employee
                             where employee.FirstName.EndsWith("n") && employee.FirstName.Length==4
                             select employee;

            foreach (var emp in empquery25)
            {
                Console.WriteLine(emp.EmployeeId + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Department);
            }

            Console.WriteLine(" ");

            //Query 26

            Console.WriteLine(" ");

            var empquery26 = from employee in dbcontext.Employee
                             where employee.FirstName.StartsWith("J") && employee.FirstName.Length == 4
                             select employee;

            foreach (var emp in empquery26)
            {
                Console.WriteLine(emp.EmployeeId + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Department);
            }


            Console.WriteLine("");

            //Query 27

            Console.WriteLine(" ");

            var empquery27 = from employee in dbcontext.Employee
                             where employee.Salary>60000
                             select employee;

            foreach (var emp in empquery27)
            {
                Console.WriteLine(emp.EmployeeId + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Department);
            }


            Console.WriteLine("");

            //Query 28

            Console.WriteLine(" ");

            var empquery28 = from employee in dbcontext.Employee
                             where employee.Salary < 800000
                             select employee;

            foreach (var emp in empquery28)
            {
                Console.WriteLine(emp.EmployeeId + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Department);
            }


            Console.WriteLine("");

            //Query 29

            Console.WriteLine(" ");

            var empquery29 = from employee in dbcontext.Employee
                             where employee.Salary > 500000 && employee.Salary<800000
                             select employee;

            foreach (var emp in empquery29)
            {
                Console.WriteLine(emp.EmployeeId + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Department);
            }


            Console.WriteLine("");

            //Query 30

            Console.WriteLine(" ");

            var empquery30 = from employee in dbcontext.Employee
                             where employee.FirstName == "John" || employee.FirstName == "Michael"
                             select employee;

            foreach (var emp in empquery30)
            {
                Console.WriteLine(emp.EmployeeId + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Department);
            }


            Console.WriteLine("");

            //Query 31

            Console.WriteLine(" ");

            var empquery31 = from employee in dbcontext.Employee
                             where employee.JoiningDate.Year==2013
                             select employee;

            foreach (var emp in empquery31)
            {
                Console.WriteLine(emp.EmployeeId + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Department);
            }



            Console.WriteLine("");

            //Query 32

            Console.WriteLine(" ");

            var empquery32 = from employee in dbcontext.Employee
                             where employee.JoiningDate.Month == 1
                             select employee;

            foreach (var emp in empquery32)
            {
                Console.WriteLine(emp.EmployeeId + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Department);
            }



            Console.WriteLine("");

            //Query 39

            Console.WriteLine(" ");

            var empquery39 = from employee in dbcontext.Employee
                             where employee.LastName.Contains("%")
                             select employee;

            foreach (var emp in empquery39)
            {
                Console.WriteLine(emp.EmployeeId + "-" + emp.FirstName + "-" + emp.LastName + "-" + emp.Salary + "-" + emp.JoiningDate + "-" + emp.Department);
            }


            Console.WriteLine("");

            //Query 40

            Console.WriteLine(" ");

            var empquery40 = from employee in dbcontext.Employee
                             where employee.LastName.Contains("%")
                             select employee.LastName.Replace("%"," ");

            foreach (var emp in empquery40)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("");

            //Query 41

            Console.WriteLine(" ");


            var empquery41 = from employee in dbcontext.Employee
                               group employee by employee.Department into departGroup
                                orderby departGroup.Sum(i=>i.Salary)
                               select new

                               {

                                   Department = departGroup.Key,

                                   Salary = departGroup.Sum(i => i.Salary)

                               };


            foreach (var emp in empquery41)
            {
                Console.WriteLine(emp);

            }
            
            //Query 44

            Console.WriteLine(" ");
            
            var empquery44 = from employee in dbcontext.Employee
                                group employee by employee.Department into departGroup
                                   orderby departGroup.Average(x=>x.Salary)ascending
                                    Select new  
                                {
                                    Department = departGroup.Key,
                                    Salary = departGroup.Average(x=>x.Salary)
                                };
                    foreach (var emp in empquery44)
                    {
                        Console.WriteLine(emp);
                    }
          
            // Query 45
            Console.WriteLine(" ");
            
                        var empquery45 = from employee in dbcontext.Employee
                                group employee by employee.Department into departGroup
                                   orderby departGroup.Max(x=>x.Salary)ascending
                                    Select new  
                                {
                                    Department = departGroup.Key,
                                    Salary = departGroup.Max(x=>x.Salary)
                                };
                    foreach (var emp in empquery45)
                    {
                        Console.WriteLine(emp);
                    }
            // Query 46
            Console.WriteLine(" ");
            var empquery46 = from employee in dbcontext.Employee
                                group employee by employee.Department into departGroup
                                   orderby departGroup.Min(x=>x.Salary)ascending
                                    Select new  
                                {
                                    Department = departGroup.Key,
                                    Salary = departGroup.Min(x=>x.Salary)
                                };
                    foreach (var emp in empquery46)
                    {
                        Console.WriteLine(emp);
                    }
            
             // Query 48
                 var empquery48 = from employee in dbcontext.Employee
                                group employee by employee.Department into departGroup
                                   orderby departGroup.Sum(x=>x.Salary)
                                    where departGroup.Sum(x => x.Salary)>800000
                                    Select new  
                                {
                                    Department = departGroup.Key,
                                    Salary = departGroup.Min(x=>x.Salary)
                                };
                    foreach (var emp in empquery48)
                    {
                        Console.WriteLine(emp);
                    }
            
            
            //Query 49
            var empquery49 = from employee in dbcontext.Employee
                                join Incentives in dbcontext.Incentives on employee.EmployeeId equals incentives.EmployeeId
                                    Select new  
                                {
                                    employee.FirstName,
                                    incentives.IncentiveAmount
                                };
                    foreach (var emp in empquery49)
                    {
                        Console.WriteLine(emp.FirstName);
                    }
              
             // Query 50
                var empquery50 = from emploee in dbcontext.Employee
                          join incentives in dbcontext.Incentives on employee.EmployeeId equals incentives.EmployeeId
                          where incentives.IncentiveAmount > 3000
                          select new
                          {
                              employee.FirstName,
                              incentives.IncentiveAmount
                          };
                foreach (var i in empquery50)
                {
                    Console.WriteLine(i.FirstName);
                }

         
                 // Query 52
                var empquery52 = from employee in db.Employee
                             join incentives in dbcontext.Incentives
                            on employee.EmployeeId equals incentives.EmployeeId into employeeDepartment
                             from res in employeeDepartment.DefaultIfEmpty()
                             select new
                             {
                                 EmployeeName = employee.FirstName,
                                 IncentiveAmount = res == null ? 0 : res.IncentiveAmount
                             };
                foreach (var i in empquery52)
                {
                    Console.WriteLine("EmployeeNaame" + i.EmployeeName + " IncentiveAmount" + i.IncentiveAmount);

                }
            // Query 54
                var empquery54 = (from employee in dbcontext.Employee select employee.Salary).Take(2);
                foreach (var i in empquery54)
                    Console.WriteLine("Salary "+i);
             
            //Query 56
                var empquery56 = (from employee in dbcontext.Employee orderby employee.Salary descending select employee.Salary).Skip(1).First();
                Console.WriteLine("Second Highest Salary" + empquery56);

             // Query 57
                var num = Convert.ToInt32(Console.ReadLine());
                var empquery57 = (from employee in dbcontext.Employee orderby employee.Salary descending select employee.Salary).Skip(num - 1).First();
                Console.WriteLine("Nth highest Salary " + empquery57);
            
            // Query 58
            var empquery58 =  (from employee in dbcontext.Employee select employee.FirstName).Union(from employee in dbcontext.Employee select employee.LastName);
            foreach(var i in empquery58)
                Console.WriteLine("First Name"+i.FirstName+"  LastName" +i.LastName)
                
               //Query 62
                var empquery62 = (from employee in dbcontext.Employee select employee.EmployeeId).Minus(from incentives in dbcontext.Incentives select incentives.EmpRefId );
                 foreach (var emp in empquery62)
                    {
                        Console.WriteLine(emp);
                    }
        }
    }
}
