using Laba7OOP;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace LabaOOP5
{
    internal class Magazine:IComparable<Magazine>, IEnumerable, IComparable
    {
       
    
        
        const string pattern = @"^([A-Z][a-z]+)([\sA-Za-z])+$";
        const string datepattern = @"^\d{4},\d{2},\d{2}$";
        public string name;
        public DateTime dateOfPublishing;
        public int circulation;
        public Article[] articles;
        

       
       
        
        public Magazine()
        {
            this.name = "NoName";
            
            this.dateOfPublishing = DateTime.Now;
            this.circulation = 0;
            this.articles = new Article[0];
        }
        public Magazine(string name, DateTime dateOfPublishing, int circulation, Article[] articles)
        {
            this.name = name != String.Empty && Regex.IsMatch(name, pattern) ? name : throw new Exception("Wrong name for magazine");

            this.dateOfPublishing = dateOfPublishing;
            this.circulation = (circulation>0)?circulation:21;
            this.articles = articles ?? new Article[0];
        }
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value != String.Empty && Regex.IsMatch(value, pattern)) this.name = value;
                else throw new Exception("Wrong name format string");
            }
        }
        
        public DateTime DateOfPublishing
        {
            get { return this.dateOfPublishing; }
            set
            {
               
                    this.dateOfPublishing = value;
            
            }
        }
        public int Circulation
        {
            get { return this.circulation; }
            set
            {
                if (value > 0) this.circulation = value;
                else throw new Exception("Value is such numbers");
            }
        }
        public Article[] Articles
        {
            get { return this.articles; }
            set { this.articles = value ?? new Article[0]; }
        }
        public Article this[int index]
        {
            get
            {
                if (index < 0 || index >= articles.Length)
                    throw new IndexOutOfRangeException("Index is out of range.");
                return this.articles[index];
            }
            set
            {
                if (index < 0 || index >= articles.Length)
                    throw new IndexOutOfRangeException("Index is out of range.");
                this.articles[index] = value;
            }
        }

        public double AvarageScore()
        {
            double avarage = 0;
            for (int k = 0; k < articles.Length; ++k)
            {
                avarage += articles[k].Score;
            }
            return avarage / (articles.Length);
        }
        public double avgscore => AvarageScore();
        public void AddArticle(params Article[] newArticles)
        {

            if (newArticles == null || newArticles.Length == 0) return;
            int capacity = articles.Length + newArticles.Length;
            Article[] updatedArticles = new Article[capacity];
            for (int i = 0; i < articles.Length; i++)
            {
                updatedArticles[i] = articles[i];
            }
            for (int i = 0; i < newArticles.Length; i++)
            {
                updatedArticles[articles.Length + i] = newArticles[i];
            }
            articles = updatedArticles;


        }
       
       
     
        public int CompareTo(Magazine other)
        {
            return this.avgscore.CompareTo(other.avgscore); 
        }
        public override string ToString()
        {
            StringBuilder articlelist = new StringBuilder();
            for (int k = 0; k < articles.Length; ++k)
            {
                articlelist.Append(articles[k].ToString()).Append(";\n");
            }
            return $"Magazine: {name},  Release Date: {dateOfPublishing:yyyy-MM-dd}, Circulation: {Circulation}, Avg Score: {avgscore:F1}, articles:\n{articlelist}";
        }
        public string ToShortString()
        {
            return $"Magazine: {name},  Release Date: {dateOfPublishing:yyyy-MM-dd}, Circulation: {circulation}, Avg Score: {avgscore:F1}";

        }
        public IEnumerator GetEnumerator()
        {
            return articles.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Magazine otherMagazine = obj as Magazine;
            if (otherMagazine != null)
                return this.Name.CompareTo(otherMagazine.Name);
            else
                throw new ArgumentException("Object is not a Magazine");
        }
    }
}
