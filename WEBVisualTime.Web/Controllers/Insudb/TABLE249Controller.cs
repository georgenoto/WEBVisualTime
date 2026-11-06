using WEBVisualTime.Servicios.Insudb.DTOs.TABLE249;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE249Controller : CatalogController<TABLE249Dto, CreateTABLE249Dto, UpdateTABLE249Dto, long>
{
    public TABLE249Controller(ITABLE249Service service)
        : base(service, "TABLE249", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
