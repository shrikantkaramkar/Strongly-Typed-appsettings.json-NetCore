namespace IOptionsPattern
{
    using System;
    using Bandwidth.Net;
    using System.Text;

    public static class BandWidthClient
    {
        public readonly static Client Instance = new Client(TestHelper.BandWidth.UserID,
                                                    TestHelper.BandWidth.ApiToken,
                                                    TestHelper.BandWidth.ApiSecret);
 

        public static string CreateEncodedKey()
        {
            var authKey = $"{TestHelper.BandWidth.ApiToken}:{TestHelper.BandWidth.ApiSecret}";
            var authKeyBytes = Encoding.UTF8.GetBytes(authKey);
            var encodedKey = Convert.ToBase64String(authKeyBytes);
            return encodedKey;
        }
    }
}