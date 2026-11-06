using WEBVisualTime.Servicios.Insudb.DTOs.TABLE273;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE273Controller : CatalogController<TABLE273Dto, CreateTABLE273Dto, UpdateTABLE273Dto, int>
{
    public TABLE273Controller(ITABLE273Service service)
        : base(service, "TABLE273", "NCATEG", new[] { "NCATEG", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
