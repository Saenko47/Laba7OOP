using LabaOOP5;
using System.Collections.Immutable;
using System.Reflection;

namespace Laba7OOP
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                GenMagazine genMagazine = new GenMagazine();
                Magazine[] mag = genMagazine.GenerateMagazine(5, 4);
                Task task = new Task(mag);
                Array.Sort(task.magazines);
                foreach (var magazine in task.magazines)
                {
                    Console.WriteLine(magazine);
                }

                Magazine mag1 = new Magazine("Tech", DateTime.Now, 1000, new Article[] {
    new Article(new Person("A", "B", new DateTime(2000,1,1)), "Title", 9.5)
});
                task.Add(mag1);
                task.Save("bebra.txt");
                task.Load("bebra.txt");
                foreach (var magazine in task.magazines)
                {
                    Console.WriteLine(magazine);
                }
                Magazine[] mag2 = new Magazine[2];
                Array.Copy(task.magazines, mag2, 2);
                Task task1 = new Task(mag2);
                foreach (var magazine in task1.magazines)
                {
                    Console.WriteLine(magazine);
                }
                task1.Save("bebra.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }




        }

    }
    
}
