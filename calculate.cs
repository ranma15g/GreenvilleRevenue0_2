public class calCulate
{

  public string Welcome()
  {  
      string w1 = ("************************************");

      string w12 = ("*  The stars shine in Greenville.  *");

      string w2 = ("************************************");

      string w3 = ("Please Enter the following number below from the following menu:");

      string w4 = ("1. CALCULATE Greenville Revenue Year-Over-Year");

      string w5 = ("2. Exit");

      string wFinal = w1 + "\n" + w12 + "\n" + w2 + "\n\n" + w3 + "\n\n" + w4 + "\n" + w5;

      return wFinal;
  }


  public string GetMessage()
  {
    string s1 = "Last year's competition had 122 contestants, and this year's has 426 contestants\n";

    string s2 = "Revenue expected this year is $10,650\n";

    string s3 = "It is true that this year's competition is bigger than last year's.\n";

    return s1 + s2 + s3;
  }


  public string Ciao()
  {
    string e1 = "Thank you for using the Greenville Revenue App, good-bye!";

    return e1;
  }



}