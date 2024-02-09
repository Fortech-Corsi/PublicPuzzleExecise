using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private static List<int> _listaPunteggi {get;set;}

    // https://learn.microsoft.com/en-us/dotnet/csharp/linq/
    public HighScores(List<int> list)
    {
        // salvo la lista nella variabile locale
        _listaPunteggi = list;
        // throw new NotImplementedException();
    }

    public List<int> Scores()
    {
        // ritorno la lista dei punteggi
        return _listaPunteggi;
        // throw new NotImplementedException();
    }

    public int Latest()
    {
        // ritorno l'ultimo
        int ultimo = -1;
        foreach(var p in _listaPunteggi){
            ultimo = p;
        }

        return ultimo;
        // throw new NotImplementedException();
    }

    public int PersonalBest()
    {
        // ritorno il migliore 

        int best = -1;
        foreach(var p in _listaPunteggi){
            if(best < p){
                best = p;
            }
        }

        return best;

        // throw new NotImplementedException();
    }

    public List<int> PersonalTopThree()
    {
        // ritorno i migliori 3

        var elementiDaRecuperare = 3;
        var miglioritre = new List<int>();

        // Sol1
        // int processati = 0;
        // foreach(var p in _listaPunteggi.OrderByDescending(p=> p)){
        //     if(processati < elementiDaRecuperare){
        //         miglioritre.Add(p);

        //         processati++;
        //     }
        // }

        // return miglioritre;

        // Sol 2
        // int[] array = _listaPunteggi.ToArray();
        // int temporary;
        // for (int j = 0; j <= array.Length - 2; j++)
        // {
        //     for (int i = 0; i <= array.Length - 2; i++)
        //     {
        //         if (array[i] < array[i + 1])
        //         {
        //             temporary= array[i + 1];
        //             array[i + 1] = array[i];
        //             array[i] = temporary;
        //         }
        //     }
        // }

        // int processati = 0;
        // foreach(var p in array){
        //     if(processati < elementiDaRecuperare){
        //         miglioritre.Add(p);

        //         processati++;
        //     }
        // }

        // return miglioritre;

         // Sol 3
         return _listaPunteggi.OrderByDescending(p=> p).Take(3).ToList();

        // throw new NotImplementedException();
    }
}