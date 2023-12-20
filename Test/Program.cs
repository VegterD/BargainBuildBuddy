using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Test;
using Test.FindAdvancedItem.ResponseDto;

class Program
{
    public static string appId = "Your_App_ID";
    public static string certId = "Your_Cert_ID";
    public static string devId = "Your_Dev_ID";
    public static string authToken = "DavidVeg-GPUValua-PRD-908f00a3f-b4cd8a75";
    public static string endpoint = "https://svcs.ebay.com/services/search/FindingService/v1";
    public static string operationName = "findItemsAdvanced";
    public static string keywords = "RTX 3060";
    public static string responseEncoding = "json";
    static async Task Main(string[] args)
    {


        SearchUrlHelper searchUrlHelper = new SearchUrlHelper()
        {
            keywords = keywords,
            categoryId = 27386,
            itemLocation = "US",
            conditions = new List<string>
            {
                "1000", "1500","1750", "2000","2750", "2500", "3000", "4000", "5000", "6000"
            },
            sortOrder = "PricePlusShippingAsc"
        };

        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri(endpoint);
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

        string requestUrl = $"{endpoint}?OPERATION-NAME={operationName}&SERVICE-VERSION=1.0.0&SECURITY-APPNAME={authToken}&RESPONSE-DATA-FORMAT={responseEncoding}&REST-PAYLOAD&keywords={keywords}"
            + searchUrlHelper.ToString();

        HttpResponseMessage response = await client.GetAsync(requestUrl);
        response.EnsureSuccessStatusCode();

        string responseBody = await response.Content.ReadAsStringAsync();
        var root = JsonSerializer.Deserialize<RootObject>(responseBody);
        searchUrlHelper.pageNumber = 2;
        response = await client.GetAsync(GetBaseUrl() + searchUrlHelper.ToString());
        var root2 = JsonSerializer.Deserialize<RootObject>(await response.Content.ReadAsStringAsync());
    }

    private static string GetBaseUrl()
    {
        return $"{endpoint}?OPERATION-NAME={operationName}&SERVICE-VERSION=1.0.0&SECURITY-APPNAME={authToken}&RESPONSE-DATA-FORMAT={responseEncoding}&REST-PAYLOAD&keywords={keywords}";
    }
}