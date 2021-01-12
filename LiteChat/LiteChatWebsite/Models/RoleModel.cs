using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiteChatWebsite.Models
{
    [Table("t_roles")]
    public class RoleModel
    {
        [Key]
        [Column("role_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column("role_type")]
        [MaxLength(20)]
        [Required]
        public string RoleType { get; set; }

        public ICollection<UserModel> UserModels;
    }
}