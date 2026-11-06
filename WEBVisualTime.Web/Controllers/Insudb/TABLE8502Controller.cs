using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8502;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8502Controller : CatalogController<TABLE8502Dto, CreateTABLE8502Dto, UpdateTABLE8502Dto, int>
{
    public TABLE8502Controller(ITABLE8502Service service)
        : base(service, "TABLE8502", "NTYPECALCULATEPREMSOAT", new[] { "NTYPECALCULATEPREMSOAT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
