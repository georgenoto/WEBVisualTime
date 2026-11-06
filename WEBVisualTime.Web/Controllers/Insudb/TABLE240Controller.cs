using WEBVisualTime.Servicios.Insudb.DTOs.TABLE240;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE240Controller : CatalogController<TABLE240Dto, CreateTABLE240Dto, UpdateTABLE240Dto, int>
{
    public TABLE240Controller(ITABLE240Service service)
        : base(service, "TABLE240", "NCATEGORY", new[] { "NCATEGORY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
