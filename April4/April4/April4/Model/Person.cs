using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April4.Model
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        } 

        public static Person[] PersonSort(Person[] people)
        {
            Person temp;

            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i].Age > people[j].Age)
                    {
                        temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }
            return people;

        }
        public override string ToString()
        {
            return $"name : {Name },  surname: {Surname} ,  age : {Age}";
        }
    }
}
