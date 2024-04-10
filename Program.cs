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


            Dissertation diss1 = new Dissertation(32, "Anna Knowles-Smith", "Refugees and Theatre");
            Dissertation diss2 = new Dissertation(19, "Lajos Kossuth", "Shiny Happy People");
            Diary dy1 = new Diary(48, "Anne Frank", "The Diary of a Young Girl");
            Diary dy2 = new Diary(23, "Lili Elbe", "Man into Woman");
            Book[] books = new Book[] { diss1, diss2, dy1, dy2 };
            foreach (Book b in books)
            {
                Console.WriteLine(b.Title);
            }

        }
    }
}
