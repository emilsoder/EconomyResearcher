using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTester
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder1.GetData(StringBuilder1.country(StringBuilder1.germany));
        }


    }


    public class UriBuilder
    {
        string str1
        {
            get
            {
                return "URI1";
            }
        }
        string str2
        {
            get
            {
                return "URI2";
            }
        }

        public string germany
        {
            get
            {
                return "germany";
            }
        }
        public string sweden
        {
            get
            {
                return "sweden";
            }
            set
            {
                country = value;
            }
        }

        public string country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        public Uri UriString()
        {
            return new Uri(str1 + country + str2);
        }

        public void ove()
        {
            UriString();
        }
    }

    public class StringBuilder1
    {
        static string restUri = "https://api.import.io/store/connector/39abb240-a6a6-4e89-a4e6-71140d6043cf/_query?input=webpage/";
        static string startBaseUrl = "url:http%3A%2F%2Fwww.tradingeconomics.com%2F";
        static string endBaseUrl = "%2Fcalendar&&_apikey=";
        static string apiKey = "068de7fbdc4542ba9c4c205370e6ffeb43a39eed0b2684a02e2cfedf3e6aa8487a3980aa47caddc64f7e521bde10bb62d281521913af66f1ffc48f0673951d0d0fdbbc144778871715fba0989c288e1e";

        public static string sweden = "sweden";
        public static string germany = "germany";

        public static Uri country(string _inputCountry)
        {
            return new Uri(restUri + startBaseUrl + _inputCountry + endBaseUrl + apiKey);
        }


        public static void GetData(Uri _uri)
        {

        }
    }
}
