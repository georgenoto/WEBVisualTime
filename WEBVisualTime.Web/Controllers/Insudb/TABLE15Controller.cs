using WEBVisualTime.Servicios.Insudb.DTOs.TABLE15;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE15Controller : CatalogController<TABLE15Dto, CreateTABLE15Dto, UpdateTABLE15Dto, int>
{
    public TABLE15Controller(ITABLE15Service service)
        : base(service, "TABLE15", "NRELASHIP", new[] { "NRELASHIP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
