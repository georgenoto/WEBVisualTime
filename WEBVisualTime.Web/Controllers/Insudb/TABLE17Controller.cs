using WEBVisualTime.Servicios.Insudb.DTOs.TABLE17;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE17Controller : CatalogController<TABLE17Dto, CreateTABLE17Dto, UpdateTABLE17Dto, long>
{
    public TABLE17Controller(ITABLE17Service service)
        : base(service, "TABLE17", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
