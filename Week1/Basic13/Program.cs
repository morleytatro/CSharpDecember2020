using System;

class MainClass {
    public static void Main (string[] args) {
        // int[] result = OddArray();
        // // Console.WriteLine(result);
        // foreach(int v in result)
        // {
        //   Console.WriteLine(v);
        // }
        // PrintSum();
        // int[] myArray = new int[]{1, 5, 10, 7, -2};

        // ShiftValues(myArray);

        // foreach(int val in myArray)
        // {
        //   Console.WriteLine(val);
        // }
        int[] startingArray = new int[]{-1, -3, 2};

        // calling the function with the startingArray as an argument
        var result = NumToString(startingArray);

        foreach(object val in result)
        {
            Console.WriteLine(val);
        }
    }

    public static void PrintSum()
    {
        int sum = 0;

        for(int i = 0; i <= 255; i++)
        {
            // update the sum value
            sum = sum + i;
            Console.WriteLine($"New number: {i} Sum: {sum}");
        }
        // Print all of the numbers from 0 to 255, 
        // but this time, also print the sum as you go. 
        // For example, your output should be something like this:
        
        // New number: 0 Sum: 0
        // New number: 1 Sum: 1
        // New Number: 2 Sum: 3
    }

    public static int[] OddArray()
    {
        // 1. establish a container to hold the values
        int[] output = new int[128];

        // int index = 0;

        // // 2. count the numbers to 255
        // for(int num = 1; num < 256; num += 2)
        // {
        //   output[index] = num;
        //   index++;
        // }
        for(int i = 0; i < 128; i++)
        {
            // 0, 1, 2, 3, 4, 5 ... (index)
            // 1, 3, 5, 7, 9, 11 ...(number)
            output[i] = i * 2 + 1;
        }
        // 3. put the odd ones into the container

        // 4. return out the container
        return output;
    }

    public static void ShiftValues(int[] numbers)
    {
        for(int i = 1; i < numbers.Length; i++)
        {
            numbers[i - 1] = numbers[i];
        }

        numbers[numbers.Length - 1] = 0;
        // Given an integer array, say [1, 5, 10, 7, -2], 
        // Write a function that shifts each number by one to the front and adds '0' to the end. 
        // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
        // it should become [5, 10, 7, -2, 0].
    }

    public static object[] NumToString(int[] numbers)
    {
        object[] output = new object[numbers.Length];
        // Write a function that takes an integer array and returns an object array 
        // that replaces any negative number with the string 'Dojo'.
        // For example, if array "numbers" is initially [-1, -3, 2] 
        // your function should return an array with values ['Dojo', 'Dojo', 2].
        for(int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] < 0)
            {
                output[i] = "Dojo";
            }
            else
            {
                output[i] = numbers[i];
            }
        }

        return output;
    }
}