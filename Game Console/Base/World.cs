using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Console.Base
{
    internal class World
    {
        public int Lines;

        public int Columns;

        private string[,] Map;

        public World(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;

            Map = new string[Lines, Columns];
        }
        public void Fill()
        {

            for(int i = 0; i < Lines; i++)
            {
                for(int j = 0; j < Columns; j++)
                {
                    if(i == 0 && j == 0)
                    {
                        Map[i,j] = "╔";
                    } 
                    else if(i == 0 && j == Columns - 1)
                    {
                        Map[i, j] = "╗";
                    } 
                    else if(i == Lines - 1 && j == 0)
                    {
                        Map[i, j] = "╚";
                    }
                    else if(i == Lines-1 && j == Columns - 1)
                    {
                        Map[i, j] = "╝";
                    }
                    else if(j == 0 || j == Columns - 1)
                    {
                        Map[i, j] = "║";
                    }
                    else if (i == 0 || i == Lines - 1)
                    {
                        Map[i, j] = "═";
                    } else
                    {
                        Map[i, j] = " ";
                    }

                }
            }
        }

        public void checkSequence(string word)
        {
            for(int i = 0; i < word.Length; i++)
            {
                Console.Write($"{word[i]}");
            }
            Console.WriteLine();
        }

        public int Draw(int line, int column, string phrase)
        {
            string newPhrase = phrase.Replace("\r\n", "\n");
            newPhrase = newPhrase.Replace("\r", "\n");
            newPhrase = newPhrase.Trim();

            int totalLines = 1;

            for (int col = column, pos = 0; pos < newPhrase.Length; col++, pos++)
            {
                char symbol = newPhrase[pos];
                if (symbol == '\n')
                {
                    line++;
                    col = column - 1;
                    totalLines++;
                }
                else
                {
                    Map[line, col] = symbol.ToString();
                }
            }

            return totalLines;
        }

        public void Print() {
            for (int i = 0; i < Lines; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write(Map[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
