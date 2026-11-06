using WEBVisualTime.Servicios.Insudb.DTOs.TABLE294;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE294Controller : CatalogController<TABLE294Dto, CreateTABLE294Dto, UpdateTABLE294Dto, int>
{
    public TABLE294Controller(ITABLE294Service service)
        : base(service, "TABLE294", "NEFFCLAMO", new[] { "NEFFCLAMO", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
