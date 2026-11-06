using WEBVisualTime.Servicios.Insudb.DTOs.TABLE287;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE287Controller : CatalogController<TABLE287Dto, CreateTABLE287Dto, UpdateTABLE287Dto, long>
{
    public TABLE287Controller(ITABLE287Service service)
        : base(service, "TABLE287", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
