﻿namespace Cloudflare.Structs
{
    public struct JsForm
    {
        public string Action { get; set; }
        public string S { get; set; }
        public string VerificationCode { get; set; }
        public string Pass { get; set; }
    }
}
