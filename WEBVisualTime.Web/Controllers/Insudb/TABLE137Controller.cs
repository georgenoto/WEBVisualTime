using WEBVisualTime.Servicios.Insudb.DTOs.TABLE137;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE137Controller : CatalogController<TABLE137Dto, CreateTABLE137Dto, UpdateTABLE137Dto, int>
{
    public TABLE137Controller(ITABLE137Service service)
        : base(service, "TABLE137", "NTYPE_PAY", new[] { "NTYPE_PAY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
