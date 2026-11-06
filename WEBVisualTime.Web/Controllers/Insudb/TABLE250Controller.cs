using WEBVisualTime.Servicios.Insudb.DTOs.TABLE250;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE250Controller : CatalogController<TABLE250Dto, CreateTABLE250Dto, UpdateTABLE250Dto, int>
{
    public TABLE250Controller(ITABLE250Service service)
        : base(service, "TABLE250", "NFRECUENCY", new[] { "NFRECUENCY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
