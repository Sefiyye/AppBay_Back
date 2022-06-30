using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBay.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string HeaderLogo { get; set; }
        public string LinkLocation { get; set; }
        public string FooterLocation { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
    }
}
