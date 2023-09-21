﻿////// Blackjack Game
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8; // Enable UTF-8 encoding for special symbols

//        Console.WriteLine("Welcome to Console Blackjack!");

//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("\x1b[32m"); // Set text color to green

//            // Initialize a deck of cards and shuffle it.
//            var deck = InitializeDeck();
//            ShuffleDeck(deck);

//            // Initialize player and dealer hands.
//            var playerHand = new List<Card>();
//            var dealerHand = new List<Card>();

//            // Deal the initial two cards to the player and the dealer.
//            playerHand.AddRange(DealCards(deck, 2));
//            dealerHand.AddRange(DealCards(deck, 2));

//            // Show player's hand and one of the dealer's cards.
//            Console.WriteLine($"Your hand: {string.Join(", ", playerHand)} (Total: {CalculateHandValue(playerHand)})");
//            Console.WriteLine($"Dealer's hand: {dealerHand[0]} and [Hidden]");

//            // Player's turn
//            while (true)
//            {
//                Console.WriteLine("Choose an option: (1) Hit or (2) Stand");
//                if (int.TryParse(Console.ReadLine(), out int choice))
//                {
//                    if (choice == 1)
//                    {
//                        playerHand.AddRange(DealCards(deck, 1));
//                        Console.WriteLine($"Your hand: {string.Join(", ", playerHand)} (Total: {CalculateHandValue(playerHand)})");

//                        if (CalculateHandValue(playerHand) > 21)
//                        {
//                            Console.WriteLine("\x1b[31mBust! You lose."); // Set text color to red
//                            break;
//                        }
//                    }
//                    else if (choice == 2)
//                    {
//                        break;
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Invalid input. Please enter 1 or 2.");
//                }
//            }

//            // Dealer's turn
//            while (CalculateHandValue(dealerHand) < 17)
//            {
//                dealerHand.AddRange(DealCards(deck, 1));
//            }

//            Console.WriteLine($"Dealer's hand: {string.Join(", ", dealerHand)} (Total: {CalculateHandValue(dealerHand)})");

//            // Determine the winner
//            int playerValue = CalculateHandValue(playerHand);
//            int dealerValue = CalculateHandValue(dealerHand);

//            if (playerValue > 21)
//            {
//                Console.WriteLine("\x1b[31mYou busted. Dealer wins."); // Set text color to red
//            }
//            else if (dealerValue > 21 || playerValue > dealerValue)
//            {
//                Console.WriteLine("\x1b[32mYou win!"); // Set text color to green
//            }
//            else if (dealerValue > playerValue)
//            {
//                Console.WriteLine("\x1b[31mDealer wins."); // Set text color to red
//            }
//            else
//            {
//                Console.WriteLine("\x1b[33mIt's a tie!"); // Set text color to yellow
//            }

//            // Reset text color
//            Console.ResetColor();

//            // Ask if the player wants to play again
//            Console.WriteLine("Do you want to play again? (yes/no)");
//            string playAgain = Console.ReadLine();
//            if (!playAgain.Equals("yes", StringComparison.OrdinalIgnoreCase))
//            {
//                break;
//            }
//        }

//        Console.WriteLine("Thanks for playing!");
//    }
//    static List<Card> InitializeDeck()
//    {
//        var ranks = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
//        var suits = new List<string> { "Hearts", "Diamonds", "Clubs", "Spades" };
//        var deck = new List<Card>();

//        foreach (var suit in suits)
//        {
//            foreach (var rank in ranks)
//            {
//                deck.Add(new Card(rank, suit));
//            }
//        }

//        return deck;
//    }

//    static void ShuffleDeck(List<Card> deck)
//    {
//        Random rng = new Random();
//        int n = deck.Count;
//        while (n > 1)
//        {
//            n--;
//            int k = rng.Next(n + 1);
//            Card value = deck[k];
//            deck[k] = deck[n];
//            deck[n] = value;
//        }
//    }

//    static List<Card> DealCards(List<Card> deck, int numCards)
//    {
//        var cards = deck.Take(numCards).ToList();
//        deck.RemoveRange(0, numCards);
//        return cards;
//    }

//    static int CalculateHandValue(List<Card> hand)
//    {
//        int value = 0;
//        int numAces = 0;

//        foreach (var card in hand)
//        {
//            if (card.Rank == "A")
//            {
//                value += 11;
//                numAces++;
//            }
//            else if (card.Rank == "K" || card.Rank == "Q" || card.Rank == "J")
//            {
//                value += 10;
//            }
//            else
//            {
//                value += int.Parse(card.Rank);
//            }
//        }

//        // Handle aces as 1 if necessary to avoid busting
//        while (value > 21 && numAces > 0)
//        {
//            value -= 10;
//            numAces--;
//        }

//        return value;
//    }
//}
//class Card
//{
//    public string Rank { get; }
//    public string Suit { get; }

//    public Card(string rank, string suit)
//    {
//        Rank = rank;
//        Suit = suit;
//    }

//    public override string ToString()
//    {
//        return $"{Rank} of {Suit}";
//    }
//}
//class card
//{
//    public string rank { get; }
//    public string suit { get; }

//    public card(string rank, string suit)
//    {
//        rank = rank;
//        suit = suit;
//    }

//    public override string ToString()
//    {
//        return $"{rank} of {suit}";
//    }
//}


//// Hangman Game
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordList = new List<string>
            {
                "spaghetti",
                "longitude",
                "hemisphere",
                "confusion",
                "galaxy",
                "universal",
                "eloquent"
            };

            Random random = new Random();
            string secretWord = wordList[random.Next(wordList.Count)];
            char[] guessedWord = new char[secretWord.Length];

            // Initialize guessedWord with underscores
            for (int i = 0; i < secretWord.Length; i++)
            {
                guessedWord[i] = '_';
            }

            int attempts = 6;
            bool gameOver = false;

            Console.WriteLine("Welcome to Hangman!");

            while (!gameOver)
            {
                Console.WriteLine("\nSecret Word: " + string.Join(" ", guessedWord));
                Console.WriteLine("Attempts left: " + attempts);
                DrawHangman(6 - attempts);

                Console.Write("Guess a letter: ");
                char guess = Console.ReadLine().ToLower()[0];

                if (secretWord.Contains(guess))
                {
                    for (int i = 0; i < secretWord.Length; i++)
                    {
                        if (secretWord[i] == guess)
                        {
                            guessedWord[i] = guess;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect guess!");
                    attempts--;

                    if (attempts == 0)
                    {
                        Console.WriteLine("\nYou ran out of attempts. The word was: " + secretWord);
                        gameOver = true;
                    }
                }

                if (!guessedWord.Contains('_'))
                {
                    Console.WriteLine("\nCongratulations! You guessed the word: " + secretWord);
                    gameOver = true;
                }
            }

            Console.WriteLine("Thanks for playing Hangman!");
        }

        static void DrawHangman(int incorrectGuesses)
        {
            string[] hangmanArt =
            {
                "  +---+",
                "  |   |",
                "  |   |",
                "  |    ",
                "  |    ",
                "  |    ",
                "======="
            };

            switch (incorrectGuesses)
            {
                case 1:
                    hangmanArt[2] = "  |   O";
                    break;
                case 2:
                    hangmanArt[3] = "  |   O" + Environment.NewLine +
                                    "  |   |";
                    break;
                case 3:
                    hangmanArt[3] = "  |   O" + Environment.NewLine +
                                    "  |  /|";
                    break;
                case 4:
                    hangmanArt[3] = "  |   O" + Environment.NewLine +
                                    "  |  /|" + Environment.NewLine +
                                    "  |  / ";
                    break;
                case 5:
                    hangmanArt[4] = "  |   O  " + Environment.NewLine +
                                    "  |  /|\\" + Environment.NewLine +
                                    "  |  /   ";
                    break;
                case 6:
                    hangmanArt[4] = "  |   O  " + Environment.NewLine +
                                    "  |  /|\\" + Environment.NewLine +
                                    "  |  / \\";
                    break;
            }

            foreach (string line in hangmanArt)
            {
                Console.WriteLine(line);
            }
        }
    }
}






