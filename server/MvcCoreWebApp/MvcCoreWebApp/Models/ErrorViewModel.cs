namespace MvcCoreWebApp.Models
{
    public class ErrorViewModel
    {
        //test comment
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
