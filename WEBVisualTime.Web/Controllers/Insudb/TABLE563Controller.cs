using WEBVisualTime.Servicios.Insudb.DTOs.TABLE563;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE563Controller : CatalogController<TABLE563Dto, CreateTABLE563Dto, UpdateTABLE563Dto, long>
{
    public TABLE563Controller(ITABLE563Service service)
        : base(service, "TABLE563", "NCODIGINT", new[] { "NCODIGINT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
