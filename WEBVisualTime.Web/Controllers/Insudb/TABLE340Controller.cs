using WEBVisualTime.Servicios.Insudb.DTOs.TABLE340;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE340Controller : CatalogController<TABLE340Dto, CreateTABLE340Dto, UpdateTABLE340Dto, int>
{
    public TABLE340Controller(ITABLE340Service service)
        : base(service, "TABLE340", "NFREQMAXEVEN", new[] { "NFREQMAXEVEN", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
