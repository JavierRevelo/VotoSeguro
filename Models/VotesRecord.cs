namespace VotoSeguro.Models
{
    public class VotesRecord
    {

        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadVotos { get; set; }
    }
}
