using WEBVisualTime.Servicios.Insudb.DTOs.TABLE157;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE157Controller : CatalogController<TABLE157Dto, CreateTABLE157Dto, UpdateTABLE157Dto, long>
{
    public TABLE157Controller(ITABLE157Service service)
        : base(service, "TABLE157", "SCODIGINT", new[] { "SCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
