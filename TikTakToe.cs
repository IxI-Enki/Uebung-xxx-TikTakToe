/*  Tik Tak Toe  --  Jan Ritt
 *  15.10.2023
 *  - make a curser move
 *  - forbid overwriting 
 *  - check for wins and ties
 */

using System;
using System.Text;

namespace TikTakToe
{
  public class Program
  {
    static void Main(string[] args)
    {
      char gameover = 'f';     //  game over condition t/f
      int abort = 0;           //  abort condition 0/1
      int choices = 0;         //  number of choices (turns)
      string player = "X";     //  starting player
      string curser = "-";     //  curser
      string xo1, xo2, xo3, xo4, xo5, xo6, xo7, xo8, xo9;                                                          //  curser fields
      string choiceXo1, choiceXo2, choiceXo3, choiceXo4, choiceXo5, choiceXo6, choiceXo7, choiceXo8, choiceXo9;    //  chosen fields
      xo1 = " "; xo2 = " "; xo3 = " "; xo4 = " "; xo5 = " "; xo6 = " "; xo7 = " "; xo8 = " "; xo9 = " ";                                                          //  empty fields
      choiceXo1 = " "; choiceXo2 = " "; choiceXo3 = " "; choiceXo4 = " "; choiceXo5 = " "; choiceXo6 = " "; choiceXo7 = " "; choiceXo8 = " "; choiceXo9 = " ";    //  
      xo5 = curser;            //  curser start position

      do    //  MAIN GAMELOOP  //
      {
        if (gameover == 'f' && abort != 1)
        {
          //  DRAW PLAYFIELD  //
          Console.Clear();
          Console.WriteLine();
          Console.WriteLine("    Tik - Tak - Toe");
          Console.WriteLine(" ---------------------");
          Console.WriteLine($"             Spieler {player}");
          Console.WriteLine();
          Console.WriteLine($"      {xo1}{choiceXo1}{xo1}|{xo2}{choiceXo2}{xo2}|{xo3}{choiceXo3}{xo3}");
          Console.WriteLine("      ---+---+--- ");
          Console.WriteLine($"      {xo4}{choiceXo4}{xo4}|{xo5}{choiceXo5}{xo5}|{xo6}{choiceXo6}{xo6}");
          Console.WriteLine("      ---+---+--- ");
          Console.WriteLine($"      {xo7}{choiceXo7}{xo7}|{xo8}{choiceXo8}{xo8}|{xo9}{choiceXo9}{xo9}");
          Console.WriteLine();
          Console.WriteLine(" [WASD]-Zeiger bewegen");
          Console.WriteLine(" [E]   -Feld wählen");
          Console.WriteLine(" [Q]   -Quit");
         
          //  INPUT  //
          char input;
          input = Console.ReadKey().KeyChar;
          Console.Clear();
          switch (char.ToUpper(input))
          {
            ////  W  ////
            case 'W':
                   if (curser == xo1)
              {
                xo7 = curser;
                xo1 = " ";
              }
              else if (curser == xo2)
              {
                xo8 = curser;
                xo2 = " ";
              }
              else if (curser == xo3)
              {
                xo9 = curser;
                xo3 = " ";
              }
              else if (curser == xo4)
              {
                xo1 = curser;
                xo4 = " ";
              }
              else if (curser == xo5)
              {
                xo2 = curser;
                xo5 = " ";
              }
              else if (curser == xo6)
              {
                xo3 = curser;
                xo6 = " ";
              }
              else if (curser == xo7)
              {
                xo4 = curser;
                xo7 = " ";
              }
              else if (curser == xo8)
              {
                xo5 = curser;
                xo8 = " ";
              }
              else if (curser == xo9)
              {
                xo6 = curser;
                xo9 = " ";
              }
              break;
            ////  A  ////
            case 'A':
                   if (curser == xo1)
              {
                xo3 = curser;
                xo1 = " ";
              }
              else if (curser == xo2)
              {
                xo1 = curser;
                xo2 = " ";
              }
              else if (curser == xo3)
              {
                xo2 = curser;
                xo3 = " ";
              }
              else if (curser == xo4)
              {
                xo6 = curser;
                xo4 = " ";
              }
              else if (curser == xo5)
              {
                xo4 = curser;
                xo5 = " ";
              }
              else if (curser == xo6)
              {
                xo5 = curser;
                xo6 = " ";
              }
              else if (curser == xo7)
              {
                xo9 = curser;
                xo7 = " ";
              }
              else if (curser == xo8)
              {
                xo7 = curser;
                xo8 = " ";
              }
              else if (curser == xo9)
              {
                xo8 = curser;
                xo9 = " ";
              }
              break;
            ////  S  ////
            case 'S':
                   if (curser == xo1)
              {
                xo4 = curser;
                xo1 = " ";
              }
              else if (curser == xo2)
              {
                xo5 = curser;
                xo2 = " ";
              }
              else if (curser == xo3)
              {
                xo6 = curser;
                xo3 = " ";
              }
              else if (curser == xo4)
              {
                xo7 = curser;
                xo4 = " ";
              }
              else if (curser == xo5)
              {
                xo8 = curser;
                xo5 = " ";
              }
              else if (curser == xo6)
              {
                xo9 = curser;
                xo6 = " ";
              }
              else if (curser == xo7)
              {
                xo1 = curser;
                xo7 = " ";
              }
              else if (curser == xo8)
              {
                xo2 = curser;
                xo8 = " ";
              }
              else if (curser == xo9)
              {
                xo3 = curser;
                xo9 = " ";
              }
              break;
            ////  D  ////
            case 'D':
                   if (curser == xo1)
              {
                xo2 = curser;
                xo1 = " ";
              }
              else if (curser == xo2)
              {
                xo3 = curser;
                xo2 = " ";
              }
              else if (curser == xo3)
              {
                xo1 = curser;
                xo3 = " ";
              }
              else if (curser == xo4)
              {
                xo5 = curser;
                xo4 = " ";
              }
              else if (curser == xo5)
              {
                xo6 = curser;
                xo5 = " ";
              }
              else if (curser == xo6)
              {
                xo4 = curser;
                xo6 = " ";
              }
              else if (curser == xo7)
              {
                xo8 = curser;
                xo7 = " ";
              }
              else if (curser == xo8)
              {
                xo9 = curser;
                xo8 = " ";
              }
              else if (curser == xo9)
              {
                xo7 = curser;
                xo9 = " ";
              }
              break;

            ////  E  ////
            case 'E':
                   if (curser == xo1 && choiceXo1 != "X" && choiceXo1 != "O")
              {
                choiceXo1 = player;
                choices = choices + 1;
                if (player == "X")
                {
                  player = "O";
                }
                else if (player == "O")
                {
                  player = "X";
                }
              }
              else if (curser == xo2 && choiceXo2 != "X" && choiceXo2 != "O")
              {
                choiceXo2 = player;
                choices = choices + 1;
                if (player == "X")
                {
                  player = "O";
                }
                else if (player == "O")
                {
                  player = "X";
                }
              }
              else if (curser == xo3 && choiceXo3 != "X" && choiceXo3 != "O")
              {
                choiceXo3 = player;
                choices = choices + 1;
                if (player == "X")
                {
                  player = "O";
                }
                else if (player == "O")
                {
                  player = "X";
                }
              }
              else if (curser == xo4 && choiceXo4 != "X" && choiceXo4 != "O")
              {
                choiceXo4 = player;
                choices = choices + 1;
                if (player == "X")
                {
                  player = "O";
                }
                else if (player == "O")
                {
                  player = "X";
                }
              }
              else if (curser == xo5 && choiceXo5 != "X" && choiceXo5 != "O")
              {
                choiceXo5 = player;
                choices = choices + 1;
                if (player == "X")
                {
                  player = "O";
                }
                else if (player == "O")
                {
                  player = "X";
                }
              }
              else if (curser == xo6 && choiceXo6 != "X" && choiceXo6 != "O")
              {
                choiceXo6 = player;
                choices = choices + 1;
                if (player == "X")
                {
                  player = "O";
                }
                else if (player == "O")
                {
                  player = "X";
                }
              }
              else if (curser == xo7 && choiceXo7 != "X" && choiceXo7 != "O")
              {
                choiceXo7 = player;
                choices = choices + 1;
                if (player == "X")
                {
                  player = "O";
                }
                else if (player == "O")
                {
                  player = "X";
                }
              }
              else if (curser == xo8 && choiceXo8 != "X" && choiceXo8 != "O")
              {
                choiceXo8 = player;
                choices = choices + 1;
                if (player == "X")
                {
                  player = "O";
                }
                else if (player == "O")
                {
                  player = "X";
                }
              }
              else if (curser == xo9 && choiceXo9 != "X" && choiceXo9 != "O")
              {
                choiceXo9 = player;
                choices = choices + 1;
                if (player == "X")
                {
                  player = "O";
                }
                else if (player == "O")
                {
                  player = "X";
                }
              }
              else
              {
                Console.WriteLine("Ungültige Eingabe");
              }
              break;
            ////  Q  ////
            case 'Q':
              abort = 1;
              Console.WriteLine("Quit");
              break;

            default:
              //  Fall-back code for other input
              Console.WriteLine("Ungültige Eingabe");
              break;
          }
        }
        //  WIN CONDITIONS  //
        //  X wins
        if ((choiceXo1 == "X" && choiceXo2 == "X" && choiceXo3 == "X") || (choiceXo4 == "X" && choiceXo5 == "X" && choiceXo6 == "X") ||
            (choiceXo7 == "X" && choiceXo8 == "X" && choiceXo9 == "X") || (choiceXo1 == "X" && choiceXo4 == "X" && choiceXo7 == "X") ||
            (choiceXo2 == "X" && choiceXo5 == "X" && choiceXo8 == "X") || (choiceXo3 == "X" && choiceXo6 == "X" && choiceXo9 == "X") ||
            (choiceXo1 == "X" && choiceXo5 == "X" && choiceXo9 == "X") || (choiceXo3 == "X" && choiceXo5 == "X" && choiceXo7 == "X"))
        {
          gameover = 't';
          Console.WriteLine("Spieler X hat gewonnen!");
        }
        //  O wins
        else if ((choiceXo1 == "O" && choiceXo2 == "O" && choiceXo3 == "O") || (choiceXo4 == "O" && choiceXo5 == "O" && choiceXo6 == "O") ||
                 (choiceXo7 == "O" && choiceXo8 == "O" && choiceXo9 == "O") || (choiceXo1 == "O" && choiceXo4 == "O" && choiceXo7 == "O") ||
                 (choiceXo2 == "O" && choiceXo5 == "O" && choiceXo8 == "O") || (choiceXo3 == "O" && choiceXo6 == "O" && choiceXo9 == "O") ||
                 (choiceXo1 == "O" && choiceXo5 == "O" && choiceXo9 == "O") || (choiceXo3 == "O" && choiceXo5 == "O" && choiceXo7 == "O"))
        {
          gameover = 't';
          Console.WriteLine("Spieler O hat gewonnen!");
        }
        //  all possible choices done without a winner
        else if (choices == 9)
        {
          gameover = 't';
          Console.WriteLine("Unentschieden!");
        }
      }
      while ((gameover != 't')&&(abort !=1));
      //  END - GAMELOOP  //
      Console.WriteLine("[Enter] um das Spiel zu Beenden.");    //  end program
      Console.ReadLine();                                       //
    }
  }
}
