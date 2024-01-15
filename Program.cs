using GuesNumber.Classes;

Random random = new Random();
byte count;
byte Guess =5;
byte RandomNumber=Convert.ToByte(random.Next(0,101));
Console.WriteLine("You have 5 chances to guess the number (0-100).");
for (int i = 0; i < Guess; i++)
    {
     Console.WriteLine($"Guess your chance ({i+1}) ?");
     count = Convert.ToByte(Console.ReadLine());
     if (count > RandomNumber)
     {
     Console.WriteLine("Your number is greater than the selected number.");
     }else if (count < RandomNumber)
     {
         Console.WriteLine("Your number is smaller than the selected number.");
     }else{      
         Console.BackgroundColor=ConsoleColor.Green;
         switch(i) 
         {
           case 0:
           Console.Write($"It is fantastic!! You have the highest intelligence. :o number is => {RandomNumber}\n"); 
             break;
           case 1:
           Console.Write($"fantastic!! You have great intelligence. number is => {RandomNumber}\n"); 
             break;
           case 2:
           Console.Write($"I was shocked how you guessed! number is => {RandomNumber}\n"); 
             break;
           case 3:
           Console.Write($"It was not bad, you can call yourself smart :) number is => {RandomNumber}\n"); 
             break;
           case 4:
           Console.Write($"It was good, but you could have answered sooner :> number is => {RandomNumber}\n"); 
             break;
           default:
           Console.Write($"I congratulate you for your hard work. number is => {RandomNumber}\n"); 
             break;
         }
        Console.ResetColor();   
     } 
     if (count==RandomNumber)
     {
      break;   
     }
       if (i==0 && count!=RandomNumber)
     {
           Console.BackgroundColor=ConsoleColor.Yellow;
           Console.Write("Do you want some help ? (y/n) \n"); 
           Console.ResetColor();
           string another =Convert.ToString(Console.ReadLine()??"");
           another= another.ToLower();
            if (another=="y")
              {
               Console.BackgroundColor=ConsoleColor.Yellow;
               Rounding.RoundNumber(RandomNumber);
               Console.Write($"The number is between {Rounding.floor} and { Rounding.ceiling} .\n");
               Console.ResetColor();
              }
     }
     if (i>3 && count!=RandomNumber)
     {
           Console.BackgroundColor=ConsoleColor.Red;
           Console.Write("You want another chance ? (y/n)\n"); 
           string another =Convert.ToString(Console.ReadLine()??"");
           another= another.ToLower();
           Console.ResetColor();
            if (another=="y")
              {
                Guess++;
              }else
              {
                 Console.BackgroundColor=ConsoleColor.Blue;
                 Console.Write($"You are brainless number is {RandomNumber} .\n");
                  Console.ResetColor();
              }
     }

    }
