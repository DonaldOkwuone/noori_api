using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NooriEntity
{
    [Table("noori_api_users")]
    public class Users
    {
        [Key]
        public int user_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phoneno { get; set; }
        public string address { get; set; }
        public DateTime birthday { get; set; }
        public DateTime date_added { get; set; }
        public DateTime date_created { get; set; }

    }
}
