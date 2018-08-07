using System;

namespace Interface_struct_enum_page_375
{
    public class StructDemo
    {
        public void Page_392()
        {
            Book book1 = new Book("Gerbert Shildt", "Full directory on C# 4.0", 2010);
            Book book2 = new Book();
            Book book3;

            Console.WriteLine(book1.Author+ " "+ book1.Title+ " "+ book1.Copyright);
            Console.WriteLine();
            
            if(book2.Title == null)
                Console.WriteLine("Member book2.Title is empty");

            book2.Title = "Oh marvelous new world";
            book2.Author = "Oldos Haksly";
            book2.Copyright = 1932;

            Console.WriteLine("Struct book2 content: ");
            Console.WriteLine(book2.Author+ " "+ book2.Title+" "+book2.Copyright);
            Console.WriteLine();
            book3.Title = "Red storm";
            Console.WriteLine(book3.Title);
            
        }
    }
}