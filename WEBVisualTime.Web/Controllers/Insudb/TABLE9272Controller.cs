using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9272;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9272Controller : CatalogController<TABLE9272Dto, CreateTABLE9272Dto, UpdateTABLE9272Dto, int>
{
    public TABLE9272Controller(ITABLE9272Service service)
        : base(service, "TABLE9272", "NACCCRITERION", new[] { "NACCCRITERION", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
