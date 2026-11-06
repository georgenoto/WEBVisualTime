using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5524;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5524Controller : CatalogController<TABLE5524Dto, CreateTABLE5524Dto, UpdateTABLE5524Dto, long>
{
    public TABLE5524Controller(ITABLE5524Service service)
        : base(service, "TABLE5524", "NAFP", new[] { "NAFP", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
