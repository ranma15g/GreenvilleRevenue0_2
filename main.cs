using System;

class Program {
  public static void Main (string[] args) {
    // Instantiate an object cobj of the class calCulate
    calCulate cobj = new calCulate();

    // Create an infinite loop to display the menu until user exits
    while(true)

    {
      // Access the Welcome method from the calCulate class in the cobj object to return a value for the menu
      var intro = cobj.Welcome();

      // Display the menu
      Console.WriteLine(intro);

      // Receive the user's input
      var choice = Console.ReadLine();


      // If the user chooses option 1
      if (choice == "1") 
      {
        // Access the GetMessage method in the cobj object to return a calculation message
        var answer = cobj.GetMessage();

        // we display the message
        Console.WriteLine("\n" + answer);
      }

      
      // if the user chooses option 2
      else if (choice == "2")
      {
        // Access the Ciao method in the cobj object to return a good bye message to be displayed

        var goodBi = cobj.Ciao();

        // display the good bye message
        Console.WriteLine("\n" + goodBi);

        // exit the program
        break;
      }

      
      // if the user chooses an option that is not 1 or 2
      else
      {
        // Explain to them that that is not a valid choice
        Console.WriteLine("\n Sorry that is not a valid choice please try again");
      }

    }
}

}