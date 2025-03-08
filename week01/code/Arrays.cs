public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Using O(n) time complexity to create a list of double

        var l1 = new List<double>();
        // Using O(n) time complexity to run throught the limit of the length and add the number to the list
        for (int i = 0; i < length; i++)
        {
            l1.Add(number * (i + 1));
        }

        return l1.ToArray();

    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        //First step is to check if the list is not empty.
        if (data.Count <= 1)
        {
            return;
        }

        //IF the data (list) is not empty will get the point to rotate the list *amount*
        //define the first list and point of rotation. the amount index
        //define the second list the rest of the first list
        List<int> l1 = data.GetRange(data.Count - amount, amount);
        List<int> l2 = data.GetRange(0, data.Count - amount);

        //clear the list
        data.Clear();

        //adding the two list.
        data.AddRange(l1);
        data.AddRange(l2);

    }
}
