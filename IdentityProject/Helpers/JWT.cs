using System;
namespace IdentityProject.Helpers
{
    public class JWT
    {
        public JWT()
        {
        }

        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public double DurationInDays { get; set; }
    }
}

