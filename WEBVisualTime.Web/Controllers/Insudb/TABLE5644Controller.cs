using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5644;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5644Controller : CatalogController<TABLE5644Dto, CreateTABLE5644Dto, UpdateTABLE5644Dto, int>
{
    public TABLE5644Controller(ITABLE5644Service service)
        : base(service, "TABLE5644", "NTYPE_PERIOD", new[] { "NTYPE_PERIOD", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
