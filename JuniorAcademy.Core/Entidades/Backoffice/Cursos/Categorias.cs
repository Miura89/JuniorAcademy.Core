using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorAcademy.Domain.Entidades.Backoffice.Cursos;

public class Categorias
{
    public int Id { get; set; }
    public int CursoId { get; set; }
    public string NomeCategoria { get; set; }
    public bool Status { get; set; }
    public string CriadoPor { get; set; }
    public DateTime CriadoEm { get; set; }
    public string AtualizadoPor { get; set; }
    public DateTime AtualizadoEm { get; set; }
    public string ImagemCategoria { get; set; }
}
