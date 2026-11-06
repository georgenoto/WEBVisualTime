using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5671;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5671Controller : CatalogController<TABLE5671Dto, CreateTABLE5671Dto, UpdateTABLE5671Dto, int>
{
    public TABLE5671Controller(ITABLE5671Service service)
        : base(service, "TABLE5671", "NTYPE_COMM", new[] { "NTYPE_COMM", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
