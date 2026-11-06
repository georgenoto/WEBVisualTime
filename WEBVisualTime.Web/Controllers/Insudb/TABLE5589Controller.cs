using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5589;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5589Controller : CatalogController<TABLE5589Dto, CreateTABLE5589Dto, UpdateTABLE5589Dto, int>
{
    public TABLE5589Controller(ITABLE5589Service service)
        : base(service, "TABLE5589", "NTYPDUR", new[] { "NTYPDUR", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
