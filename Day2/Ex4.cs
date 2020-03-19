using System;

namespace CSharp
{
    class Day2
    {
        struct Date
        {
            public int day, month, year;
        }
        struct Student
        {
            public String id, name;
            public Date dateOfBirth;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Inut number of students: ");
            n = int.Parse(Console.ReadLine());
            Student[] listStudent = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the information of student " + (i + 1)+":");
                listStudent[i] = inputInfor();
            }
            Console.Clear();
            Console.WriteLine("Student list:");
            showList(listStudent);
            sortByYear(listStudent);
            Console.WriteLine("Studen list after sort:");
            showList(listStudent);
            Console.ReadLine();
        }
        static Student inputInfor()
        {
            Student x;
            Console.Write("Input id: ");
            x.id = Console.ReadLine();
            Console.Write("Input name: ");
            x.name = Console.ReadLine();
            Console.WriteLine("Input date of birth");
            Console.Write("Input day: ");
            x.dateOfBirth.day = int.Parse(Console.ReadLine());
            Console.Write("Input month: ");
            x.dateOfBirth.month = int.Parse(Console.ReadLine());
            Console.Write("Input year: ");
            x.dateOfBirth.year = int.Parse(Console.ReadLine());
            return x;
        }
        static void showInfor(Student x)
        {
            Console.WriteLine("Id: " + x.id + "\nname: " + x.name + "\nDate of birth: " + x.dateOfBirth.day + "/" + x.dateOfBirth.month + "/" + x.dateOfBirth.year);
        }
        static void showList(Student[] listStudent)
        {
            Console.WriteLine();
            int stt = 1;
            foreach (Student x in listStudent)
            {
                Console.WriteLine(stt + ".");
                showInfor(x);
                stt++;
            }
            Console.WriteLine();
        }
        static void sortByYear(Student[] listStudent)
        {
            for (int i = 0; i < listStudent.Length - 1; i++)
            {
                for (int j = i + 1; j < listStudent.Length; j++)
                {
                    if (listStudent[i].dateOfBirth.year > listStudent[j].dateOfBirth.year)
                    {
                        Student temp = listStudent[i];
                        listStudent[i] = listStudent[j];
                        listStudent[j] = temp;
                    }
                }
            }
        }
    }
}
