﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BelousovaOD.Sprint6.Task6.V19.lib
{
    public class DataService : ISprint6Task6V19
    {
        public string CollectTextFromFile(string str, string path)
        {
            string fileContent = File.ReadAllText(path);
            string[] words = fileContent.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            string result = string.Join(" ", words.Where(word => word.Contains('l')));

            return result;
        }
    }
}
