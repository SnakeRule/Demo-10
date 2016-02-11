using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_3
{
    class Lotto
    {
        public List<Numbers> numbers;
        Numbers lottoRow;

        public Lotto()
        {
            numbers = new List<Numbers>();
        }

        /// <summary>
        /// Used for drawing the lottery numbers
        /// </summary>
        /// <param name="draws"> The amount of draws selected </param>
        /// <param name="game"> Selected game type </param>
        public void drawNumbers(int draws, string game)
        {
            numbers.Clear();
            string row = "";
            Random rand = new Random();
            if(game == "Lotto") // Lotto mode
            {
                for(int i = 0; i < draws; i++)
                {
                    row = "";
                    row = row + "Row " + (i + 1) + ": ";
                    for (int u = 0; u < 7; u++)
                    {
                        row = row + rand.Next(1, 40) + " ";
                    }
                    lottoRow = new Numbers { RowNumbers = row };
                    AddNumber(lottoRow);
                }
            }

            if (game == "Viking Lotto") // Viking lotto mode
            {
                for (int i = 0; i < draws; i++)
                {
                    row = "";
                    row = row + "Row " + (i + 1) + ": ";
                    for (int u = 0; u < 6; u++)
                    {
                        row = row + rand.Next(1, 49) + " ";
                    }
                    lottoRow = new Numbers { RowNumbers = row };
                    AddNumber(lottoRow);
                }
            }

            if (game == "Eurojackpot") // Eurojackpot mode
            {
                for (int i = 0; i < draws; i++)
                {
                    row = "";
                    row = row + "Row " + (i + 1) + ": ";
                    for (int u = 0; u < 5; u++)
                    {
                        row = row + rand.Next(1, 51) + " ";
                    }
                    row = row + "Tähtinumerot: ";
                    for (int o = 0; o <2; o++)
                    {
                        row = row + rand.Next(1, 11) + " ";
                    }
                    lottoRow = new Numbers { RowNumbers = row };
                    AddNumber(lottoRow);
                }
            }
        }

        /// <summary>
        /// Method for adding a lotto row to the list
        /// </summary>
        /// <param name="row"></param>
        private void AddNumber(Numbers row)
        {
            numbers.Add(row);
        }

        /// <summary>
        /// Method for printing out all the lotto rows
        /// </summary>
        /// <returns></returns>
        public string PrintNumbers()
        {
            string AllNumbers = "";
            foreach(Numbers lottoRow in numbers)
            {
                AllNumbers = AllNumbers + lottoRow.RowNumbers + Environment.NewLine;
            }
            return AllNumbers;
        }
    }
}
