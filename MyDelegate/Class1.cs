namespace MyDelegate
{

    /// <summary>
    /// Delegate for method Show.
    /// </summary>
    /// <param name="divisible">Check: is value divisible.</param>
    public delegate void ShowDelegate(bool divisible);

    /// <summary>
    /// Delegate for Pow method.
    /// </summary>
    /// <param name="x">first value.</param>
    /// <param name="y">second value.</param>
    /// <returns></returns>
    public delegate int PowHendler(int x, int y);

    /// <summary>
    /// In this class we describe method pow.
    /// </summary>
    public class Class1
    {
        public PowHendler powHendler = Pow;
        public ShowDelegate showHendler;

        /// <summary>
        /// This method multiplies two numbers.
        /// </summary>
        /// <param name="x">first value.</param>
        /// <param name="y">seond value.</param>
        /// <returns>first value * second value.</returns>
        public static int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
