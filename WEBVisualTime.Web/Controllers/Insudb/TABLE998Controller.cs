using WEBVisualTime.Servicios.Insudb.DTOs.TABLE998;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE998Controller : CatalogController<TABLE998Dto, CreateTABLE998Dto, UpdateTABLE998Dto, int>
{
    public TABLE998Controller(ITABLE998Service service)
        : base(service, "TABLE998", "NCOMPTYPE", new[] { "NCOMPTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
