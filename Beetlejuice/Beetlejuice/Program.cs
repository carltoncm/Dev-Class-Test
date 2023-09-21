using System;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("You know, you look like somebody I can relate to...");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("I was just wondering-can you help me get out of here?");
var userInput = Console.ReadLine();
bool gameOver = false;
while (!gameOver)
{
    if (userInput.ToLower() == "yes")
    {
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("In order to do that, you gotta say my name 3 times...");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("I know!Let's play a guessing game...what's that famous Volkswagen car?");
        userInput = Console.ReadLine();

        if (userInput.ToLower() == "beetle")
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Perfect! Now the second part...what's that morning drink? Apple...orange...?");
            userInput = Console.ReadLine();

            if (userInput.ToLower() == "juice")
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Now put 'em together....");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "beetlejuice")
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("EXCELLENT-say it again baby...");
                    userInput = Console.ReadLine();

                    if (userInput.ToLower() == "beetlejuice")
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("AH! You said it twice, now say it one more time....");
                        userInput = Console.ReadLine();

                        if (userInput.ToLower() == "beetlejuice")
                        {
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(
                                 "#  #######  #####      #####  #     # ####### #     # ####### ### #     # #######    ######     #    ######  #     # ###" +
                                 "#     #    #     #    #     # #     # #     # #  #  #    #     #  ##   ## #          #     #   # #   #     #  #   #  ###" +
                                 "#     #    #          #       #     # #     # #  #  #    #     #  # # # # #          #     #  #   #  #     #   # #   ###" +
                                 "#     #     #####      #####  ####### #     # #  #  #    #     #  #  #  # #####      ######  #     # ######     #     # " +
                                 "#     #          #          # #     # #     # #  #  #    #     #  #     # #          #     # ####### #     #    #       " +
                                 "#     #    #     #    #     # #     # #     # #  #  #    #     #  #     # #          #     # #     # #     #    #    ###" +
                                 "#     #     #####      #####  #     # #######  ## ##     #    ### #     # #######    ######  #     # ######     #    ###"       
                                );
                            gameOver = true;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("You haven't seen the last of me! >:(");
                            gameOver = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("One of these days you'll slip up...one of these days...");
                        gameOver = true;
                    }
                }
                else
                {
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Well, aren't you the dullest knife in the drawer...");
                    gameOver = true;
                }
            }
            else
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Maybe you're not as useful as I thought...alright, I'll give you one more shot...");
            }
        }
        else
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("I'll let that one slide...want to try again?");
            Console.WriteLine("");
        }
    }
}

