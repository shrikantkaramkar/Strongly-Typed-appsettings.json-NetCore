using System.ComponentModel.DataAnnotations;

namespace IOptionsPattern
{
    public class BandWidthSettings
    {
        public const string SECTION = "BandWidthSettings";

        [Required]
        public string UserID { get; set; }
        [Required]
        public string ApiToken { get; set; }
        [Required]
        public string ApiSecret { get; set; }
        [Required]
        public string BaseUrl { get; set; }
    }
}
