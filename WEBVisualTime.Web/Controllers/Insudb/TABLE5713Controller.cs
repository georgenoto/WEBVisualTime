using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5713;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5713Controller : CatalogController<TABLE5713Dto, CreateTABLE5713Dto, UpdateTABLE5713Dto, int>
{
    public TABLE5713Controller(ITABLE5713Service service)
        : base(service, "TABLE5713", "NTYPE", new[] { "NTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
