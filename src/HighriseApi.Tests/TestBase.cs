using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HighriseApi;

namespace HighriseApi.Tests
{
    public class TestBase
    {
        public TestBase()
        {
            _highriseApiRequest = new ApiRequest("company", "key");
        }

        private ApiRequest _highriseApiRequest;
        public ApiRequest HighriseApiRequest { get { return _highriseApiRequest; } }
    }
}
