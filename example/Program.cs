using HighriseApi;

namespace HighriseApiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Username is your Highrise username (i.e. https://<username>.highrisehq.com)
            // If nothing else, it can be found under "Accounts & settings -> My info" in the 37signals ID badge
            const string username = "[USERNAME]";

            // Your authentication token can be found under "Accounts & settings -> My info -> API token"
            const string authenticationToken = "[TOKEN]";

            var api = new ApiRequest(username, authenticationToken);
            
            // Get all people your user has access to
            var people = api.PersonRequest.Get();
        }
    }
}
