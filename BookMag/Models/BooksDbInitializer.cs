using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookMag.Models
{
    public class BooksDbInitializer:DropCreateDatabaseAlways<BookConext>
    {
        protected override void Seed(BookConext context)
        {
            context.Books.Add(new Book { Name = "Война и мир", Author = "Л.Н. Толстой", Price = 350 });
            context.Books.Add(new Book { Name = "Отцы и дети", Author = "И. Тургенев", Price = 100 });
            context.Books.Add(new Book { Name = "Чайка", Author = "А.П. Чехов", Price = 97 });
            base.Seed(context);
        }
    }
}