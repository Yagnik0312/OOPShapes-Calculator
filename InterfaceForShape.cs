
namespace Shape_And_Its_Derivatives
{
    /// <summary>
    /// Interface for shape
    /// </summary>
    interface IInterfaceForShape
    {
        /// <summary>
        /// signature for method calculate area
        /// </summary>
        /// <param name="valueOfpara1">length</param>
        /// <param name="valueOfPara2">Width</param>
        /// <returns>Area of shape</returns>
        decimal CalculateArea(double valueOfpara1, double valueOfPara2);

        /// <summary>
        /// Signature for method Calculate perimeter
        /// </summary>
        /// <param name="valueOfpara1">length</param>
        /// <param name="valueOfPara2">Width</param>
        /// <returns>Perimeter of shape</returns>
        decimal CalculatePerimeter(double valueOfpara1, double valueOfPara2);
    }
}