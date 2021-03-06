﻿using System.Collections.Generic;


namespace ShopWebAPI.DAL.Domain
{
    public class AuthenticatioResult
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public bool Success { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
