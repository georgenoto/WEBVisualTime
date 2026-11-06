using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9255;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9255Controller : CatalogController<TABLE9255Dto, CreateTABLE9255Dto, UpdateTABLE9255Dto, int>
{
    public TABLE9255Controller(ITABLE9255Service service)
        : base(service, "TABLE9255", "NCOD_INSTEDUC", new[] { "NCOD_INSTEDUC", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
