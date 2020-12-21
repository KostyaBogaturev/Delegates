namespace MyDelegate
{
    using System;

    /// <summary>
    /// Main class in program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method in program.
        /// </summary>
        /// <param name="args">standart argument.</param>
        static void Main(string[] args)
        {
            var first = new Class1();
            var second = new Class2();
            first.showHendler = Show;
            first.showHendler(second.Calc(first.powHendler, 2, 3).Invoke(2));
        }

        /// <summary>
        /// Show method.
        /// </summary>
        /// <param name="divider">bool value is number divided or not.</param>
        private static void Show(bool isDivided)
        {
            Console.WriteLine("{0}", isDivided);
        }
    }
}
