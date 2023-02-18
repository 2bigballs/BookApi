﻿using System.Linq.Expressions;
using Application.Configuration;
using Application.Extensions;
using Application.Interfaces;
using Application.Models;
using Domain.Entities;
using FluentValidation;
using Microsoft.Extensions.Options;

namespace Application.Services
{
    public class BookService : IBookService
    {
        private readonly SecretCode _secretCode;
        private readonly IBookRepository _bookRepository;
        private readonly IValidator<Book> _bookValidator;
        
        public BookService(IBookRepository bookRepository, IValidator<Book> bookValidator, IOptions<SecretCode> secretCode)
        {
            _bookRepository = bookRepository;
            _bookValidator = bookValidator;
            _secretCode = secretCode.Value;
        }
        
        public async Task<List<Book>> GetBooks(string? orderBy)
        {
            Expression<Func<Book, string>> orderByExpression = null;
            if (orderBy.ToLower() == nameof(Book.Author).ToLower())
            {
                orderByExpression = x => x.Author;
            }
            if (orderBy.ToLower() == nameof(Book.Title).ToLower())
            {
                orderByExpression = x => x.Title;
            }
            var books = await _bookRepository.GetAll(orderByExpression);
            return books;

        }

        public async Task<List<Book>> GetRecommendedBook(string? genre)
        {
            int reviewCount = 10;
            int bookCount = 10;

            var recommendedBooks = await _bookRepository.GetRecommended(reviewCount, genre, bookCount);

            return recommendedBooks;
        }

        public async Task<Response<Book>> GetBookDetails(int id)
        {
            bool isExist = await _bookRepository.IsExist(id);
            if (!isExist)
            {
                return FailureResponses.NotFound<Book>($"Not found book by id:{id}");
            }
            Book book = await _bookRepository.GetBookById(id);
            return SuccessResponses.Ok(book);
        }

        public async Task<Response<int>> Create(Book book)
        {
            var validationResponse = await _bookValidator.ValidateAsync(book);
            if (!validationResponse.IsValid)
            {
                return FailureResponses.BadRequest<int>(validationResponse.ErrorMessages());
            }
            await _bookRepository.Create(book);
            await _bookRepository.SaveChanges();
            return SuccessResponses.Created(book.Id);
        }

        public async Task<Response<EmptyValue>> Remove(int id, string key)
        {
            if (!key.Equals(_secretCode.Value))
            {
                return FailureResponses.Forbidden($"{key} is wrong SecretCode!");
            }
            bool isExist = await _bookRepository.IsExist(id);
            if (!isExist)
            {
                return FailureResponses.NotFound<EmptyValue>($"Not found book by id:{id}");
            }
            await _bookRepository.RemoveById(id);
            await _bookRepository.SaveChanges();
            return SuccessResponses.NoContent();
        }

        public async Task<Response<EmptyValue>> Update(Book book)
        {
            var isExist = await _bookRepository.IsExist(book.Id);
            if (!isExist)
            {
                return FailureResponses.NotFound($"Not found book by id:{book.Id}");
            }
            var validationResponse= await _bookValidator.ValidateAsync(book);
            if (!validationResponse.IsValid)
            {
                return FailureResponses.BadRequest(validationResponse.ErrorMessages());
            }

            _bookRepository.Update(book);
            await _bookRepository.SaveChanges();
            return SuccessResponses.NoContent();
        }
    }
}
