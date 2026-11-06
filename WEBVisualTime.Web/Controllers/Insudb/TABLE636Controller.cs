using WEBVisualTime.Servicios.Insudb.DTOs.TABLE636;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE636Controller : CatalogController<TABLE636Dto, CreateTABLE636Dto, UpdateTABLE636Dto, long>
{
    public TABLE636Controller(ITABLE636Service service)
        : base(service, "TABLE636", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
