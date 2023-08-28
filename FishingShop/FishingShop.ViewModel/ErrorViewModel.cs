namespace FishingShop.ViewModel
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
