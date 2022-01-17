using AutoMapper;
using BookStoreApp.API.Controllers;
using BookStoreApp.API.Data;
using BookStoreApp.API.Models.Book;
using BookStoreApp.API.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace BookStoreApp.UnitTests.Mocking
{
    /// <summary>
    /// Testing the interaction between two objects (BooksController and BooksRepository).
    /// </summary>
    [TestFixture]
    public class BooksController_BooksRepositoryTests
    {
        private Mock<IBooksRepository> booksRepository;
        private Mock<IMapper> mapper;
        private Mock<ILogger<BooksController>> logger;
        private Mock<IWebHostEnvironment> webHostEnvironment;
        private Mock<IHubContext<BookHub>> hubContext;
        private BooksController booksController;

        [SetUp]
        public void Setup()
        {
            booksRepository = new Mock<IBooksRepository>();
            mapper = new Mock<IMapper>();
            logger = new Mock<ILogger<BooksController>>();
            webHostEnvironment = new Mock<IWebHostEnvironment>();
            hubContext = new Mock<IHubContext<BookHub>>();

            booksController = new BooksController(booksRepository.Object,
                                                  mapper.Object,
                                                  logger.Object,
                                                  webHostEnvironment.Object,
                                                  hubContext.Object);
        }

        [Test]
        public void GetBook_WhenCalled_DoesGetBookAsync()
        {
            var result = booksController.GetBook(1);
            booksRepository.Verify(rp => rp.GetBookAsync(1));
        }

        //[Test]
        //public void PutBook_WhenCalled_DoesUpdateAsync()
        //{
        //    var bookUpdateDto = new BookUpdateDto { Id = 1 };
        //    var result = booksController.PutBook(bookUpdateDto.Id, bookUpdateDto);
        //    booksRepository.Verify(rp => rp.UpdateAsync(book));
        //}

        [Test]
        public void DeleteBook_WhenCalled_DoesGetAsync()
        {
            var result = booksController.DeleteBook(1);
            booksRepository.Verify(rp => rp.GetAsync(1));
        }

        [Test]
        public void DeleteBook_WhenCalled_DoesDeleteAsync()
        {
            booksRepository.Setup(rp => rp.GetAsync(1)).ReturnsAsync(new Book());
            var result = booksController.DeleteBook(1);
            booksRepository.Verify(rp => rp.DeleteAsync(1));
        }
    }
}
