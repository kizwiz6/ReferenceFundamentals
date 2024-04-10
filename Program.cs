namespace ReferenceFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dissertation diss = new Dissertation();
            IFlippable fdiss = diss;
            Book bdiss = diss;
            fdiss.CurrentPage = 42;
            // bdiss.CurrentPage = 43; - CAUSES ERRORS 
            // fdiss.Stringify(); - CAUSES ERRORS
            bdiss.Stringify();
            Console.WriteLine(fdiss == bdiss);
        }
    }
}
