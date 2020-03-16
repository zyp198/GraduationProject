using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ElectricSys.Entity
{
    public class user : BaseEntity
    {
        [Key]
        public Guid user_id { get; set; }
       
        public string user_name { get; set; }
        public string user_password { get; set; }
        public DateTime user_create_time { get; set; }
        public DateTime user_update_time { get; set; }
        public bool user_sex { get; set; }
        public string user_telephone { get; set; }
        public string role_code { get; set; }
    }
}