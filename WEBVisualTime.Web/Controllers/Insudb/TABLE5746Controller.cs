using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5746;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5746Controller : CatalogController<TABLE5746Dto, CreateTABLE5746Dto, UpdateTABLE5746Dto, int>
{
    public TABLE5746Controller(ITABLE5746Service service)
        : base(service, "TABLE5746", "NTYPEMOVRH", new[] { "NTYPEMOVRH", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
