﻿
namespace Contract.BookDTOs
{
    public class GetBooksDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Rating { get; set; }
        public int ReviewsNumber { get; set; }
    }
}