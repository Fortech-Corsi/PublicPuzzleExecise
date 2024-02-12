using System;
using System.Collections.Generic;
using System.Linq;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var a = new Dictionary<object, object>();        
        var dictionary = new Dictionary<string, int>();

        // Ciclo per tutte le chiavi del dizionario
        foreach (int key in old.Keys)
        {
            // Recupero il valore dal dizionario
            string[] strings = old.GetValueOrDefault(key);

            // Per tutti gli elementi all'interno del valore
            foreach (var s in strings)
            {
                // Trasformo il valore in lowercase
                string lowercase = s.ToLower();

                // aggiungo il valore al nuovo dizionario
                dictionary.Add(lowercase, key);
            }
        }

        return dictionary;
    }
}

