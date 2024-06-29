using System;
using System.Globalization;


// Create the class calCulate to display messages for the user based on input
public class calCulate
{

  // Create the method Welcome to display the menu
  public string Welcome()
  {  

      // Create a number of strings to display the menu
      string w1 = ("************************************");

      string w12 = ("*  The stars shine in Greenville.  *");

      string w2 = ("************************************");

      string w3 = ("Please Enter the following number below from the following menu:");

      string w4 = ("1. CALCULATE Greenville Revenue Year-Over-Year");

      string w5 = ("2. Exit");

      // Return the strings representing the menu
      return "\n" + w1 + "\n" + w12 + "\n" + w2 + "\n\n" + w3 + "\n\n" + w4 + "\n" + w5;

  }
  
  // Create the method GetMessage to display the message for option 1
  public string GetMessage()
  {

  // Ask the user for last year's number of contestants
  Console.Write("Please enter last years number of contestants :");

    // Receive the user's input on last year's contestants
    string lastYear = Console.ReadLine();

    // Declare a variable to store the last year's contestants in Int form
    int lastYearInt;

    // While the user continues to not enter a number
    while (int.TryParse(lastYear, out lastYearInt) == false)
    {
      // Display an error message
      Console.WriteLine("Sorry, that's not a number, try again:");

      // Ask the user for last year's number of contestants again
      lastYear = Console.ReadLine();// Conversion successful
    }


    // Ask the user for this year's number of contestants
    Console.Write("Please enter this years number of contestants :");

    // Receive the user's input on this year's contestants
    string thisYear = Console.ReadLine();

    // Declare a variable to store this year's contestants in Int form
    int thisYearInt;

    // While the user continues to not enter a number
    while (int.TryParse(thisYear, out thisYearInt) == false)
    {
      // Display an error message
      Console.WriteLine("Sorry, that's not a number, try again:");

      // Ask the user for this year's number of contestants again
      thisYear = Console.ReadLine();// Conversion successful
    }


    
    // Create a set of strings to display the message
    string s1 = "Last year's competition had " + lastYearInt + " contestants, and this year's competition has " + thisYearInt + " contestants\n";

    // Initialize a variable to store the revenue based on the number of contestants`this year
    int revenue = thisYearInt * 25;

    string formattedAmount1 = revenue.ToString("C0", CultureInfo.CurrentCulture);

    // Initialize a string to display this year's revenue
    string s2 = "Revenue expected this year is " + formattedAmount1 + "\n";

    // Declare a variable to compare last year's competition against this year's competition
    string s3;

    // if last year's competition is less than this yera's competition
    if (lastYearInt < thisYearInt)
    // then s3 is a string that messages that to the user
    { s3 = "It is true that this year's competition is bigger than last year's.\n";}

    else // if last year's competition is greater than this yera's competition
    // then s3 is a string that messages that to the user
    { s3 = "It is false that this year's competition is bigger than last year's.\n";}

    // Return the strings representing the message when the user selects input 1
    return s1 + s2 + s3;
  }


  
  // Create the method Ciao to display the good bye message
  public string Ciao()
  {
    // Return the good bye message for the user
    return "Thank you for using the Greenville Revenue App, good-bye!";

  }



}