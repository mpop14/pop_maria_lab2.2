﻿using pop_maria_lab2.Models;

namespace pop_maria_lab2.Models.ViewModels
{
    public class PublisherIndexData
    {

        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }

}
