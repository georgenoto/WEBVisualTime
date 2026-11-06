using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6072;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6072Controller : CatalogController<TABLE6072Dto, CreateTABLE6072Dto, UpdateTABLE6072Dto, int>
{
    public TABLE6072Controller(ITABLE6072Service service)
        : base(service, "TABLE6072", "NIDCATAS", new[] { "NIDCATAS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
