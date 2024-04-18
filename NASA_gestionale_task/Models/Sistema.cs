using System.ComponentModel.DataAnnotations.Schema;

namespace NASA_gestionale_task.Models
{
    [Table("Sistema")]
    public partial class Sistema
    {
        public int SistemaId { get; set; }

        public string Nome { get; set; } = null!;

        public string Codice { get; set; } = null!;

        public string Tipo { get; set; } = null!;

        public virtual ICollection<OggettoCeleste> OggettoRifs { get; set; } = new List<OggettoCeleste>();
    }

}
