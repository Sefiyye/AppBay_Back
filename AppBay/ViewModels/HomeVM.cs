using AppBay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBay.ViewModels
{
    public class HomeVM
    {
        public Setting Settings { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
    }
}
