using WEBVisualTime.Servicios.Insudb.DTOs.TABLE184;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE184Controller : CatalogController<TABLE184Dto, CreateTABLE184Dto, UpdateTABLE184Dto, int>
{
    public TABLE184Controller(ITABLE184Service service)
        : base(service, "TABLE184", "NBENE_TYPE", new[] { "NBENE_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
