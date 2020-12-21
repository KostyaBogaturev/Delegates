namespace MyDelegate
{
    /// <summary>
    /// In that class we describe Method Calc and Result.
    /// </summary>
    public class Class2
    {
        private int calcResult;

        /// <summary>
        /// delegate for Result.
        /// </summary>
        /// <param name="value">devider.</param>
        /// <returns>bool value :in divided by value.</returns>
        public delegate bool ResultHendler(int value);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pow">Delegate to Class1.Pow</param>
        /// <param name="x">value for Class1.Pow</param>
        /// <param name="y">value for Class1.Pow</param>
        /// <returns>delegate for Result.</returns>
        public ResultHendler Calc(PowHendler pow, int x, int y)
        {
            ResultHendler hendler = Result;
            this.calcResult = pow.Invoke(x, y);
            return hendler;
        }

        /// <summary>
        /// Is number divided by value.
        /// </summary>
        /// <param name="x">divider.</param>
        /// <returns>bool value :in divided by value.</returns>
        public bool Result(int x)
        {
            return this.calcResult % x == 0 ? true : false;
        }
    }
}
