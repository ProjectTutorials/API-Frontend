using System;
namespace ApiFrontend.Models
{
    public class Api
    {
        public Api()
        {
        }

        // CoinStat
        public string? price { get; set; }
        public string? exchange { get; set; }
        public string? pair { get; set; }


        // CoinLore
        public string? price_usd { get; set; }
        public string? symbol { get; set; }
    }
}
