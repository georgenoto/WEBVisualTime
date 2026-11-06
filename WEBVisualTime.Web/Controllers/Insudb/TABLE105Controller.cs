using WEBVisualTime.Servicios.Insudb.DTOs.TABLE105;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE105Controller : CatalogController<TABLE105Dto, CreateTABLE105Dto, UpdateTABLE105Dto, string>
{
    public TABLE105Controller(ITABLE105Service service)
        : base(service, "TABLE105", "STYPE", new[] { "STYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
