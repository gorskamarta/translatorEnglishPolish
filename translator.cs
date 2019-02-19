using System;
using System.Collections.Generic;
using System.IO;

public class Translator
{
    Dictionary<string, string> dictionary = new Dictionary<string, string>();

    public Translator()
    {
        var reader = new StreamReader("..\\..\\date.csv");
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line.Split(',');

            dictionary.Add(values[0], values[1]);
        }
        //dictionary.Add("ammeter", "amperomierz");
        //dictionary.Add("abbreviation", "skrót");
    }

	public string translate(string text)
	{
        string value = "";
        if (dictionary.TryGetValue(text, out value))
        {
            return value;
        }
        else
        {
            return "404";
        }

    }
}
