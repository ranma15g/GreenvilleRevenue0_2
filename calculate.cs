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
      return "\n" + w12 + "\n" + w2 + "\n\n" + w3 + "\n\n" + w4 + "\n" + w5;

  }



  
    // Create the method GetMessage to display the message for option 1
  public string GetMessage()
  {
    // Create a set of strings to display the message
    string s1 = "Last year's competition had 122 contestants, and this year's has 426 contestants\n";

    string s2 = "Revenue expected this year is $10,650\n";

    string s3 = "It is true that this year's competition is bigger than last year's.\n";

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