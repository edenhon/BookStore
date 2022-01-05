using AutoMapper;
using Blazored.LocalStorage;
using BookStoreApp.Blazor.Shared.UI.Services.Base;
using Microsoft.AspNetCore.SignalR.Client;
using System.Diagnostics;

namespace BookStoreApp.Blazor.Shared.UI.Services
{
    public class BookService : BaseHttpService, IBookService
    {
        private readonly IClient client;
        private readonly IMapper mapper;
        private HubConnection hubConnection;
        private readonly string hubUrl = "/hubs/books";
        private readonly string baseUrl = "https://localhost:7183";
        public EventHandler<BookReadOnlyDto> BookAdded;
        public EventHandler<BookUpdateDto> BookUpdated;
        public EventHandler<int> BookDeleted;

        public BookService(IClient client, ILocalStorageService localStorage, IMapper mapper) : base(client, localStorage)
        {
            this.client = client;
            this.mapper = mapper;
            InitSignalR();
        }

        event EventHandler<BookReadOnlyDto> IBookService.BookAdded
        {
            add
            {
                BookAdded += value;
            }

            remove
            {
                if (BookAdded != null)
                {
                    BookAdded -= value;
                }
            }
        }

        event EventHandler<BookUpdateDto> IBookService.BookUpdated
        {
            add
            {
                BookUpdated += value;
            }

            remove
            {
                if (BookUpdated != null)
                {
                    BookUpdated -= value;
                }
            }
        }

        event EventHandler<int> IBookService.BookDeleted
        {
            add
            {
                BookDeleted += value;
            }

            remove
            {
                if (BookDeleted != null)
                {
                    BookDeleted -= value;
                }
            }
        }

        private async void InitSignalR()
        {
            await GetBearerToken();
            if (client.HttpClient?.DefaultRequestHeaders.Authorization == null) return;

            hubConnection = new HubConnectionBuilder()
                .WithUrl($"{baseUrl}{hubUrl}", options => 
                    options.AccessTokenProvider = () => 
                    Task.FromResult(client.HttpClient.DefaultRequestHeaders.Authorization?.Parameter))
                .WithAutomaticReconnect()
                .Build();

            hubConnection.On<BookReadOnlyDto>("PostBook", (dto) =>
            {
                BookAdded?.Invoke(this, dto);
            });

            hubConnection.On<BookUpdateDto>("PutBook", (dto) =>
            {
                BookUpdated?.Invoke(this, dto);
            });

            hubConnection.On<int>("DeleteBook", (id) =>
            {
                BookDeleted?.Invoke(this, id);
            });

            hubConnection.Reconnecting += async (exception) =>
            {
                Debug.WriteLine($"Connection started reconnecting due to an error: {exception}");
            };

            await hubConnection.StartAsync();

            hubConnection.Closed += async (s) =>
            {
                await hubConnection.StartAsync();
            };
        }

        public async Task<Response<int>> Create(BookCreateDto bookCreateDto)
        {
            Response<int> response = new();
            try
            {
                await GetBearerToken();
                await client.BooksPOSTAsync(bookCreateDto);
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<int>(exception);
            }
            return response;
        }

        public async Task<Response<int>> Update(int id, BookUpdateDto book)
        {
            Response<int> response = new();
            try
            {
                await GetBearerToken();
                await client.BooksPUTAsync(id, book);
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<int>(exception);
            }
            return response;
        }

        public async Task<Response<List<BookReadOnlyDto>>> Get()
        {
            Response<List<BookReadOnlyDto>> response;

            try
            {
                await GetBearerToken();
                var data = await client.BooksAllAsync();
                response = new Response<List<BookReadOnlyDto>>
                {
                    Data = data.ToList(),
                    Success = true
                };
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<List<BookReadOnlyDto>>(exception);
                
            }
            return response;
        }

        public async Task<Response<BookDetailsDto>> Get(int id)
        {
            Response<BookDetailsDto> response;

            try
            {
                await GetBearerToken();
                var data = await client.BooksGETAsync(id);
                response = new Response<BookDetailsDto>
                {
                    Data = data,
                    Success = true
                };
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<BookDetailsDto>(exception);

            }
            return response;
        }

        public async Task<Response<BookUpdateDto>> GetForUpdate(int id)
        {
            Response<BookUpdateDto> response;

            try
            {
                await GetBearerToken();
                var data = await client.BooksGETAsync(id);
                response = new Response<BookUpdateDto>
                {
                    Data = mapper.Map<BookUpdateDto>(data),
                    Success = true
                };
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<BookUpdateDto>(exception);

            }
            return response;
        }

        public async Task<Response<int>> Delete(int id)
        {
            Response<int> response = new();
            try
            {
                await GetBearerToken();
                await client.BooksDELETEAsync(id);
            }
            catch (ApiException exception)
            {
                response = ConvertApiExceptions<int>(exception);
            }
            return response;
        }
    }
}
