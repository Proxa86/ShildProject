﻿namespace Interface_struct_enum_page_375
{
    public struct Book
    {
        public string Author;
        public string Title;
        public int Copyright;

        public Book(string a, string t, int c)
        {
            Author = a;
            Title = t;
            Copyright = c;
        }
    }
}