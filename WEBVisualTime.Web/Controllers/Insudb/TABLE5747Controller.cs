using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5747;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5747Controller : CatalogController<TABLE5747Dto, CreateTABLE5747Dto, UpdateTABLE5747Dto, int>
{
    public TABLE5747Controller(ITABLE5747Service service)
        : base(service, "TABLE5747", "NTYPE_SPAY", new[] { "NTYPE_SPAY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
