using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9031;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9031Controller : CatalogController<TABLE9031Dto, CreateTABLE9031Dto, UpdateTABLE9031Dto, int>
{
    public TABLE9031Controller(ITABLE9031Service service)
        : base(service, "TABLE9031", "NBRANCHCIA", new[] { "NBRANCHCIA", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
