using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7508;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7508Controller : CatalogController<TABLE7508Dto, CreateTABLE7508Dto, UpdateTABLE7508Dto, int>
{
    public TABLE7508Controller(ITABLE7508Service service)
        : base(service, "TABLE7508", "NDAMAGE_TYP", new[] { "NDAMAGE_TYP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
