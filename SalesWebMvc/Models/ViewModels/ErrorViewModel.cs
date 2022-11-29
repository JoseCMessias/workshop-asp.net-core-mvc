using System;

namespace SalesWebMvc.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Messege { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}