using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForms
{
    class Path
    {
        string[] strList = new string[999];
        string[] path = new string[999];
        int aisleNum;
        int count = 0;
        public Path(string[] list)
        {
            strList = list;
            Console.Write("The List Order: ");
            for (int i = 0; i < strList.Count(); i++)
            {
                Console.Write(strList[i] + " ,");
            }
            Console.WriteLine();
            for (int i = 0; i < strList.Count(); i++)
            {
                Console.WriteLine(strList[i]);
            }
            for (int i = 0; i < strList.Count(); i++)
            {
                if (Aisle(strList[i]) == 1)
                {
                    if (checkAdjacent(strList, i) == false)
                    {
                        Console.WriteLine("First in new list is: " + strList[i]);
                        path[count] = strList[i];
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("First in new list is: " + strList[i]);
                        path[count] = strList[i];
                        count++;
                    }

                }
                if (Aisle(strList[i]) == 2)
                {
                    if (checkAdjacent(strList, i) == false)
                    {
                        Console.WriteLine("Next in new list is: " + strList[i]);
                        path[count] = strList[i];
                        count++;
                    }
                    else
                    {
                        if (Aisle(strList[i - 1]) == 1)
                        {

                            Console.WriteLine("Next in new list is " + strList[i]);
                            count++;
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
        string[] sortArr(string[] strArr, bool isUp)
        {
           string[] newStr = new string[strArr.Length];
            if (isUp)
            {
                for (int i = 0; i < strArr.Length; i++)
                {
                    locationChecker('y', strArr[i]);
                    
                }
            }
            return null;
        }
        int locationChecker(char xy, string str)
        {
            UserInterface values = new UserInterface();
            if (xy == 'x')
            {
                switch (str)
                {
                    case "Milk":
                        return values.Milk.Location.X;
                    case "Cheese":
                        return values.Cheese.Location.X;
                    case "Eggs":
                        return values.Eggs.Location.X;
                    case "Apples":
                        return values.Apples.Location.X;
                    case "Bananas":
                        return values.Bananas.Location.X;
                    case "Tomatoes":
                        return values.Tomatoes.Location.X;
                    case "Baked Beans":
                        return values.BakedBeans.Location.X;
                    case "Chopped Tomatoes":
                        return values.ChoppedTomatoes.Location.X;
                    case "Garlic":
                        return values.Garlic.Location.X;
                    case "Chilli Powder":
                        return values.ChilliPowder.Location.X;
                    case "Frozen Pizza":
                        return values.FrozenPizza.Location.X;
                    case "Ice Cream":
                        return values.IceCream.Location.X;
                    case "Dog Food":
                        return values.DogFood.Location.X;
                    case "Dog Toys":
                        return values.DogToys.Location.X;
                    case "Cat Food":
                        return values.CatFood.Location.X;

                    default:
                        return 0;
                }
            }

            else
            {
                switch (str)
                {
                    case "Milk":
                        return values.Milk.Location.Y;
                    case "Cheese":
                        return values.Cheese.Location.Y;
                    case "Eggs":
                        return values.Eggs.Location.Y;
                    case "Apples":
                        return values.Apples.Location.Y;
                    case "Bananas":
                        return values.Bananas.Location.Y;
                    case "Tomatoes":
                        return values.Tomatoes.Location.Y;
                    case "Baked Beans":
                        return values.BakedBeans.Location.Y;
                    case "Chopped Tomatoes":
                        return values.ChoppedTomatoes.Location.Y;
                    case "Garlic":
                        return values.Garlic.Location.Y;
                    case "Chilli Powder":
                        return values.ChilliPowder.Location.Y;
                    case "Frozen Pizza":
                        return values.FrozenPizza.Location.Y;
                    case "Ice Cream":
                        return values.IceCream.Location.Y;
                    case "Dog Food":
                        return values.DogFood.Location.Y;
                    case "Dog Toys":
                        return values.DogToys.Location.Y;
                    case "Cat Food":
                        return values.CatFood.Location.Y;
                    default:
                        return 0;
                }


            }
        }
            string adjacentPlus(string[] strList, int x)
            {
                if (Aisle(strList[x]) == Aisle(strList[x - 1]))
                {
                    return strList[x++];
                }
                return null;
            }
            bool checkAdjacent(string[] strList, int x)
            {
                if (Aisle(strList[x]) == Aisle(strList[x + 1]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            int Aisle(string str)
            {
                switch (str)
                {
                    case "Eggs":
                    case "Milk":
                    case "Cheese":
                        aisleNum = 1;
                        break;
                    case "Tomato":
                    case "Banana":
                    case "Apples":
                        aisleNum = 2;
                        break;
                    case "Chopped Tomatoes":
                    case "Baked Beans":
                    case "Chilli Powder":
                    case "Garlic":
                        aisleNum = 3;
                        break;
                    case "Frozen Pizza":
                    case "Ice Cream":
                        aisleNum = 4;
                        break;
                    case "Dog Toys":
                    case "Dog Food":
                    case "Cat Food":
                        aisleNum = 5;
                        break;
                    default:
                        aisleNum = 0;
                        Console.WriteLine("Error- item not found");
                        break;

                }
                return aisleNum;
            }

        }
    }

