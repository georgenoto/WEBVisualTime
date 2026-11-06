using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8604;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8604Controller : CatalogController<TABLE8604Dto, CreateTABLE8604Dto, UpdateTABLE8604Dto, string>
{
    public TABLE8604Controller(ITABLE8604Service service)
        : base(service, "TABLE8604", "STYPECARE", new[] { "STYPECARE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
