using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HomeWork
{
    internal class HerosTable
    {
        public Knight[] KnightArray { get; set; }


        public HerosTable(int arrayNumber)
        {
            KnightArray = new Knight[arrayNumber];
        }

        /// <summary>
        /// indexer to get the knight in the given index position. if given an negetive number, runs a check on the array, and if all null return null  
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object this[int index]
        {
            get
            {
                // if index is higher then the array, start the count from zero again
                if (index  >=KnightArray.Length)
                {
                    if (index == KnightArray.Length)
                        return KnightArray[0];  
                    return KnightArray[index - 1 - KnightArray.Length];
                }

                // if given an negetive number, runs a check on the array, and if all null return null 
                if (index < 0)
                {
                    bool checkIfNull = true;

                    foreach (Knight knight in KnightArray)
                    {
                        if (knight != null)
                        {
                            checkIfNull = false;
                            break;
                        }

                    }

                    if (checkIfNull)
                        return null;
                    else
                        return "Array is not null";
                }

                switch (index)
                {
                    case 0:
                        return KnightArray[0];
                        break;

                    case 1:
                        return KnightArray[1];
                        break;

                    case 2:
                        return KnightArray[2];
                        break;

                    case 3:
                        return KnightArray[3];
                        break;

                    case 4:
                        return KnightArray[4];
                        break;

                    case 5:
                        return KnightArray[5];
                        break;

                    case 6:
                        return KnightArray[6];
                        break;

                    case 7:
                        return KnightArray[7];
                        break;

                    case 8:
                        return KnightArray[8];
                        break;

                    case 9:
                        return KnightArray[9];
                        break;

                    default:
                        return "Max Knight Reached";



                }
            }
        }


        /// <summary>
        /// insert the given knight to the KnightArray in the given index position
        /// </summary>
        /// <param name="index"></param>
        /// <param name="knight"></param>
        public void Set(int index, Knight knight)
        {
            KnightArray[index] = knight;
        }


        /// <summary>
        /// Delete the knight in the given index position
        /// </summary>
        /// <param name="index"></param>
        public void Delete(int index)
        {
            KnightArray[index] = null;
        }


        /// <summary>
        /// return the number of Knights in the array
        /// </summary>
        /// <returns></returns>
        public int GetKnightNumber()
        {
            int number = 0;

            foreach (Knight knight in KnightArray)
            {
                if (knight != null)
                    number++;
            }

            return number;
        }

        /// <summary>
        /// return a Knight only array with no nulls
        /// </summary>
        /// <returns></returns>
        public Knight[] GetKnightArray()
        {
            Knight[] onlyKnightArray = new Knight[GetKnightNumber()];
            int index = 0;

            foreach (Knight knight in KnightArray)
            {
                if (knight != null)
                {
                    onlyKnightArray[index] = knight;
                    index++;
                }
            }
            
            return onlyKnightArray;
        }






    }
}
