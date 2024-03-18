using System;
namespace Shape_And_Its_Derivatives
{
    /// <summary>
    /// Abstract class of shape 
    /// </summary>
    public abstract class Shape: IInterfaceForShape , IDisposable
    {
        /// <summary>
        /// private field for serial Number of object(Total object created)
        /// </summary>
        private static int serialNumberOfObject;

        /// <summary>
        /// private field for Live number of object(Currentlly live Object)
        /// </summary>
        private static int liveObject;

        /// <summary>
        /// Flag for dispose of Object was done or pending
        /// </summary>
        private bool isDisposed = false;

        /// <summary>
        ///  Read only Property to get sariel number
        /// </summary>
        public int SerialNumberOfObject
        {
            get
            {
                return serialNumberOfObject;
            }
        }

        /// <summary>
        /// read only Property to get live count
        /// </summary>
        public int LiveObject
        {
            get
            {
                return liveObject;
            }
        }

        /// <summary>
        /// construtor of shape class
        /// </summary>
        public Shape()
        {
            serialNumberOfObject += 1;
            liveObject += 1;
        }

        /// <summary>
        /// Dispose method which release resource and turn flag ture for dispose was done
        /// </summary>
        /// <param name="disposing"></param>
        protected void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    liveObject -= 1;
                }
                isDisposed = true;
            }
        }
        /// <summary>
        /// Abstract method for area calculation
        /// </summary>
        /// <param name="valueOfpara1">length</param>
        /// <param name="valueOfPara2">Width</param>
        /// <returns>Area of shape</returns>
        public abstract decimal CalculateArea(double valueOfpara1, double valueOfPara2);

        /// <summary>
        /// Abstarct method for perimeter calculation
        /// </summary>
        /// <param name="valueOfpara1">length</param>
        /// <param name="valueOfpara2">length</param>
        /// <returns>Perimeter of shape</returns>
        public abstract decimal CalculatePerimeter(double valueOfpara1, double valueOfpara2);
        
        /// <summary>
        /// Method to display current class
        /// </summary>
        public void DisplayClassName()
        {
            Console.WriteLine(DisplayMessageConst.CurrentClassNameMessage,this.GetType().Name);
        }

        /// <summary>
        /// Dispose virtual method for object
        /// </summary>
        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Distrucor for shape
        /// </summary>
        ~Shape()
        {
            Dispose(false);
        }
    }
}
