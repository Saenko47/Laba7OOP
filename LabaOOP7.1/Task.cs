using LabaOOP5;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7OOP
{
    internal class Task : IContainer, IFileContainer, IEnumerable
    {
        public Magazine[] magazines;
        public Boolean IsDataSaved { get; set; }
        public int count => magazines.Length;

        public Task()
        {
            this.magazines = new Magazine[0];

        }
        public Task(Magazine[] magazines)
        {
            this.magazines = magazines;

        }
        public Magazine this[int index]
        {
            get { return magazines[index]; }
            set { magazines[index] = value; }
        }
        public void Add(Magazine mag)
        {
            Magazine[] newMagazines = new Magazine[magazines.Length + 1];
            for (int i = 0; i < magazines.Length; i++)
            {
                newMagazines[i] = magazines[i];
            }
            newMagazines[magazines.Length] = mag;
            magazines = newMagazines;
        }
        public void Delete(int element)
        {
            Magazine[] newMagazines = new Magazine[magazines.Length - 1];
            for (int k = 0; k < element; k++)
            {
                newMagazines[k] = magazines[k];
            }
            for (int k = element; k < magazines.Length - 1; k++)
            {
                newMagazines[k] = magazines[k + 1];
            }
            magazines = newMagazines;
        }
        public void Save(string filepath)
        {
            using (StreamWriter writer = new StreamWriter(filepath))
            {


                writer.WriteLine(magazines.Length);
                for (int j = 0; j < magazines.Length; ++j)
                {
                    int k = 0;
                    writer.WriteLine(magazines[j].Name);
                    writer.WriteLine(magazines[j].DateOfPublishing.ToString("yyyy-MM-dd"));
                    writer.WriteLine(magazines[j].Circulation);
                    writer.WriteLine(magazines[j].Articles.Length);

                    if (magazines[j].Articles == null || magazines[j].Articles.Length == 0)
                        throw new Exception($"No articles to save in magazine {magazines[j].Name}");

                    while (k < magazines[j].articles.Length)
                    {
                        writer.WriteLine(magazines[j].articles[k].ToString());
                        k++;
                    }
                    writer.WriteLine("||||");
                }


            }
            IsDataSaved = true;
        }
        public void Load(string filepath)
        {
            if(magazines != null)
            {
                if (!IsDataSaved) { throw new Exception("Data is not saved"); }
            }
            using (StreamReader reader = new StreamReader(filepath))
            {
                int count = int.Parse(reader.ReadLine());
                magazines = new Magazine[count];
                for (int j = 0; j < count; ++j)
                {
                    string name = reader.ReadLine();
                    DateTime date = DateTime.Parse(reader.ReadLine());
                    int circulation = int.Parse(reader.ReadLine());
                    int articlesCount = int.Parse(reader.ReadLine());
                    Article[] articles = new Article[articlesCount];
                    for (int k = 0; k < articlesCount; ++k)
                    {
                        string[] partOfPerson = reader.ReadLine().Split(' ', ':');
                        string personName = partOfPerson[0];
                        string personLastName = partOfPerson[1];
                        DateTime personBirthdate = DateTime.Parse(partOfPerson[5]);
                        Person person = new Person(personName, personLastName, personBirthdate);
                        string articlename = reader.ReadLine();
                        string score = reader.ReadLine();
                        articles[k] = new Article(person, articlename, double.Parse(score.TrimEnd('.')));
                        if (score.EndsWith(".")) continue;
                        else throw new Exception("Invalid data format");
                    }
                    magazines[j] = new Magazine(name, date, circulation, articles);
                    reader.ReadLine();
                }
               
            }

            

        }
        public IEnumerator GetEnumerator()
        {
            return magazines.GetEnumerator();
        }
    }
}
