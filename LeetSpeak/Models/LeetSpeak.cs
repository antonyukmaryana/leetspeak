using System;

namespace LeetSpeak.Models
{
    public class Leet
    {
        public string SpeakLeet(string phrase)
        {
            string[] words = phrase.Split(" ");
            for (int i = 0; i < words.Length; i++)
                {
                    char[] array = words[i].ToCharArray();
                    for (int j = 1; j < array.Length; j++)
                    {
                        if (array[j] == 'S' || array[j] == 's')
                        {
                            array[j] = 'z';
                        }
                    }
                    words[i] = string.Join("", array);
                }
            phrase = string.Join(" ", words);
            
            return phrase.Replace("E","e")
            .Replace("e","3")
            .Replace("O","o")
            .Replace("o","0")
            .Replace("L","1")
            .Replace("T","t")
            .Replace("t","7")
            ;
        }

    }
}