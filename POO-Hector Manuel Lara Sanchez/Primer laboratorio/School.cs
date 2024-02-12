namespace Primer_laboratorio
{
    using System;
    using System.Collections.Generic;

    abstract class Person
    {  
        public string Name { get; protected set; }
        public int ID { get; internal set; }

        public Person(string name)
        {
            Name = name;
        }
    }

    class Student : Person
    {
        public int ID { get; private set; }

        public Student(string name, int id) : base(name)
        {
            ID = id;
        }
    }

    class Teacher : Person
    {
        public string Subject { get; private set; }

        public Teacher(string name, string subject) : base(name)
        {
            Subject = subject;
        }
    }

    class School
    {
        public string Name { get; private set; }
        private List<Person> people;
        private List<string> subjects;

        public School(string name)
        {
            Name = name;
            people = new List<Person>();
            subjects = new List<string>();
        }

        public void AddPerson<T>(T person) where T : Person
        {
            people.Add(person);
        }

        public void AddSubject(string subject)
        {
            subjects.Add(subject);
        }

        public void DisplayPeople<T>() where T : Person
        {
            foreach (var person in people)
            {
                if (person is T)
                {
                    Console.WriteLine($"Nombre: {person.Name}");
                    if (typeof(T) == typeof(Teacher))
                    {
                        Teacher? teacher = person as Teacher;
                        Console.WriteLine($"Materia: {teacher.Subject}");
                    }
                }
            }
        }

        public void DisplaySubjects()
        {
            foreach (var subject in subjects)
            {
                Console.WriteLine(subject);
            }
        }

        public void RemovePerson<T>(int id) where T : Person
        {
            people.RemoveAll(person => person is T && ((T)person).ID == id);
        }

        public void RemovePerson<T>(string name) where T : Person
        {
            people.RemoveAll(person => person is T && person.Name == name);
        }

        public void RemoveSubject(string subject)
        {
            subjects.Remove(subject);
        }
    }
}

