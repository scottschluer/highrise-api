using System.Collections.Generic;
using System.Linq;
using RestSharp.Contrib;

namespace HighriseApi.ExtensionMethods
{
    public static class DictionaryExtensions
    {
        public static string ToSearchQueryString(this IDictionary<string, string> dictionary)
        {
            return string.Join("&", dictionary.Select(pair => string.Format("criteria[{0}]={1}", pair.Key, HttpUtility.UrlEncode(pair.Value))));
        }
    }
}
