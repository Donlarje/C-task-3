using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
        bool game_play = true;

        while (game_play == true)
        {
            string difficulty = "";
            string difficulty_level = "";
            Console.Write("please select preferred difficulty level (EASY or MEDIUM or HARD): ");
            difficulty = Console.ReadLine();
            difficulty_level = difficulty.ToUpper();

            if (difficulty_level == "EASY")
            {
                int secret_number = new Random().Next(1, 10);
                int guess_count = 0;
                int guess_limit = 6;
                int guesses_left = 5;
                int guessing_range = 10;
                int guess = 0;

                while (guess_count < guess_limit)
                {
                    try
                    {
                        Console.Write("guess a number from 1-10: ");
                        guess = int.Parse(Console.ReadLine());

                        if (guess == secret_number)
                        {
                            Console.WriteLine("you got it right!");
                            game_play = false;
                            break;
                        }
                        else if (guess > guessing_range)
                        {
                            Console.WriteLine("your response should be a number ranging from 1-10");
                            Console.WriteLine("you have " + guesses_left + " guesses left");
                            guess_count++;
                            guesses_left--;
                        }
                        else
                        {
                            Console.WriteLine("that was wrong");
                            Console.WriteLine("you have " + guesses_left + " guesses left");
                            guess_count++;
                            guesses_left--;
                        } 
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Invalid value, please enter an integer(a positive whole number eg 1,2,3....)");
                        Console.WriteLine("you have " + guesses_left + " guesses left");
                        guess_count++;
                        guesses_left--;
                    }    
                }
                if (guess_count == guess_limit)
                    {
                    Console.WriteLine("Game over!");
                    Console.WriteLine("The correct answer is " + secret_number);
                    game_play = false;
                    }
            }
            else if (difficulty_level == "MEDIUM")
            {
                int secret_number = new Random().Next(1, 20);
                int guess_count = 0;
                int guess_limit = 4;
                int guesses_left = 3;
                int guessing_range = 20;
                int guess = 0;

                while (guess_count < guess_limit)
                {
                    try
                    {
                        Console.Write("guess a number from 1-20: ");
                        guess = int.Parse(Console.ReadLine());

                        if (guess == secret_number)
                        {
                            Console.WriteLine("you got it right!");
                            game_play = false;
                            break;
                        }
                        else if (guess > guessing_range)
                        {
                            Console.WriteLine("your response should be a number ranging from 1-20");
                            Console.WriteLine("you have " + guesses_left + " guesses left");
                            guess_count++;
                            guesses_left--;
                        }
                        else
                        {
                            Console.WriteLine("that was wrong");
                            Console.WriteLine("you have " + guesses_left + " guesses left");
                            guess_count++;
                            guesses_left--;
                        } 
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Invalid value, please enter an integer(a positive whole number eg 1,2,3....)");
                        Console.WriteLine("you have " + guesses_left + " guesses left");
                        guess_count++;
                        guesses_left--;
                    }    
                }
                if (guess_count == guess_limit)
                    {
                    Console.WriteLine("Game over!");
                    Console.WriteLine("The correct answer is " + secret_number);
                    game_play = false;
                    }
            }
            else if (difficulty_level == "HARD")
            {
                int secret_number = new Random().Next(1, 50);
                int guess_count = 0;
                int guess_limit = 3;
                int guesses_left = 2;
                int guessing_range = 50;
                int guess = 0;

                while (guess_count < guess_limit)
                {
                    try
                    {
                        Console.Write("guess a number from 1-50: ");
                        guess = int.Parse(Console.ReadLine());

                        if (guess == secret_number)
                        {
                            Console.WriteLine("you got it right!");
                            game_play = false;
                            break;
                        }
                        else if (guess > guessing_range)
                        {
                            Console.WriteLine("your response should be a number ranging from 1-50");
                            Console.WriteLine("you have " + guesses_left + " guesses left");
                            guess_count++;
                            guesses_left--;
                        }
                        else
                        {
                            Console.WriteLine("that was wrong");
                            Console.WriteLine("you have " + guesses_left + " guesses left");
                            guess_count++;
                            guesses_left--;
                        } 
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("Invalid value, please enter an integer(a positive whole number eg 1,2,3....)");
                        Console.WriteLine("you have " + guesses_left + " guesses left");
                        guess_count++;
                        guesses_left--;
                    }    
                }
                if (guess_count == guess_limit)
                    {
                    Console.WriteLine("Game over!");
                    Console.WriteLine("The correct answer is " + secret_number);
                    game_play = false;
                    }
            }
            else if (game_play == false)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid response. please type 'easy' to select EASY, 'medium' to select MEDIUM or 'hard' to select HARD");
            }
        }
        }
    }
}