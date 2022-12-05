using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GigaCard.Models
{
    public class Suporte
    {
        public string Id { get; set; }
        public byte[] Card { get; set; }

        public virtual string UserId { get; set; }

    }
}