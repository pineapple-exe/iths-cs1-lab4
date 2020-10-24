using System;
using System.Collections.Generic;
using System.Linq;

namespace VocabularyTest.ConsoleApp
{
    class Program
    {
        static void Main2(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("You must specify command.");
                return;
            }

            WordListUtils.FolderCheck();

            try
            {
                switch (args[0])
                {
                    case "lists":

                        string[] paths = WordList.GetLists();
                        foreach (string path in paths)
                        {
                            Console.WriteLine(path);
                        }
                        break;

                    case "new":

                        if (args.Length < 4)
                        {
                            Console.WriteLine("Listname or language missing.");
                            return;
                        }
                        else if (WordList.GetLists().Contains(args[1]))
                        {
                            Console.WriteLine("The name already exists. Do you want to overwrite? (Yes/No)");
                            string answer = Console.ReadLine().ToLower();
                            if (answer != "yes")
                            {
                                return;
                            }
                        }
                        New(args[1], args.Skip(2).ToArray());
                        break;

                    case "add":

                        if (args.Length < 2)
                        {
                            Console.WriteLine("Listname missing.");
                            return;
                        }
                        Add(args[1]);
                        break;

                    case "remove":

                        if (args.Length < 4)
                        {
                            Console.WriteLine("Listname, language or word missing.");
                            return;
                        }
                        Remove(args[1], args[2], args.Skip(3).ToArray());
                        break;

                    case "words":

                        if (args.Length < 2)
                        {
                            Console.WriteLine("Listname or language missing.");
                            return;
                        }

                        string maybeLanguage = null;

                        if (args.Length > 2)
                        {
                            maybeLanguage = args[2];
                        }

                        Words(args[1], maybeLanguage);
                        break;

                    case "count":

                        if (args.Length < 2)
                        {
                            Console.WriteLine("Listname missing.");
                            return;
                        }

                        Count(args[1]);
                        break;

                    case "practice":

                        if (args.Length < 2)
                        {
                            Console.WriteLine("Listname missing.");
                            return;
                        }

                        Practice(args[1]);
                        break;

                    default:

                        Console.WriteLine("Use any of the following parameters:");
                        Console.WriteLine("-lists");
                        Console.WriteLine("-new <list name> <language 1> <language 2> .. <language n>");
                        Console.WriteLine("-add <list name>");
                        Console.WriteLine("-remove <list name> <language> <word 1> <word 2> .. <word n>");
                        Console.WriteLine("-words <listname> <sortByLanguage>");
                        Console.WriteLine("-count <listname>");
                        Console.WriteLine("-practice <listname>");
                        break;
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void New(string name, string[] languages)//Skapar ett objekt, en lista, samt låter användaren lägga till ord.
        {
            WordList wordList = new WordList(name, languages);
            wordList.Save();
            Add(name);
        }

        static void Add(string name)
        {
            WordList theWordList = WordList.LoadList(name);

            while (true)
            {
                Console.WriteLine($"Add a new word, in {theWordList.Languages[0]}.");
                string userInput = Console.ReadLine();
                if (userInput == "")
                {
                    break;
                }
                else
                {
                    string[] wordRainbow = new string[theWordList.Languages.Length];
                    wordRainbow[0] = userInput;

                    for (int i = 1; i < theWordList.Languages.Length; i++)
                    {
                        Console.WriteLine($"Add the translation, in {theWordList.Languages[i]}.");
                        userInput = Console.ReadLine();
                        wordRainbow[i] = userInput;
                    }
                    theWordList.Add(wordRainbow);
                }
                theWordList.Save();
            }
        }

        static void Remove(string name, string language, params string[] word)
        {
            WordList wordList = WordList.LoadList(name);
            int indexInLanguages = GetLanguageIndex(wordList, language);

            if (indexInLanguages < 0)
            {
                Console.WriteLine("Language was invalid.");
                return;
            }

            foreach (string wordOfRemoval in word)
            {
                bool removed = wordList.Remove(indexInLanguages, wordOfRemoval);

                if (!removed)
                {
                    Console.WriteLine($"{wordOfRemoval} not found.");
                }
                else
                {
                    Console.WriteLine($"{wordOfRemoval} was successfully removed.");
                }
            }
            wordList.Save();
        }

        static void Words(string name, string sortByLanguage = null)
        {
            WordList wordList = WordList.LoadList(name);
            int sortByTranslation;

            if (sortByLanguage == null)
            {
                sortByTranslation = 0;
            }
            else
            {
                sortByTranslation = GetLanguageIndex(wordList, sortByLanguage);

                if (sortByTranslation < 0)
                {
                    Console.WriteLine("Language was invalid.");
                    return;
                }
            }
            wordList.List(sortByTranslation, ShowTranslations);
        }

        static int GetLanguageIndex(WordList wordList, string language)
        {
            List<string> languages = wordList.Languages.Select(s => s.ToLower()).ToList();

            if (!languages.Contains(language.ToLower()))
            {
                return -1;
            }
            return languages.IndexOf(language.ToLower());
        }

        static void ShowTranslations(string[] translations)
        {
            foreach (string translation in translations)
            {
                Console.Write(translation + "   ");
            }
            Console.WriteLine();
        }

        static void Count(string name)
        {
            Console.WriteLine($"{name} contains {WordList.LoadList(name).Count()} words.");
        }

        static void Practice(string name)
        {
            WordList listToPractice = WordList.LoadList(name);
            int wordsCount = 0;

            if (listToPractice.Count() == 0)
            {
                throw new Exception($"List does not contain any words.");
            }

            while (true)
            {
                Word wordOfPractice = listToPractice.GetWordToPractice();
                string fromLanguage = listToPractice.Languages[wordOfPractice.FromLanguage];
                string toLanguage = listToPractice.Languages[wordOfPractice.ToLanguage];

                Console.WriteLine($"Translate from {fromLanguage} to {toLanguage}...");
                Console.Write($"{wordOfPractice.Translations[wordOfPractice.FromLanguage]}    :    ");
                string userInput = Console.ReadLine();

                if (userInput == "")
                {
                    break;
                }

                else if (userInput.ToLower() == wordOfPractice.Translations[wordOfPractice.ToLanguage].ToLower())
                {
                    Console.WriteLine("Correct.");
                }

                else
                {
                    Console.WriteLine("Incorrect.");
                }
                wordsCount++;
                Console.WriteLine();
            }
            Console.WriteLine($"Practiced words: {wordsCount}");
        }

        static void Main(string[] args)
        {
            //string[] test = new string[] { "new", "firstList", "Swedish", "English", "German" };
            //string[] test = new string[] { "remove", "firstList", "German", "Life", "Humour", "Herbst", "bratwurst" };
            //string[] test = new string[] { "add", "firstList" };
            string[] test = new string[] { "practice", "NewList2" };
            //string[] test = new string[] { "words", "firstList", "german", "hallo", "bratwurst" };
            //string[] test = new string[] { "lists" };
            //string[] test = new string[] { "count", "NewList2" };
            Main2(test);
        }
    }
}
