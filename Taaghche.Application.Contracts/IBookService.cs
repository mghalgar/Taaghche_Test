using System;
using System.Threading.Tasks;
using Taaghche.Domain.Models;

namespace Taaghche.Application.Contracts
{
    public interface IBookService
    {
        Task<BookModel> Get(int id);
    }
}
