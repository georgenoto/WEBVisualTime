using WEBVisualTime.Servicios.Insudb.DTOs.TABLE502;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE502Controller : CatalogController<TABLE502Dto, CreateTABLE502Dto, UpdateTABLE502Dto, long>
{
    public TABLE502Controller(ITABLE502Service service)
        : base(service, "TABLE502", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
