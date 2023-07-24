using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyConverter.Models;
using MyConverter.Services;
using System.Globalization;

namespace MyConverter.Pages
{
    public class ConverterModel : PageModel
    {
        [BindProperty(Name = "result")]
        public string Result { get; set; }
        [BindProperty(Name = "userInput")]
        public string UserInput { get; set; }
        [BindProperty(Name = ("currencySelectionLeft"))]
        public string CurrencySelectionLeft { get; set; }
        [BindProperty(Name = ("currencySelectionRight"))]
        public string CurrencySelectionRight { get; set; }

        public ValCurs Response { get; set; } = new();
        private ConverterService _converterService;

        public ConverterModel(ConverterService converterService)
        {
            _converterService = converterService;
        }

        public async Task<IActionResult> OnGet()
        {
            try
            {
                Response = await _converterService.GetConverterInfoAsync();

            }
            catch (Exception e)
            {
                return RedirectToPage("/Error");
            }

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            Response = await _converterService.GetConverterInfoAsync();
            if (UserInput != null)
            {
                try
                {
                    double userInputValue = Convert.ToDouble(UserInput);
                    double resultValue = ConvertCurrency(userInputValue, CurrencySelectionLeft, CurrencySelectionRight);
                    Result = resultValue.ToString();
                    TempData["ConversionResult"] = Result;
                }
                catch (Exception ex)
                {
                    return RedirectToPage("/Error");
                }
            }
            return Page();
        }
        private double ConvertCurrency(double value, string fromCurrency, string toCurrency)
        {
            string fromCurrencyValue = String.Empty;
            string toCurrencyValue = String.Empty;
            if (fromCurrency != toCurrency)
            {
                for (int i = 0; i < Response.ValTypes.Count; i++)
                {
                    for (int j = 0; j < Response.ValTypes[i].Valutes.Count; j++)
                    {
                        if (Response.ValTypes[i].Valutes[j].Code == toCurrency)
                        {
                            toCurrencyValue = Response.ValTypes[i].Valutes[j].Value;
                        }
                        if (Response.ValTypes[i].Valutes[j].Code == fromCurrency)
                        {
                            fromCurrencyValue = Response.ValTypes[i].Valutes[j].Value;
                        }
                    }
                }


                double toCurrencyResult;
                double fromCurrencyResult;
                Double.TryParse(toCurrencyValue, NumberStyles.Float, CultureInfo.InvariantCulture, out toCurrencyResult);
                Double.TryParse(fromCurrencyValue, NumberStyles.Float, CultureInfo.InvariantCulture, out fromCurrencyResult);

                if (toCurrencyResult > fromCurrencyResult)
                {
                    return value / toCurrencyResult;
                }
                else if (toCurrencyResult < fromCurrencyResult)
                {
                    return value * toCurrencyResult;
                }
                else if (toCurrencyResult == fromCurrencyResult)
                {
                    return value;
                }
            }
            return value;

        }
    }
}
