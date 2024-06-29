using System;

class Program {
  public static void Main (string[] args) {

    calCulate cobj = new calCulate();

    while(true)

    {
      var intro = cobj.Welcome();

      Console.WriteLine(intro);

      var choice = Console.ReadLine();



      if (choice == "1") 
      {
        var answer = cobj.GetMessage();

        Console.WriteLine("\n" + answer);
      }



      if (choice == "2")
      {
        var goodBi = cobj.Ciao();

        Console.WriteLine("\n" + goodBi);

        break;
      }


    }
}

}