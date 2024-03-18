namespace Shape_And_Its_Derivatives
{
    /// <summary>
    /// Class of rectangle inharited from shape
    /// </summary>
    class Rectangle : Shape, IInterfaceForShape
    {
        /// <summary>
        /// override method to calculate area
        /// </summary>
        /// <param name="length">Length of rectangle</param>
        /// <param name="width">Width of rectangle</param>
        /// <returns>Area of rectangle</returns>
        public override decimal CalculateArea(double length, double width)
        {
            return (decimal)(length*width);
        }
    
        /// <summary>
        /// override method to calculate perimeter
        /// </summary>
        /// <param name="length">Length of rectangle</param>
        /// <param name="width">Width of rectangle</param>
        /// <returns>Perimeter of rectangle</returns>
        public override decimal CalculatePerimeter(double length, double width)
        {
            return (decimal)(2 * (length + width)); 
        }
    }
}
