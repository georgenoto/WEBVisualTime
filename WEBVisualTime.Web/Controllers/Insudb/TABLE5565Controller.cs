using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5565;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5565Controller : CatalogController<TABLE5565Dto, CreateTABLE5565Dto, UpdateTABLE5565Dto, int>
{
    public TABLE5565Controller(ITABLE5565Service service)
        : base(service, "TABLE5565", "NTYPECODE", new[] { "NTYPECODE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
