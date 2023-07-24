using MyConverter.Models;
using System.Xml.Serialization;

namespace MyConverter.Services
{
    public class ConverterService
    {
        public async Task<ValCurs> GetConverterInfoAsync()
        {
            DateTime dateTime = DateTime.Now;

            string shortDate = dateTime.ToString("dd.MM.yyyy");

            HttpClient client = new();
            HttpResponseMessage message = await client.GetAsync($"https://www.cbar.az/currencies/{shortDate}.xml");
            if (message.IsSuccessStatusCode)
            {
                string result = await message.Content.ReadAsStringAsync();
                if (result != null)
                {
                    XmlSerializer xml_serializer = new(typeof(ValCurs));
                    using (TextReader reader = new StringReader(result))
                    {
                        ValCurs info = (ValCurs)xml_serializer.Deserialize(reader);
                        return info;
                    }
                }
                throw new NullReferenceException();
            }
            throw new HttpRequestException();
        }
    }
}
