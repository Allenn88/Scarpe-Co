namespace Scarpe___Co.Models
{
    public class ErrorViewModel
    {
        public string? ShoesId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(ShoesId);
    }
}
