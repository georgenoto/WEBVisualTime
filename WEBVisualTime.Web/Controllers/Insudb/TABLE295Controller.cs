using WEBVisualTime.Servicios.Insudb.DTOs.TABLE295;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE295Controller : CatalogController<TABLE295Dto, CreateTABLE295Dto, UpdateTABLE295Dto, int>
{
    public TABLE295Controller(ITABLE295Service service)
        : base(service, "TABLE295", "NNULLCODE", new[] { "NNULLCODE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
