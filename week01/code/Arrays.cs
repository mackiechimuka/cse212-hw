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
        // For this problem I need to find the multiples of a number based on the lenghth provided
        // I will create an empty array of doubles with the size of the length provided
        // I will then use a for loop to iterate using the lenghth as the limit 
        // I will then multiply the number by the index of the loop and then add the result to the array
        // Finally , I will return the array of doubles that contains the multiples of the number
        // I realized that I need to keep track of the multiple of the number so I created another variable multiple and then incremented it by 1 after adding the multiples of the number to the array
        double[] multiples = new double[length];
        int multipler = 1;
        for (int i = 0; i <= length - 1; i++)
        {
            multiples[i] = number * multipler;
            multipler++;
        }
        return multiples; // replace this return statement with your own
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
        // I will check if the data is null or the amount is less than 1 and if so I will return
        // I will then get the length of the data 
        //I will then get the amount modulus the length of the data to get the actual amount to rotate eg lets say its 12 and we have 9 items and we will only need 3 rotations
        // I will check if amount is 0 and if so then I will return
        // I will then reverse the entire list
        // I will then reverse the first amount of items in the list
        // I will then reverse the rest of the items in the list
        if (data == null || amount < 1)
        {
            return;
        }
        int length = data.Count;
        amount = amount % length;
        if (amount == 0)
        {
            return;
        }

        data.Reverse();
        data.Reverse(0,amount);
        data.Reverse(amount,length-amount);
    }
}
