using System;
namespace Shape_And_Its_Derivatives
{
    /// <summary>
    /// class whic contains menu metthod and data processing methods
    /// </summary>
    class TaskHandlerClass
    {
        /// <summary>
        /// Method to loop menu after one shape calculation 
        /// </summary>
        public static void MenuLooper()
        {
            while (true)
            {
                if (ServicesWithMenu())
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }

        /// <summary>
        /// method contains menu and processes according to menu
        /// </summary>
        /// <returns>Menu call or exit call</returns>
        private static Boolean ServicesWithMenu ()
        {
            Console.WriteLine(DisplayMessageConst.NextProcessMenuRectangleMessage, (int)EnumsForShape.Rectangle);
            Console.WriteLine(DisplayMessageConst.NextProcessMenuOvalMessage, (int)EnumsForShape.Oval);
            Console.WriteLine(DisplayMessageConst.NextProcessMenuCircleeMessage, (int)EnumsForShape.Circle);
            Console.WriteLine(DisplayMessageConst.NextProcessMenuExitProgramMessage, (int)EnumsForShape.ExitProgram);

            EnumsForShape enumForProcessMenu;
            while (true)
            {
                enumForProcessMenu = InputOutputHandlerClass.EnumInputMethod();
                switch (enumForProcessMenu)
                {
                    case EnumsForShape.Rectangle:
                        RectangleOperations(enumForProcessMenu);
                        return true;
                    case EnumsForShape.Oval:
                        OvalOperations(enumForProcessMenu);
                        return true;
                    case EnumsForShape.Circle:
                        CircleOperations(enumForProcessMenu);
                        return true;
                    case EnumsForShape.ExitProgram:
                        return false;
                    default:
                        Console.WriteLine(DisplayMessageConst.WrongInputForProcessMessage);
                        continue;
                }
            }
        }

        /// <summary>
        /// Operations for rectangle
        /// </summary>
        static void RectangleOperations(EnumsForShape EnumInputMethod)
        {
            using (Rectangle rectangleObject = new Rectangle())
            {
                Console.Clear();
                Console.WriteLine(DisplayMessageConst.EnterLengthMessge);
                double lengthOfRectangle = InputOutputHandlerClass.InputData();
                Console.WriteLine(DisplayMessageConst.EnterWidthMessge);
                double widthOfRectangle = InputOutputHandlerClass.InputData();
                Console.Clear();
                InputOutputHandlerClass.PrintObjectProperties(rectangleObject);
                InputOutputHandlerClass.PrintAreaOfObject(rectangleObject.CalculateArea(lengthOfRectangle, lengthOfRectangle), EnumInputMethod);
                InputOutputHandlerClass.PrintPerimeterOfObject(rectangleObject.CalculatePerimeter(lengthOfRectangle, lengthOfRectangle), EnumInputMethod);
            }
        }

        /// <summary>
        /// Operations for Oval
        /// </summary>
        static void OvalOperations(EnumsForShape EnumInputMethod)
        {
            using (Oval ovalObject = new Oval())
            {
                Console.Clear();
                Console.WriteLine(DisplayMessageConst.EnterSizeOfMajorAxisMessge);
                double majorOfOval = InputOutputHandlerClass.InputData();
                Console.WriteLine(DisplayMessageConst.EnterSizeOfMinorAxisMessge);
                double minorOfoval = InputOutputHandlerClass.InputData();
                Console.Clear();
                InputOutputHandlerClass.PrintObjectProperties(ovalObject);
                InputOutputHandlerClass.PrintAreaOfObject(ovalObject.CalculateArea(majorOfOval, minorOfoval), EnumInputMethod);
                InputOutputHandlerClass.PrintPerimeterOfObject(ovalObject.CalculatePerimeter(majorOfOval, minorOfoval), EnumInputMethod);
            }
        }

        /// <summary>
        /// Operation for Circle
        /// </summary>
        static void CircleOperations(EnumsForShape EnumInputMethod)
        {
            using (Circle circleObject = new Circle())
            {
                Console.Clear();
                Console.WriteLine(DisplayMessageConst.EnterRadiusMessge);
                double radiusOfCircle = InputOutputHandlerClass.InputData();
                Console.Clear();
                InputOutputHandlerClass.PrintObjectProperties(circleObject);
                InputOutputHandlerClass.PrintAreaOfObject(circleObject.CalculateArea(radiusOfCircle), EnumInputMethod);
                InputOutputHandlerClass.PrintPerimeterOfObject(circleObject.CalculatePerimeter(radiusOfCircle), EnumInputMethod);
            }
        }
    }
}
