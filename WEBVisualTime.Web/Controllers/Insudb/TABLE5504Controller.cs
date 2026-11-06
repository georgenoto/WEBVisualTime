using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5504;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5504Controller : CatalogController<TABLE5504Dto, CreateTABLE5504Dto, UpdateTABLE5504Dto, int>
{
    public TABLE5504Controller(ITABLE5504Service service)
        : base(service, "TABLE5504", "NTYPDRIVER", new[] { "NTYPDRIVER", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
