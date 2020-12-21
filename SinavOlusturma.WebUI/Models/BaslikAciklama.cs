using SinavOlusturma.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavOlusturma.WebUI.Models
{
    public class BaslikAciklama : CoreEntity
    {
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
    }
}
