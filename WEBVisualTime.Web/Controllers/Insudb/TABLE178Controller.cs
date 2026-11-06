using WEBVisualTime.Servicios.Insudb.DTOs.TABLE178;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE178Controller : CatalogController<TABLE178Dto, CreateTABLE178Dto, UpdateTABLE178Dto, int>
{
    public TABLE178Controller(ITABLE178Service service)
        : base(service, "TABLE178", "NAREA_LED", new[] { "NAREA_LED", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
