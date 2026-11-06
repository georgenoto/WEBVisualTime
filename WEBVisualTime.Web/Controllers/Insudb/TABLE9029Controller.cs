using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9029;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9029Controller : CatalogController<TABLE9029Dto, CreateTABLE9029Dto, UpdateTABLE9029Dto, int>
{
    public TABLE9029Controller(ITABLE9029Service service)
        : base(service, "TABLE9029", "NCODRATING", new[] { "NCODRATING", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
