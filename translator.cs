using System;
using System.Collections.Generic;
using System.IO;

public class Translator
{
    Dictionary<string, string> dictionaryEngPl = new Dictionary<string, string>();
    Dictionary<string, string> dictionaryPlEng = new Dictionary<string, string>();

    public Translator()
    {
        var reader = new StreamReader("..\\..\\date.csv");
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line.Split(',');

            dictionaryEngPl.Add(values[0], values[1]);
            dictionaryPlEng.Add(values[1], values[0]);
        }

    }

	public string translate(string text, int tryb)
	{
        string value = "";

        if (tryb == 0)
        {
            if (dictionaryPlEng.TryGetValue(text, out value))
            {
                return value;
            }
        }

        if (tryb == 1) { 
            if (dictionaryEngPl.TryGetValue(text, out value))
            {
                return value;
            }
        }

        return "404";
    }
}
