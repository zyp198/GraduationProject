using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectricSys.Entity
{
    public class BaseEntity
    {
        public Guid user_id { get; set; } = Guid.NewGuid();

        public DateTime user_create_time { get; set; } = DateTime.Now;

        public bool user_activity { get; set; }=true;
    }
}