using WEBVisualTime.Servicios.Insudb.DTOs.TABLE324;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE324Controller : CatalogController<TABLE324Dto, CreateTABLE324Dto, UpdateTABLE324Dto, int>
{
    public TABLE324Controller(ITABLE324Service service)
        : base(service, "TABLE324", "NTYPE", new[] { "NTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
