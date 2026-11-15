// Supabase
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoIntegrador.Web.Models.Entities
{
    [Table("usuarios")]
    public class Usuario
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; } = string.Empty;

        [Column("cpf")]
        public string Cpf { get; set; } = string.Empty;

        [Column("ra")]
        public string Ra { get; set; } = string.Empty;

        [Column("telefone")]
        public string Telefone { get; set; } = string.Empty;

        [Column("endereco")]
        public string Endereco { get; set; } = string.Empty;
        [Column("senha")]
        public string senha { get; set; } = string.Empty;
        [Column("tipo_usuario")]
        public string TipoUsuario { get; set; } = string.Empty;
    }
}
