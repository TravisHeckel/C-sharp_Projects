using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {

        //----------------------ARRAY'S-------------------------------------//use when you have a fixed quantity

        //int[] numArray = new int[5]; //This is a standard way of setting up an array. (remember we limit how big the array can be here)
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300}; //this is another way to setup the same array. (remember we limit how big the array can be here)

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300}; //This is even faster and does the same thing as the above options. (remember we limit how big the array can be here)

        //numArray2[5] = 650;

        //Console.WriteLine(numArray[3]);
        //Console.WriteLine(numArray1[2]);
        //Console.WriteLine(numArray2[5]);


        //-----------------------BYTE ARRAY-----------------------------------//use to store a large quantity of items

        byte[] byteArray = new byte[3000]; //This initalizes the size of the array

        //-------------------------LISTS--------------------------------------

        List<string> intList = new List<string>();//This list allows more versatility and to edit items by their value and not the space they are in.

        intList.Add("Hello"); //you can do string or int
        intList.Add("Hello1");
        intList.Remove("Hello1");


        Console.WriteLine(intList[0]);

        Console.ReadLine();
    }
}