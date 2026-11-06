using WEBVisualTime.Servicios.Insudb.DTOs.TABLE564;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE564Controller : CatalogController<TABLE564Dto, CreateTABLE564Dto, UpdateTABLE564Dto, int>
{
    public TABLE564Controller(ITABLE564Service service)
        : base(service, "TABLE564", "NPHONE_TYPE", new[] { "NPHONE_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
