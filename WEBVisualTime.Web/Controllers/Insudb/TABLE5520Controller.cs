using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5520;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5520Controller : CatalogController<TABLE5520Dto, CreateTABLE5520Dto, UpdateTABLE5520Dto, int>
{
    public TABLE5520Controller(ITABLE5520Service service)
        : base(service, "TABLE5520", "NTYPEINVEST", new[] { "NTYPEINVEST", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE", "NTYPEINVEST_ORIG" }) { }
}
