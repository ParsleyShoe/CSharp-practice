using System;

namespace CodeWarsKanaDuplicateEncoder {
    class Program {
        static void Main(string[] args) {
            string word = "hello";
            string newWord = "";
            foreach (var letter in word) {
                int count = 0;
                if (count < word.Length && word[count] == letter) {
                    count++;
                } else {
                    //count++;
                }
                
                if (count > 1) {
                    newWord += ")";
                } newWord += "(";
            }
            Console.WriteLine(newWord);

            //string letterArray = "";
            //var fullWord = word;
            //var splitWord = word.ToCharArray();
            //foreach (char letter in splitWord) {
            //    int count = 0;
            //    while (count < myString.Length && myString[count] == '$') count++;

            //    string dupeWord = fullWord;
            //    if ((dupeWord.Length - dupeWord.Replace(letter, "").Length) > 1) {
            //        letterArray += ")";
            //        dupeWord = fullWord;
            //    } else {
            //        letterArray += "(";
            //        dupeWord = fullWord;
            //    }
            //}
            //Console.WriteLine(letterArray);
        }
    }
}
;