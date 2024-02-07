using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

// public class PhoneNumber
// {
//     public static string Clean(string phoneNumber)
//     {
//         throw new NotImplementedException("You need to implement this function.");
//     }
// }

// public class PhoneNumber
// {
//     public static string Clean(string phoneNumber)
//     {
//         var match = Regex.Match(string.Concat(phoneNumber.Where(char.IsDigit)), @"^1?([2-9]\d\d[2-9]\d{6})$");
//         return match.Success ? match.Groups[1].ToString() : throw new ArgumentException();
//     }
// }

// public class PhoneNumber
// {
//     public static string Clean(string phoneNumber)
//     {
//         string result = string.Join("", phoneNumber.ToCharArray().Where(char.IsDigit));
//         if (result.Length < 10 || result.Length > 11)
//             throw new ArgumentException();
//         if (result.Length == 11)
//             result = result[0] == '1' ? result.Remove(0, 1) : throw new ArgumentException();
//         if (result[0] == '0' || result[0] == '1' || result[3] == '0' || result[3] == '1')
//             throw new ArgumentException();
//         return result;
//     }
// }

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var charToRemove = new List<string>(){" ", "a", "b", "c", "d", "-", ".", "(", ")", "!", "#", "+", "@", ":"};

         string result = phoneNumber;         
         foreach (var c in charToRemove)
         {
            result = result.Replace(c, string.Empty);
         }

        if (result.Length < 10 || result.Length > 11)
            throw new ArgumentException();
        if (result.Length == 11)
            result = result[0] == '1' ? result.Remove(0, 1) : throw new ArgumentException();
        if (result[0] == '0' || result[0] == '1' || result[3] == '0' || result[3] == '1')
            throw new ArgumentException();
        return result;
    }
}