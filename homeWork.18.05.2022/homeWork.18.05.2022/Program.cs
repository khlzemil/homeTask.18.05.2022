using System;

class Program
{
    public static void Main()
    {
        int[] firstArr = {2,3,4,7};
        int[] secondArr = {2,4};
       

        Console.WriteLine(IsArrayContains(firstArr, secondArr));

    }


    static bool IsArrayContains(int[] firstArr, int[] secArr)
    {
        

        string ConvertedFirstArr = string.Join(",", firstArr);
        string ConvertedSecondArr = string.Join(",", secArr);
        if (ConvertedSecondArr.Length > ConvertedFirstArr.Length)
        {
            Console.WriteLine("Size is not aviable");

        }
        else if (ConvertedSecondArr.Length <= ConvertedFirstArr.Length)
        {
            if(ConvertedFirstArr.Contains(ConvertedSecondArr))
                return true;
        }
                return false;
        }
    

  }
