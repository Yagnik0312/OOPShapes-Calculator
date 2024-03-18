namespace Shape_And_Its_Derivatives
{
    /// <summary>
    /// Circle class inharited from oval class
    /// </summary>
    class Circle : Oval
    {
        /// <summary>
        /// override method to calculate area
        /// </summary>
        /// <param name="rediusOfCircle">radius of circle</param>
        /// <returns>Area of circle</returns>
        public decimal CalculateArea(double radiusOfCircle)
        {
            return (decimal)(System.Math.PI * radiusOfCircle * radiusOfCircle);
        }

        /// <summary>
        /// override method to calculate perimeter
        /// </summary>
        /// <param name="rediusOfCircle">radius of circle</param>
        /// <returns>Perimeter of circle</returns>
        public decimal CalculatePerimeter(double rediusOfCircle)
        {
            return (decimal)(2 * System.Math.PI * rediusOfCircle);
        }
    }
}
