using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5615;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5615Controller : CatalogController<TABLE5615Dto, CreateTABLE5615Dto, UpdateTABLE5615Dto, long>
{
    public TABLE5615Controller(ITABLE5615Service service)
        : base(service, "TABLE5615", "NVALUE_TYP", new[] { "NVALUE_TYP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
