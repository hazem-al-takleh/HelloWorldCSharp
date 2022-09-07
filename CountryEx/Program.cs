using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldNamespace
{
    internal class Program
    {
        public static void Main()
        {
            Country countryOneInstance = new Country("Syria", "Damascus");
            Country countryTwoInstance = new Country("UK", "Lonon");
            //countryOneInstance.SayHi();
            //countryOneInstance.SayHi(countryOneInstance.CountryName);
            CountryLanguage countryLanguage = new CountryLanguage();
            countryLanguage.FirstLanguage = Languages.Fr;
            countryLanguage.SecondLanguage = Languages.En;
            countryOneInstance.Language = countryLanguage;
            countryOneInstance.PlanetName = "Earth";
            countryOneInstance.Currency = Currencies.USD;
            countryOneInstance.Continent = Continents.Antarctica;
            Console.WriteLine(countryOneInstance.Language.SecondLanguage);
        }
    }
    abstract class World
    {
        string planetName;
        Continents continent;

        public string PlanetName
        {
            get { return planetName; }
            set { planetName = value; }
        }
        public Continents Continent
        {
            get { return continent; }
            set { continent = value; }
        }
    }

    class Country : World
    {
        string countryName;
        string capital;
        CountryLanguage language;
        Currencies currency;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        public CountryLanguage Language
        {
            get { return language; }
            set { language = value; }
        }

        public Currencies Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public Country()
        {
            this.countryName = "";
            this.capital = "";
        }

        public Country(string countryName, string capital)
        {
            this.countryName = countryName;
            this.capital = capital;
        }

        public void SayHi()
        {
            Console.WriteLine("Hi");
        }

        public void SayHi(string countryName)
        {
            Console.WriteLine("Hi from " + countryName);
        }
    }

    struct CountryLanguage
    {
        Languages firstLanguage;
        Languages secondLanguage;
        public Languages FirstLanguage
        {
            get { return firstLanguage; }
            set { firstLanguage = value; }
        }
        public Languages SecondLanguage
        {
            set { secondLanguage = value; }
            get { return secondLanguage; }
        }
    }

    enum Continents
    {
        Asia, Africa, NorthAmerica, SouthAmerica, Antarctica, Europe, Australia
    }

    enum Languages
    {
        En, Ar, Fr, De
    }

    enum Currencies
    {
        USD, JYN, EUR
    }
}
