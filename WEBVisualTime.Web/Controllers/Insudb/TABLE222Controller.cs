using WEBVisualTime.Servicios.Insudb.DTOs.TABLE222;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE222Controller : CatalogController<TABLE222Dto, CreateTABLE222Dto, UpdateTABLE222Dto, int>
{
    public TABLE222Controller(ITABLE222Service service)
        : base(service, "TABLE222", "NTITLE", new[] { "NTITLE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
