using WEBVisualTime.Servicios.Insudb.DTOs.TABLE400;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE400Controller : CatalogController<TABLE400Dto, CreateTABLE400Dto, UpdateTABLE400Dto, int>
{
    public TABLE400Controller(ITABLE400Service service)
        : base(service, "TABLE400", "NTYP_ACCO", new[] { "NTYP_ACCO", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
