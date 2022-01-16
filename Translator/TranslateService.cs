using System;
using System.Collections.Generic;

namespace Translator
{
    public class TranslateService
    {
        public Dictionary<string, string> _translation;

        public TranslateService()
        {
            _translation = new Dictionary<string, string>();
            _translation.Add("dog", "собака");
            _translation.Add("cat", "кошка");
        }

        public void AddTranslation(string firstWord, string secondWord)
        {
            _translation.Add(firstWord, secondWord);
        }

        public string GetTranslation(string word)
        {
            return _translation[word];
        }
    }
}