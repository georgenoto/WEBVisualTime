using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5597;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5597Controller : CatalogController<TABLE5597Dto, CreateTABLE5597Dto, UpdateTABLE5597Dto, int>
{
    public TABLE5597Controller(ITABLE5597Service service)
        : base(service, "TABLE5597", "NORD_TYPECOST", new[] { "NORD_TYPECOST", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
