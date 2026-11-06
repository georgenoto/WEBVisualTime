using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9266;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9266Controller : CatalogController<TABLE9266Dto, CreateTABLE9266Dto, UpdateTABLE9266Dto, int>
{
    public TABLE9266Controller(ITABLE9266Service service)
        : base(service, "TABLE9266", "NMOVEMENT_TYPE", new[] { "NMOVEMENT_TYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
