using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCreatorExer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array langArray = Enum.GetValues(typeof(Languages));
            for (int i = 0; i < langArray.Length; i++)
            {
                string inFileText = String.Format($"File No {i}, Created on {DateTime.Now}");
                FileCreator(langArray.GetValue(i), inFileText);
            }
        }

        public static void FileCreator(object language,string textToWrite, string DirPath = "C:\\Users\\ASUS\\source\\hi\\ex12")
        {
            string langPath = System.IO.Path.Combine(DirPath, language.ToString());
            System.IO.Directory.CreateDirectory(langPath);
            string logPath = System.IO.Path.Combine(langPath, "log.txt");
            System.IO.StreamWriter sw = new System.IO.StreamWriter(logPath);
            sw.WriteLine(textToWrite);
            sw.Close();
        }
    }

    class FileCreator
    {
        public string DirPath { get; set; }
    }

    enum Languages
    {
        Afar, Abkhaz, Avestan, Afrikaans, Akan, Amharic, Aragonese, Arabic, Assamese, Avaric, Aymara, Azerbaijani, SouthAzerbaijani, Bashkir, Belarusian, Bulgarian, Bihari, Bislama, Bambara, BengaliBangla, TibetanStandard, Tibetan, Central, Breton, Bosnian, CatalanValencian, Chechen, Chamorro, Corsican, Cree, Czech, OldChurchSlavonic, ChurchSlavonic, OldBulgarian, Chuvash, Welsh, Danish, German, DivehiDhivehiMaldivian, Dzongkha, Ewe, Greek, Modern, English, Esperanto, SpanishCastilian, Estonian, Basque, PersianFarsi, FulaFulahPulaarPular, Finnish, Fijian, Faroese, French, WesternFrisian, Irish, ScottishGaelicGaelic, Galician, Guaraní, Gujarati, Manx, Hausa, Hebrewmodern, Hindi, HiriMotu, Croatian, HaitianHaitianCreole, Hungarian, Armenian, Herero, Interlingua, Indonesian, Interlingue, Igbo, Nuosu, Inupiaq, Ido, Icelandic, Italian, Inuktitut, Japanese, Javanese, Georgian, Kongo, Kikuyu, Gikuyu, Kwanyama, Kuanyama, Kazakh, Kalaallisut, Greenlandic, Khmer, Kannada, Korean, Kanuri, Kashmiri, Kurdish, Komi, Cornish, Kyrgyz, Latin, Luxembourgish, Letzeburgesch, Ganda, Limburgish, Limburgan, Limburger, Lingala, Lao, Lithuanian, LubaKatanga, Latvian, Malagasy, Marshallese, Māori, Macedonian, Malayalam, Mongolian, MarathiMarāṭhī, Malay, Maltese, Burmese, Nauru, NorwegianBokmål, NorthNdebele, Nepali, Ndonga, Dutch, NorwegianNynorsk, Norwegian, SouthNdebele, Navajo, Navaho, ChichewaChewaNyanja, Occitan, Ojibwe, Ojibwa, Oromo, Oriya, Ossetian, Ossetic, Panjabi, Punjabi, Pāli, Polish, Pashto, Pushto, Portuguese, Quechua, Romansh, Kirundi, Romanian, Russian, Kinyarwanda, SanskritSaṁskṛta, Sardinian, Sindhi, NorthernSami, Sango, Sinhala, Sinhalese, Slovak, Slovene, Samoan, Shona, Somali, Albanian, Serbian, Swati, SouthernSotho, Sundanese, Swedish, Swahili, Tamil, Telugu, Tajik, Thai, Tigrinya, Turkmen, Tagalog, Tswana, TongaTongaIslands, Turkish, Tsonga, Tatar, Twi, Tahitian, Uyghur, Uighur, Ukrainian, Urdu, Uzbek, Venda, Vietnamese, Volapük, Walloon, Wolof, Xhosa, Yiddish, Yoruba, Zhuang, Chuang, Chinese, Zulu
    }
}
