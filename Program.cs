using System;

class SmallTask
{
   static void fillArrayFromCmd(string[] array, int size){
        for (int i = 0; i < size; i++) {
            Console.Write($"Array [{i}] = ");
            array[i] = Console.ReadLine();
}
    }

    static int fillResulArray(string[] initialArray, string[] resultArray) {
        int index = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length < 4)
            {
                resultArray[index] = initialArray[i];
                index++;
            }
        }
        return index;
    }

    // Print first N (n = index) elements of array
    static void printArrayToIndex(string[] array, int index) {
        Console.Write("[");
        for(int j = 0; j < index; j++)
        {
            Console.Write($"\"{array[j]}\"");
            if (j < index - 1)
            Console.Write(", ");
        }
            Console.Write("]");
    }
    static void Main()
    {
        int count = 0;
        Console.Write("Enter the array size: ");
        string CountString;
        CountString = Console.ReadLine();
        if (Int32.TryParse(CountString, out count) && count > 0) {
             string[] InitialArray = new string[count];
             string[] ResultArray = new string[count];
             fillArrayFromCmd(InitialArray, count);
             int index = fillResulArray(InitialArray, ResultArray);
             Console.Clear();
             printArrayToIndex(InitialArray, InitialArray.Length);
             Console.Write(" -> ");
             printArrayToIndex(ResultArray, index);
             Console.WriteLine();
        }
        else {
            Console.WriteLine("Error: array size is not valid");
        }
    }

}