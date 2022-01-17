using Moq;
using Blazored.LocalStorage;
using NUnit.Framework;
using BookStoreApp.Blazor.Shared.UI.Services.Base;
using AutoMapper;
using BookStoreApp.Blazor.Shared.UI.Services;

namespace BookStoreApp.UnitTests.Mocking
{
    /// <summary>
    /// Testing the interaction between two objects (BookService and Client).
    /// </summary>
    [TestFixture]
    public class BookService_Client_InteractionTests
    {
        private Mock<IClient> client;
        private Mock<ILocalStorageService> localStorage;
        private Mock<IMapper> mapper;
        private IBookService bookService;

        [SetUp]
        public void Setup()
        {
            client = new Mock<IClient>();
            localStorage = new Mock<ILocalStorageService>();
            mapper = new Mock<IMapper>();
            bookService = new BookService(client.Object, localStorage.Object, mapper.Object);
        }

        [Test]
        public void Create_WhenCalled_DoesBooksPOSTAsync()
        {
            var newBook = new BookCreateDto();
            bookService.Create(newBook);
            client.Verify(c => c.BooksPOSTAsync(newBook));
        }

        [Test]
        public void Update_WhenCalled_DoesBooksPUTAsync()
        {
            var book = new BookUpdateDto() { Id=1 };
            bookService.Update(book.Id, book);
            client.Verify(c => c.BooksPUTAsync(book.Id, book));
        }

        [Test]
        public void Delete_WhenCalled_DoesBooksDELETEAsync()
        {
            bookService.Delete(1);
            client.Verify(c => c.BooksDELETEAsync(1));
        }

        [Test]
        public void GetForUpdate_WhenCalled_DoesBooksGETAsync()
        {
            bookService.GetForUpdate(1);
            client.Verify(c => c.BooksGETAsync(1));
        }

        [Test]
        public void Get_WhenCalled_DoesBooksGETAsync()
        {
            bookService.Get(1);
            client.Verify(c => c.BooksGETAsync(1));
        }

        [Test]
        public void Get_WhenCalled_DoesBooksAllAsync()
        {
            bookService.Get();
            client.Verify(c => c.BooksAllAsync());
        }
    }
}