using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entidades;

[Table("usuarios")]
public class Usuario
{

    [Column("id")]
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    [Column("nombre")]
    [MaxLength(50, ErrorMessage = "El nombre no debe exceder los 50 caracteres")]
    public string Nombre { get; set; } = "";
    [Column("segundo_nombre")]
    [MaxLength(50, ErrorMessage = "El segundo nombre no debe exceder los 50 caracteres")]
    public string Nombre2 { get; set; } = "";
    [Column("apellido")]
    [MaxLength(50, ErrorMessage = "El apellido no debe exceder los 50 caracteres")]
    public string Apellido { get; set; } = "";
    [Column("segundo_apellido")]
    [MaxLength(50, ErrorMessage = "El segundo apellido no debe exceder los 50 caracteres")]
    public string Apellido2 { get; set; } = "";
    [Column("perfil")]
    [MaxLength(200, ErrorMessage = "La descripción del perfil no debe exceder los 200 caracteres")]
    public string Perfil { get; set; } = "";
    [Column("direccion")]
    [MaxLength(300, ErrorMessage = "La dirección no debe exceder los 300 caracteres")]
    public string Direccion { get; set; } = "";
    [Column("id_ciudad")]
    public Guid IdCiudad { get; set; }
    [Column("telefono")]
    [Phone]
    [MaxLength(20, ErrorMessage = "El número telefónico no debe exceder los 20 caracteres")]
    public string Telefono { get; set; } = "";
    [Column("telefono2")]
    [MaxLength(20, ErrorMessage = "El número telefónico opcional no debe exceder los 20 caracteres")]
    public string? Telefono2 { get; set; } = "";
    [Column("email")]
    [EmailAddress]
    [MaxLength(250, ErrorMessage = "La dirección de correo no debe exceder los 250 caracteres")]
    public string Email { get; set; } = "";
    [Column("email2")]
    [MaxLength(250, ErrorMessage = "La dirección de correo opcional no debe exceder los 250 caracteres")]
    public string Email2 { get; set; } = "";
    [Column("id_profesion")]
    public Guid? IdProfesion { get; set; }
    [Column("max_publicaciones")]
    public int MaximoPublicaciones { get; set; } = 0;
    [Column("creado_por")]
    public Guid CreadoPor { get; set; }
    [Column("fecha_creacion")]
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    [Column("modificado_por")]
    public Guid ModificadoPor { get; set; }
    [Column("ultima_modificacion")]
    public DateTime UltimaModificacion { get; set; } = DateTime.UtcNow;

    [JsonIgnore]
    public virtual ICollection<Comentario>? Comentarios { get; set; }
    [JsonIgnore]
    public virtual ICollection<Personal>? UsuariosLink { get; set; }
}