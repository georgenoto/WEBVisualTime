using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5661;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5661Controller : CatalogController<TABLE5661Dto, CreateTABLE5661Dto, UpdateTABLE5661Dto, int>
{
    public TABLE5661Controller(ITABLE5661Service service)
        : base(service, "TABLE5661", "NTYPE_COST", new[] { "NTYPE_COST", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
