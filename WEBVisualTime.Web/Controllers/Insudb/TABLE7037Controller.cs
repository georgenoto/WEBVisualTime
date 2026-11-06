using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7037;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7037Controller : CatalogController<TABLE7037Dto, CreateTABLE7037Dto, UpdateTABLE7037Dto, int>
{
    public TABLE7037Controller(ITABLE7037Service service)
        : base(service, "TABLE7037", "NSIDECLOSETYPE", new[] { "NSIDECLOSETYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
