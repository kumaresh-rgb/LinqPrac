using System;
using System.Linq;

class LinqExercise1
{
    static void Main()
    {
        //  The first part is Data source.
        int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.Write("\nBasic structure of LINQ : ");
        Console.Write("\n---------------------------");

        // The second part is Query creation.
        // nQuery is an IEnumerable<int>

        var nQuery =
            from VrNum in n1 // Creating a query expression that retrieves even numbers from the array
            where (VrNum % 2) == 0
            select VrNum;

        // The third part is Query execution.

        Console.Write("\nThe numbers which produce the remainder 0 after divided by 2 are : \n");
        foreach (int VrNum in nQuery) // Loop through the result of the query and display the numbers
        {
            Console.Write("{0} ", VrNum);
        }
        Console.Write("\n\n");

        var nQuerycount =  nQuery.Count();
        Console.WriteLine(nQuerycount);
    }
}
