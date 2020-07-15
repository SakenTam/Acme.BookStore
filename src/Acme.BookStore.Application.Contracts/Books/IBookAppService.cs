using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acme.BookStore.Books.Dto;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Books
{
    public interface IBookAppService:
        ICrudAppService
        <BookDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateBookDto,
            CreateUpdateBookDto>
    {
    }
}