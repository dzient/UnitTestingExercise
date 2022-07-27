using System;
//-----------------------------------------------------------------
// UnitTesting Exercise
//
// Name: David Zientara
// Date: 7-26-2022
// Comments: An exercise in using unit testing
// Made changes per the instructions
//-----------------------------------------------------------------
namespace UnitTestingExercise
{
    public class Calculator
    {
        // Step 1: Add a reference to your UnitTestingExercise project:

        // Right-click on the 'Dependencies' folder in your UnitTestingExercise.Tests project
        // and add your reference to the UnitTestingExercise project



        // Step 2: Create an Add method that accepts 3 integers, adds those integers, and returns an integer
        //For Example:
        //==================================================
        // Add
        // Method takes three integers and returns the sum
        // PARAMS: num1,num2,num3 (ints)
        // RETURNS: Sum of num1,num2,and num3
        //===================================================
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }


        // Step 3: Navigate to the UnitTests.cs file and complete the AddTest unit test method - DONE


        // Step 4: 
        // Create a Subtract method that accepts 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend - DONE
        //==================================================
        // Subtract
        // Method takes two integers and returns the difference
        // PARAMS: minuend, subtrhend (ints)
        // RETURNS: Difference between them
        //===================================================
        public int Subtract(int minuend, int subtrhend)
        {
            return minuend - subtrhend;
        }


        // Step 5: Navigate to the UnitTests.cs file and complete the SubtractTest unit test method


        // Step 6: 
        // Create a Multiply method that passes 2 integers - DONE
        //================================================================
        // Multiply
        // Method takes two integers and returns the integers multiplied 
        // to each other
        // PARAMS: num1 and num2(ints)
        // RETURNS: Difference between them
        //================================================================
        public int Multiply(int num1,int num2)
        {
            return num1*num2;
        }


        // Step 7: Navigate to the UnitTests.cs file and complete the MultiplyTest unit test method 


        // Step 8: 
        // Create a Divide method that passes 2 integers - DONE
        //================================================================
        // Divide
        // Method takes two integers and returns one number divided  
        // into the other
        // PARAMS: num1 and num2(ints)
        // RETURNS: num1/num2
        //================================================================
        public int Divide(int num1,int num2)
        {
            return (num1/ num2);
        }

        // Step 9: Navigate to the UnitTests.cs file and complete the DivideTest unit test method 


        //*****NOW RUN ALL OF YOUR TESTS*********//
    }
}
