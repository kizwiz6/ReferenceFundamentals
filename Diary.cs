using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceFundamentals
{
    class Diary : Book, IFlippable
    {
        public int CurrentPage
        { get; set; }

        public Diary(int page = 0) : base()
        {
            CurrentPage = page;
        }

        public Diary(int page, string author, string title) : base(author, title)
        {
            CurrentPage = page;
        }

        public void Flip()
        {
            CurrentPage++;
        }

        public string SpillSecret()
        {
            return "OMG Samantha is cheating on Chris! </3";
        }

        public override string Stringify()
        {
            return "This is a Diary object!";
        }
    }
}
