using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5634;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5634Controller : CatalogController<TABLE5634Dto, CreateTABLE5634Dto, UpdateTABLE5634Dto, int>
{
    public TABLE5634Controller(ITABLE5634Service service)
        : base(service, "TABLE5634", "NTYPEINSTITU", new[] { "NTYPEINSTITU", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
