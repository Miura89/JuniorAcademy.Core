using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorAcademy.Domain.Entidades.Backoffice.Cursos;

public class Cursos
{
    public int Id { get; set; }
    public int CategoriaId { get; set; }
    public List<int> ClientesId { get; set; }
    public string NivelCurso { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int CargaHoraria { get; set; }
    public int Tempo { get; set; }
    public string CriadoPor { get; set; }
    public DateTime CriadoEm { get; set; }
    public bool Status { get; set; }
    public int PessoasCadastradas { get; set; }
    public int MediaAvaliacao { get; set; }
    public string LinkCurso { get; set; }
    public int Visualizacao { get; set; }
}
