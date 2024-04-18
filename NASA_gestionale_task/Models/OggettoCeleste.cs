using System.ComponentModel.DataAnnotations.Schema;

namespace NASA_gestionale_task.Models
{
    [Table("OggettoCeleste")]
    public partial class OggettoCeleste
    {
        public int OggettoCelesteId { get; set; }

        public string Nome { get; set; } = null!;

        public string Codice { get; set; } = null!;

        public DateTime? DataScoperta { get; set; }

        public string? Scopritore { get; set; }

        public string Tipologia { get; set; } = null!;

        public decimal DistanzaTerra { get; set; }

        public decimal DistanzaCoordinate { get; set; }

        public decimal AngoloCoordinate { get; set; }

        public virtual ICollection<Sistema> SistemaRifs { get; set; } = new List<Sistema>();
    }

}
