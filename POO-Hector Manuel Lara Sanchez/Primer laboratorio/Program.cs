namespace Primer_laboratorio { 

    class Program
    {
        static void Main(string[] args)
        {
            School mySchool = new School("Mi Escuela");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMenú:");
                Console.WriteLine("1. Agregar Estudiante");
                Console.WriteLine("2. Agregar Maestro");
                Console.WriteLine("3. Agregar Materia");
                Console.WriteLine("4. Mostrar Listado de Estudiantes");
                Console.WriteLine("5. Mostrar Listado de Maestros");
                Console.WriteLine("6. Mostrar Listado de Materias");
                Console.WriteLine("7. Eliminar Estudiante");
                Console.WriteLine("8. Eliminar Maestro");
                Console.WriteLine("9. Eliminar Materia");
                Console.WriteLine("0. Salir");

                Console.Write("Ingrese una  opción: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddStudent(mySchool);
                        break;
                    case "2":
                        AddTeacher(mySchool);
                        break;
                    case "3":
                        AddSubject(mySchool);
                        break;
                    case "4":
                        mySchool.DisplayPeople<Student>();
                        break;
                    case "5":
                        mySchool.DisplayPeople<Teacher>();
                        break;
                    case "6":
                        mySchool.DisplaySubjects();
                        break;
                    case "7":
                        RemoveStudent(mySchool);
                        break;
                    case "8":
                        RemoveTeacher(mySchool);
                        break;
                    case "9":
                        RemoveSubject(mySchool);
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese un número del menú.");
                        break;
                }
            }
        }

        static void AddStudent(School school)
        {
            Console.Write("Ingrese el nombre del estudiante: ");
            string name = Console.ReadLine();
            Console.Write("Ingrese el ID del estudiante: ");
            int id = int.Parse(Console.ReadLine());

            school.AddPerson(new Student(name, id));
            Console.WriteLine("Estudiante agregado correctamente.");
        }

        static void AddTeacher(School school)
        {
            Console.Write("Ingrese el nombre del maestro: ");
            string name = Console.ReadLine();
            Console.Write("Ingrese la materia que enseña el maestro: ");
            string subject = Console.ReadLine();

            school.AddPerson(new Teacher(name, subject));
            Console.WriteLine("Maestro agregado correctamente.");
        }

        static void AddSubject(School school)
        {
            Console.Write("Ingrese el nombre de la materia: ");
            string subject = Console.ReadLine();

            school.AddSubject(subject);
            Console.WriteLine("Materia agregada correctamente.");
        }

        static void RemoveStudent(School school)
        {
            Console.Write("Ingrese el ID del estudiante que desea eliminar: ");
            int id = int.Parse(Console.ReadLine());

            school.RemovePerson<Student>(id);
            Console.WriteLine("Estudiante eliminado correctamente.");
        }

        static void RemoveTeacher(School school)
        {
            Console.Write("Ingrese el nombre del maestro que desea eliminar: ");
            string name = Console.ReadLine();

            school.RemovePerson<Teacher>(name);
            Console.WriteLine("Maestro eliminado correctamente.");
        }

        static void RemoveSubject(School school)
        {
            Console.Write("Ingrese el nombre de la materia que desea eliminar: ");
            string subject = Console.ReadLine();

            school.RemoveSubject(subject);
            Console.WriteLine("Materia eliminada correctamente.");
        }
    }
}