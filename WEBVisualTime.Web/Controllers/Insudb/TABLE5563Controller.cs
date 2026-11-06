using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5563;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5563Controller : CatalogController<TABLE5563Dto, CreateTABLE5563Dto, UpdateTABLE5563Dto, int>
{
    public TABLE5563Controller(ITABLE5563Service service)
        : base(service, "TABLE5563", "NCLASIFIC", new[] { "NCLASIFIC", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
