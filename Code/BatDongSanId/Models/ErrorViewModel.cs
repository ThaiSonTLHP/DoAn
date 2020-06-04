using Microsoft.AspNetCore.Identity;
using System;

namespace BatDongSanId.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        
        //private readonly SignInManager<IdentityUser>
    }
}
