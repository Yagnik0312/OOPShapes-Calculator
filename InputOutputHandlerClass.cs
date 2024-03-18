using System;
namespace Shape_And_Its_Derivatives
{
    /// <summary>
    /// Contains method for input and output methodss
    /// </summary>
    class InputOutputHandlerClass
    {
        /// <summary>
        /// Input method to take input from user with validation
        /// </summary>
        /// <returns>perameters</returns>
        public static double InputData()
        {
            while (true)
            {
                double maxLimit = 99999999999999;
                double output;
                bool isValidInput = double.TryParse(Console.ReadLine(), out output);
                if (!isValidInput)
                {
                    Console.WriteLine(DisplayMessageConst.WrongInputForProcessMessage);
                    continue;
                }
                else if(output<=0)
                {
                    Console.WriteLine(DisplayMessageConst.NagetiveNumberExceptionMessage);
                    continue;
                }
                else if(output>maxLimit)
                {
                    Console.WriteLine(DisplayMessageConst.LargeInputErrorMessage, maxLimit);
                    continue;
                }
                else
                {
                    return output;
                }
            }
        }

        /// <summary>
        /// Method to input Process id in Enum
        /// </summary>
        /// <returns>Process enum for next process</returns>
        public static EnumsForShape EnumInputMethod()
        {
            EnumsForShape EnumForNextProcessInput;
            while (true)
            {
                bool isValidInput = false;
                isValidInput = Enum.TryParse(Console.ReadLine(), out EnumForNextProcessInput);
                if (isValidInput == false)
                {
                    Console.WriteLine(DisplayMessageConst.WrongInputForProcessMessage);
                    continue;
                }
                else
                {
                    break;
                }
            }
            return EnumForNextProcessInput;
        }

        /// <summary>
        /// Method to print Object Properties 
        /// </summary>
        /// <param name="objectOfShape">Object</param>
        public static void PrintObjectProperties(Shape objectOfShape) 
        {
            Console.WriteLine(DisplayMessageConst.serialNumberMessage,objectOfShape.SerialNumberOfObject);
            Console.WriteLine(DisplayMessageConst.CountOfLiveObjectMessage, objectOfShape.LiveObject);
            objectOfShape.DisplayClassName();
        }

        /// <summary>
        /// Method to print area of shape
        /// </summary>
        /// <param name="areaOfShape">Area</param>
        /// <param name="enumForProcessMenu">Shape type in enum</param>
        public static void PrintPerimeterOfObject(decimal areaOfShape , EnumsForShape enumForProcessMenu)
        {
            Console.WriteLine(DisplayMessageConst.AreaOfShapeMessage, enumForProcessMenu, areaOfShape);
        }

        /// <summary>
        /// Method to print perimeter of shape
        /// </summary>
        /// <param name="perimeterOfShape">Perimeter of Shape</param>
        /// <param name="enumForProcessMenu">Shape type in Enum</param>
        public static void PrintAreaOfObject(decimal perimeterOfShape, EnumsForShape enumForProcessMenu)
        {
            Console.WriteLine(DisplayMessageConst.PerimeterOfShapeMessage, enumForProcessMenu, perimeterOfShape);
        }
    }






}
