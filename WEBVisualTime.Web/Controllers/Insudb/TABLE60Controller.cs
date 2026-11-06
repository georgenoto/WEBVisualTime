using WEBVisualTime.Servicios.Insudb.DTOs.TABLE60;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE60Controller : CatalogController<TABLE60Dto, CreateTABLE60Dto, UpdateTABLE60Dto, long>
{
    public TABLE60Controller(ITABLE60Service service)
        : base(service, "TABLE60", "NPAYCONRE", new[] { "NPAYCONRE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
