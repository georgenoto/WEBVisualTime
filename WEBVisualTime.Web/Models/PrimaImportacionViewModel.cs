using WEBVisualTime.Entidades.ImportacionPrimas;
namespace WEBVisualTime.Web.Models;
public sealed class PrimaImportacionViewModel
{
    public bool Habilitado { get; set; }
    public List<PrimaEstado> Recientes { get; set; } = [];
    public string Id { get; set; } = "";
    public PrimaDocumento? Documento { get; set; }
    public PrimaPlan? Plan { get; set; }
    public PrimaCatalogos? Catalogos { get; set; }
    public PrimaEstado? Estado { get; set; }
    public string Revision { get; set; } = "";
    public int Pagina { get; set; } = 1;
}
