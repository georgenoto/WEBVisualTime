using WEBVisualTime.Servicios.Insudb.DTOs.TABLE900;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE900Controller : CatalogController<TABLE900Dto, CreateTABLE900Dto, UpdateTABLE900Dto, long>
{
    public TABLE900Controller(ITABLE900Service service)
        : base(service, "TABLE900", "SCODIGINT", new[] { "SCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
