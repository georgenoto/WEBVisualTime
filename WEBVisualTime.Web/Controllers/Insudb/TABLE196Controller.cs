using WEBVisualTime.Servicios.Insudb.DTOs.TABLE196;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE196Controller : CatalogController<TABLE196Dto, CreateTABLE196Dto, UpdateTABLE196Dto, long>
{
    public TABLE196Controller(ITABLE196Service service)
        : base(service, "TABLE196", "SCODIGINT", new[] { "SCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
