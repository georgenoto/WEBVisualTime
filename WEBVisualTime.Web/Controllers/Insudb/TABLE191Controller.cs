using WEBVisualTime.Servicios.Insudb.DTOs.TABLE191;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE191Controller : CatalogController<TABLE191Dto, CreateTABLE191Dto, UpdateTABLE191Dto, string>
{
    public TABLE191Controller(ITABLE191Service service)
        : base(service, "TABLE191", "SSTATLOAN", new[] { "SSTATLOAN", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
