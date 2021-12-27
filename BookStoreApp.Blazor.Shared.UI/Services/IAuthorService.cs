using BookStoreApp.Blazor.Shared.UI.Models;
using BookStoreApp.Blazor.Shared.UI.Services.Base;

namespace BookStoreApp.Blazor.Shared.UI.Services
{
    public interface IAuthorService
    {
        Task<Response<AuthorReadOnlyDtoVirtualizeResponse>> Get(QueryParameters queryParams);
        Task<Response<List<AuthorReadOnlyDto>>> Get();
        Task<Response<AuthorDetailsDto>> Get(int id);
        Task<Response<AuthorUpdateDto>> GetForUpdate(int id);

        Task<Response<int>> Create(AuthorCreateDto author);
        Task<Response<int>> Update(int id, AuthorUpdateDto author);
        Task<Response<int>> Delete(int id);
    }
}