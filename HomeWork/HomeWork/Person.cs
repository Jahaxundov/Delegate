using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public int Salary { get; set; }


        
        public bool CheckSalary(Person person1)
        {
            return person1.Salary > 1000;
        }
       

        public void ExecuteMethod()
        {
            List<Person> list = new()
            {
                new Person {Id=1,Adress="Suraxani",Name="Ahmed",Surname="Ahmedov",Salary=1200},
                new Person {Id=1,Adress="Papanin",Name="Sharaf",Surname="Sharafov",Salary=500},
                new Person {Id=1,Adress="Xetai",Name="Pervin",Surname="Mirzayev",Salary=1600},
            };
            CheckSalaryofPeope(list, CheckSalary);
        }

        private void CheckSalaryofPeope(List<Person> people, Predicate<Person> func)
        {
            
            foreach (var item in people)
            {
                if (func(item))
                {
                    Console.WriteLine($"{item.Name} - {item.Surname} - {item.Adress}");
                }
            }
          
        }
    }
}
