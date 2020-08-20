using System;

namespace alternative_tracker_domain
{
    public class WOWAccesstoken
    {
        public DateTime Expiry { get; }
        public string Token { get; }

        public WOWAccessToken(string token, DateTime expiry)
        {
            if (string.IsNullOrWhiteSpace(token)) throw new ArgumentException($"'{nameof(token)}' cannot be null or whitespace", nameof(token));
            
            Token = token;
            Expiry = expiry;
        }
    }
}
