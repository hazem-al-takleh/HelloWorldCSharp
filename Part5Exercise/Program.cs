using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie(
                name:"Hazem",
                rate:9.9f,
                releaseDate: DateTime.Now.AddYears(-23),
                languages: new Languages[] { Languages.Ar, Languages.En },
                countries: new Countries[] { Countries.Iraq },
                genres: new Genres[] { Genres.Action }
                );
            movie.ShowInfo();



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
    }

    class Movie
    {
        public string name { get; set; }
        public float rate { get; set; }
        public DateTime releaseDate { get; set; }
        public Languages[] languages;
        public Countries[] countries;
        public Genres[] genres;

        public Movie(string name, float rate, DateTime releaseDate, Languages[] languages, Countries[] countries, Genres[] genres)
        {
            this.name = name;
            this.rate = rate;
            this.releaseDate = releaseDate;
            this.languages = ArrayAssigner<Languages>(languages);
            this.countries = ArrayAssigner<Countries>(countries);
            this.genres = ArrayAssigner<Genres>(genres);
        }
        T[] ArrayAssigner<T>(T[] array)
        {
            T[] field = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
                field[i] = array[i];
            return field;
        }
        void ArrayPrinter<T>(T[] array, string specifier)
        {
            Console.Write(specifier + " : ");
            for (int i = 0; i < array.Length - 1; i++)
                Console.Write($"{array[i]},");
            Console.Write($"{array[array.Length - 1]}");
            Console.WriteLine();
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Movie: {this.name}");
            Console.WriteLine($"Rate: {this.rate} out of 10");
            Console.WriteLine($"Release Date: {this.releaseDate.ToShortDateString()}");
            ArrayPrinter<Languages>(this.languages, "Languages");
            ArrayPrinter<Countries>(this.countries, "Countries");
            ArrayPrinter<Genres>(this.genres, "Genres");
        }

    }

    enum Genres { Action, Drama, Thriller }
    enum Languages { En, Ar, Fr }
    enum Countries { Syria, Lebenon, Iraq }
}
