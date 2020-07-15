using System;
using Acme.BookStore.Books.Dto;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
    public class BookAppService:CrudAppService<Book,BookDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateBookDto,CreateUpdateBookDto>,IBookAppService
    {
        private readonly IRepository<Book, Guid> _repository;

        public BookAppService(IRepository<Book, Guid> repository) : base(repository)
        {
            _repository = repository;
        }
        
    }
}