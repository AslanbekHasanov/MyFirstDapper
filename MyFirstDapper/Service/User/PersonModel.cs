using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstDapper.Service.User
{
    [Table("persons")]
    public class PersonModel
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        [Column("fullname")]
        public string FullName { get; set; }
        [Column("login")]
        public string Login  { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("image_url")]
        public string ImageUrl { get; set; }
    }
}
