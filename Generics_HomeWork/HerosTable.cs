using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HomeWork
{
    internal class HerosTable<T> where T : MainProp
    {
        public T[] HerosArray { get; set; }


        public HerosTable(int arrayNumber)
        {
            HerosArray = new T[arrayNumber];
        }

        /// <summary>
        /// indexer to get the knight in the given index position. if given an negetive number, runs a check on the array, and if all null return null  
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                // if index is higher then the array, start the count from zero again
                if (index  >= HerosArray.Length)
                {
                    if (index == HerosArray.Length)
                        return HerosArray[0];  
                    return HerosArray[index - 1 - HerosArray.Length];
                }

                // if given an negetive number, runs a check on the array, and if all null return null 
                if (index < 0)
                {
                    bool checkIfNull = true;

                    foreach (T knight in HerosArray)
                    {
                        if (knight != null)
                        {
                            checkIfNull = false;
                            break;
                        }

                    }

                    if (checkIfNull)
                        return null;
                    
                }

                switch (index)
                {
                    case 0:
                        return HerosArray[0];
                        break;

                    case 1:
                        return HerosArray[1];
                        break;

                    case 2:
                        return HerosArray[2];
                        break;

                    case 3:
                        return HerosArray[3];
                        break;

                    case 4:
                        return HerosArray[4];
                        break;

                    case 5:
                        return HerosArray[5];
                        break;

                    case 6:
                        return HerosArray[6];
                        break;

                    case 7:
                        return HerosArray[7];
                        break;

                    case 8:
                        return HerosArray[8];
                        break;

                    case 9:
                        return HerosArray[9];
                        break;

                    default:
                        return HerosArray[index];



                }
            }
        }


        /// <summary>
        /// insert the given knight to the KnightArray in the given index position
        /// </summary>
        /// <param name="index"></param>
        /// <param name="Hero"></param>
        public void Set(int index, T Hero)
        {
            HerosArray[index] = Hero;
        }


        /// <summary>
        /// Delete the knight in the given index position
        /// </summary>
        /// <param name="index"></param>
        public void Delete(int index)
        {
            HerosArray[index] = null;
        }


        /// <summary>
        /// return the number of Knights in the array
        /// </summary>
        /// <returns></returns>
        public int GetHerotNumber()
        {
            int number = 0;

            foreach (T knight in HerosArray)
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
        public T[] GetKnightArray()
        {
            T[] onlyHeroArray = new T[GetHerotNumber()];
            int index = 0;

            foreach (T hero in HerosArray)
            {
                if (hero != null)
                {
                    onlyHeroArray[index] = hero;
                    index++;
                }
            }
            
            return onlyHeroArray;
        }






    }
}
