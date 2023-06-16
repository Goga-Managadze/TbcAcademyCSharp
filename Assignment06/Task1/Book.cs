using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Book
    {
        private string _Title;
        private string _Author;
        private int _Year;
        private string _Genre;


        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
            }
        }

        public string Author
        {
            get
            {
                return _Author;
            }
            set
            {
                _Author = value;
            }
        }

        public int Year
        {
            get
            {
                return _Year;
            }
            set
            {
                _Year = value;
            }
        }

        public string Genre
        {
            get
            {
                return _Genre;
            }
            set
            {
                _Genre = value;
            }
        }
    }
}
