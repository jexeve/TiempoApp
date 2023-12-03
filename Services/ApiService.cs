using TiempoApp.Models;
using Newtonsoft.Json;

namespace TiempoApp.Services
{
    public static class ApiService
    {
        public static async Task<Root>getTiempo()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("http://api.tutiempo.net/json/?lan=es&apid=XCEXq4qazz49z4S&lid=56608");
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
