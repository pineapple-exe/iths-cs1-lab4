﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VocabularyTest
{
    public class WordList
    {
        public string Name { get; }
        public string[] Languages { get; }

        private List<Word> words;

        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
            words = new List<Word>();
        }

        public static string[] GetLists()
        {
            string[] paths = Directory.GetFiles(WordListUtils.GeneratePath(), "*.dat");
            return paths.Select(p => Path.GetFileNameWithoutExtension(p)).ToArray();
        }

        public static WordList LoadList(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }

            string path = WordListUtils.GeneratePath(name);

            if (!File.Exists(path))
            {
                throw new Exception($"Wordlist file {name} does not exist.");
            }

            string[] fileContent = File.ReadAllLines(path);

            if (fileContent.Length < 1)
            {
                throw new Exception($"Wordlist file {name} does not contain any languages.");
            }
            string languageSoup = fileContent[0].Substring(0, fileContent[0].Length - 1);
            string[] languages = languageSoup.Split(';');
            WordList wordList = new WordList(name, languages);

            for (int i = 1; i < fileContent.Length; i++)
            {
                string wordSoup = fileContent[i].Substring(0, fileContent[i].Length - 1);
                string[] wordRainbow = wordSoup.Split(';');
                wordList.Add(wordRainbow);
            }
            return wordList;
        }

        public void Save()
        {
            string path = WordListUtils.GeneratePath(Name);

            string languagesFileFormat = string.Join("", Languages.Select(s => s + ";"));
            string[] languagesFileFormatArray = new string[] { languagesFileFormat };
            File.WriteAllLines(path, languagesFileFormatArray);

            for (int i = 0; i < words.Count; i++)
            {
                string[] wordRainbow = new string[1];

                for (int j = 0; j < words[i].Translations.Length; j++)
                {
                    wordRainbow[0] += words[i].Translations[j] + ";";
                }
                File.AppendAllLines(path, wordRainbow);
            }
        }

        public void Add(params string[] translations)
        {
            if (translations.Length != Languages.Length)
            {
                throw new ArgumentException("Wrong quantity of translations.");
            }

            Word word = new Word(translations);
            words.Add(word);
        }

        public bool Remove(int language, string translation)
        {
            bool itHappened = false;
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Translations[language].ToLower() == translation.ToLower())
                {
                    words.Remove(words[i]);
                    itHappened = true;
                    i--;
                }
            }
            return itHappened;
        }

        public int Count()
        {
            return words.Count;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            Word[] sorted = words.OrderBy(w => w.Translations[sortByTranslation]).ToArray();
            foreach (Word word in sorted)
            {
                showTranslations(word.Translations);
            }
        }

        public Word GetWordToPractice()
        {
            Random random = new Random();
            int word = random.Next(0, Count());

            List<string> languages = Languages.ToList();
            int fromLanguage = random.Next(0, languages.Count);
            int toLanguage = random.Next(0, languages.Count);

            while (toLanguage == fromLanguage)
            {
                toLanguage = random.Next(0, languages.Count);
            }
            return new Word(fromLanguage, toLanguage, words[word].Translations);
        }
    }
}
