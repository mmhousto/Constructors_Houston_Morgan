using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_Houston_Morgan
{
    class Game
    {

        public string title, genre;

        public Game(string titleParam = "Unknown Title", string genreParam = "Casual")
        {
            title = titleParam;
            genre = genreParam;
        }

    }
}
