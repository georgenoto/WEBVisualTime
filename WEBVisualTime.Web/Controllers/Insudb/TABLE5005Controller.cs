using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5005;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5005Controller : CatalogController<TABLE5005Dto, CreateTABLE5005Dto, UpdateTABLE5005Dto, int>
{
    public TABLE5005Controller(ITABLE5005Service service)
        : base(service, "TABLE5005", "NCANCEL_COD", new[] { "NCANCEL_COD", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
