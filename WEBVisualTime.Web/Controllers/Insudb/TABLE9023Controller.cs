using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9023;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9023Controller : CatalogController<TABLE9023Dto, CreateTABLE9023Dto, UpdateTABLE9023Dto, int>
{
    public TABLE9023Controller(ITABLE9023Service service)
        : base(service, "TABLE9023", "NLIQCURRENT", new[] { "NLIQCURRENT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
