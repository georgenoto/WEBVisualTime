using WEBVisualTime.Servicios.Insudb.DTOs.TABLE25;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE25Controller : CatalogController<TABLE25Dto, CreateTABLE25Dto, UpdateTABLE25Dto, string>
{
    public TABLE25Controller(ITABLE25Service service)
        : base(service, "TABLE25", "STIMEREN", new[] { "STIMEREN", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
