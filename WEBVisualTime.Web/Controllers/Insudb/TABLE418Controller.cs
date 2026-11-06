using WEBVisualTime.Servicios.Insudb.DTOs.TABLE418;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE418Controller : CatalogController<TABLE418Dto, CreateTABLE418Dto, UpdateTABLE418Dto, long>
{
    public TABLE418Controller(ITABLE418Service service)
        : base(service, "TABLE418", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
