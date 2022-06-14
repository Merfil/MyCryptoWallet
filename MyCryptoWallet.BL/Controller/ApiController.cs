using MyCryptoWallet.BL.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyCryptoWallet.BL.Controller
{
    public class ApiController
    {
        public Coin[]? CoinsInfo;
        string _address;
        string response;
        public ApiController()
        {
            _address = "https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&ids=bitcoin%2Cethereum%2Ctether%2Cbinancecoin%2Ccardano%2Csolana%2Cdogecoin%2Cpolkadot%2Clitecoin%2Ctron&order=market_cap_desc&per_page=100&page=1&sparkline=true&price_change_percentage=1h%2C7d%2C14d%2C30d";
        }

        public Coin[] GetResponse()
        {
            HttpWebRequest _request = (HttpWebRequest)WebRequest.Create(_address);
            _request.Method = "GET";
            try
            {
                HttpWebResponse responce = (HttpWebResponse)_request.GetResponse();
                var stream = responce.GetResponseStream();
                if (stream != null)
                    response = new StreamReader(stream).ReadToEnd();
                return JsonConvert.DeserializeObject<Coin[]>(response);
            }
            catch (Exception) { return null; }
        }
    }
}
