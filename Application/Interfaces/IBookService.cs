
using Application.Models;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IBookService
    {
        Task<List<Book>> GetBooks(string? orderBy);

        Task<List<Book>> GetRecommendedBook(string? genre);

        Task<Response<Book>?> GetBookDetails(int id);

        Task<Response<int>> Create(Book book);

        Task<Response<EmptyValue>> Remove(int id, string key);

        Task<Response<EmptyValue>> Update(Book book);
    }

}
