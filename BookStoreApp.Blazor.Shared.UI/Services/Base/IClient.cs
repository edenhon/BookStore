namespace BookStoreApp.Blazor.Shared.UI.Services.Base
{
    public partial interface IClient
    {
        public HttpClient HttpClient { get; }
    }
}
