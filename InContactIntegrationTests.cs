namespace IOptionsPatterns
{
    using NUnit.Framework;
    using System;
    using IOptionsPattern;

    public class InContactIntegrationTests
    {
        [Test]
        public void Test_PhoneCall()
        {
            Console.WriteLine(BandWidthClient.CreateEncodedKey());
            Console.WriteLine(BandWidthClient.Instance.PhoneNumber);
        }
    }
}
