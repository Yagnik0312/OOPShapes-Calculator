using System;
namespace Shape_And_Its_Derivatives
{
    /// <summary>
    /// class of oval inharited from shape
    /// </summary>
    class Oval : Shape
    {
        /// <summary>
        /// override method to calculate area
        /// </summary>
        /// <param name="majorOfOval">Major axis of oval</param>
        /// <param name="minorOfoval">Minor axis of oval</param>
        /// <returns>Area of oval</returns>
        public override decimal CalculateArea(double majorOfOval, double minorOfoval)
        {
            return (decimal)(System.Math.PI * majorOfOval * minorOfoval);
        }

        /// <summary>
        /// override method to calculate perimeter
        /// </summary>
        /// <param name="majorOfOval">Major axis of oval</param>
        /// <param name="minorOfoval">Minor axis of oval</param>
        /// <returns>Perimeter of oval</returns>
        public override decimal CalculatePerimeter(double majorOfOval, double minorOfoval)
        {
            return (decimal)(2 * System.Math.PI * (Math.Sqrt((majorOfOval * majorOfOval + minorOfoval * minorOfoval) / 2)));
        }
    }
}
