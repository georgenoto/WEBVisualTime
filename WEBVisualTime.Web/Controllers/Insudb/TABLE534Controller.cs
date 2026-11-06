using WEBVisualTime.Servicios.Insudb.DTOs.TABLE534;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE534Controller : CatalogController<TABLE534Dto, CreateTABLE534Dto, UpdateTABLE534Dto, long>
{
    public TABLE534Controller(ITABLE534Service service)
        : base(service, "TABLE534", "NCESS_TYPE", new[] { "NCESS_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
