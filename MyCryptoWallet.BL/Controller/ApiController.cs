using MyCryptoWallet.BL.Model;
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
        string _address;
        string _response;
        ApiEnum.Currency _currency = ApiEnum.Currency.usd;
        public ApiController(ApiEnum.Coin coin, ApiEnum.Currency currency)
        {
            _address = $"https://api.coingecko.com/api/v3/coins/{coin}?localization=false&tickers=false&market_data=true&community_data=false&developer_data=false";
            _currency = currency;
        }

        public string GetResponse(ApiEnum.Command command, ApiEnum.Currency currency)
        {
            HttpWebRequest _request = (HttpWebRequest)WebRequest.Create(_address);
            _request.Method = "GET";
            try
            {
                HttpWebResponse responce = (HttpWebResponse)_request.GetResponse();
                var stream = responce.GetResponseStream();
                if (stream != null)
                    _response = new StreamReader(stream).ReadToEnd();
                double answer = (double)JObject.Parse(_response)["market_data"][command.ToString()][currency.ToString()];
                return answer.ToString("#,0.##");
            }
            catch (Exception) { return null; }
        }

        public string GetResponse(ApiEnum.Command command)
        {
            HttpWebRequest _request = (HttpWebRequest)WebRequest.Create(_address);
            _request.Method = "GET";
            try
            {
                HttpWebResponse responce = (HttpWebResponse)_request.GetResponse();
                var stream = responce.GetResponseStream();
                if (stream != null)
                    _response = new StreamReader(stream).ReadToEnd();
                return JObject.Parse(_response)["market_data"][command.ToString()].ToString();
            }
            catch (Exception) { return null; }
        }

        public string[] GetInfo()
        {
            string[] a = new string[11];
            int comandCount = Enum.GetNames(typeof(ApiEnum.Command)).Length-1;
            ApiEnum.Command com;

            for (int i = 0; i < 4; i++)
            {
                com = ((ApiEnum.Command)Enum.GetValues(typeof(ApiEnum.Command)).GetValue(i));
                a[i] = GetResponse(com, _currency) + " " + _currency;
            }
            for (int i = 4; i < comandCount; i++)
            {
                com = ((ApiEnum.Command)Enum.GetValues(typeof(ApiEnum.Command)).GetValue(i));
                a[i] = GetResponse(com, _currency) + " %";
            }
            com = ((ApiEnum.Command)Enum.GetValues(typeof(ApiEnum.Command)).GetValue(comandCount));
            a[comandCount] = GetResponse(com);
            return a;
        }
    }
}
