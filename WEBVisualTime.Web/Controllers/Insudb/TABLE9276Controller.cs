using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9276;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9276Controller : CatalogController<TABLE9276Dto, CreateTABLE9276Dto, UpdateTABLE9276Dto, int>
{
    public TABLE9276Controller(ITABLE9276Service service)
        : base(service, "TABLE9276", "NMOVEMENT_TYPE", new[] { "NMOVEMENT_TYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
