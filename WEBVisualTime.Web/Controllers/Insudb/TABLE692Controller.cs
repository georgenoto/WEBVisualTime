using WEBVisualTime.Servicios.Insudb.DTOs.TABLE692;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE692Controller : CatalogController<TABLE692Dto, CreateTABLE692Dto, UpdateTABLE692Dto, int>
{
    public TABLE692Controller(ITABLE692Service service)
        : base(service, "TABLE692", "NDEMAN_TYPE", new[] { "NDEMAN_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
