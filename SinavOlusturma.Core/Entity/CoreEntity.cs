using SinavOlusturma.Core.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SinavOlusturma.Core
{
    public class CoreEntity : IEntity<int>
    {
        public CoreEntity()
        {
            this.CreatedDate = DateTime.Now;
            this.Status = Status.Active;
            
        }
        public int Id { get ; set ; }
        public DateTime CreatedDate { get; set; }
        public Status Status { get; set; }
    }
}
