using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CameraShop
{   //Tom-Pan :This is my serviceclient for CameraShop
    public static class ServiceClient
    {
        internal async static Task<List<string>> GetBrandNamesAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
                    (await lcHttpClient.GetStringAsync
                    ("http://localhost:60065/api/CameraShop/GetBrandNames/"));
        }

        internal async static Task<clsBrand> GetBrandAsync(string prBrandName)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsBrand>
                    (await lcHttpClient.GetStringAsync
                    ("http://localhost:60065/api/CameraShop/GetBrand?Brand_Name=" + prBrandName));
        }

        internal async static Task<string> UpdateBrandAsync(clsBrand prBrand)
        {
            return await InsertOrUpdateAsync(prBrand, "http://localhost:60065/api/CameraShop/PutBrand", "PUT");
        }

        internal async static Task<string> InsertBrandAsync(clsBrand prBrand)
        {
            return await InsertOrUpdateAsync(prBrand, "http://localhost:60065/api/CameraShop/InsertBrand", "POST");
        }

        private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        {
            using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
            using (lcReqMessage.Content = new StringContent(JsonConvert.SerializeObject(prItem), Encoding.Default, "application/json"))
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }
    }
}
