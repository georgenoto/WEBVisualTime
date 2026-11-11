using WEBVisualTime.Entidades.ReplicaBeneficios;
namespace WEBVisualTime.Web.Models;
public sealed class ReplicaBeneficiosViewModel
{
    public bool Habilitado { get; set; }
    public int Producto { get; set; }
    public List<BeneficioOpcion> Productos { get; set; } = [];
    public List<BeneficioOpcion> Modulos { get; set; } = [];
    public List<BeneficioResumen> Recientes { get; set; } = [];
    public BeneficioEstado? Operacion { get; set; }
}
