using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiteChatWebsite.Models
{
    [Table("t_users")]
    public class UserModel
    {
        [Key]
        [Column("user_id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID
        {
            get; set;
        }

        [Column("user_name")]
        [MaxLength(20)]
        [Required]
        public string UserName
        {
            get; set;
        }

        [Column("user_password", TypeName = "char(72)")]
        [Required]
        public string UserPassWord
        {
            get; set;
        }

        [ForeignKey("FK_role_in_user")]
        [Column("role_id")]
        public int RoleID
        {
            get; set;
        }
    }
}