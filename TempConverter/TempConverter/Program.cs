using System.Net;
using System.Text.Json;

List<Converter> my_converters = new()
{
    new(){ValueToConvert = "AZN", amount = 5},
    new(){ValueToConvert = "RUB"}
};

WebClient client = new();

var url = $"https://api.apilayer.com/exchangerates_data/convert?to=";

client.Headers.Add("apikey", "o7m41tMIwyiRSkLpyhwcMF9yUaSfz1wQ");

string link = $"{url}{my_converters[1].ValueToConvert}&from={my_converters[0].ValueToConvert}&amount={my_converters[0].amount}";


var res = client.DownloadString(link);
Console.WriteLine(res);

Serialize(res);

void Serialize(string result)
{
    using var file = new FileStream("data.json", FileMode.OpenOrCreate);
    JsonSerializer.Serialize(file, result);
}