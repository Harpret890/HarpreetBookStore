using System;

namespace HarpreetBookStore.Models.ViewModels // added ViewModels 
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
