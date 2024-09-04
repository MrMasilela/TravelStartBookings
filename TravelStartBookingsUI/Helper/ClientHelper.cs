namespace TravelStartBookingsUI.Helper
{
    public class ClientHelper
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5043/api");
            return client;
        }
    }
}
