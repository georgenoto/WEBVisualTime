using WEBVisualTime.Servicios.Insudb.DTOs.TABLE24;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE24Controller : CatalogController<TABLE24Dto, CreateTABLE24Dto, UpdateTABLE24Dto, int>
{
    public TABLE24Controller(ITABLE24Service service)
        : base(service, "TABLE24", "NTRATYPEI", new[] { "NTRATYPEI", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
