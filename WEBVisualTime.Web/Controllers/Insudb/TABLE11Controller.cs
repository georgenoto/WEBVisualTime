using WEBVisualTime.Servicios.Insudb.DTOs.TABLE11;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE11Controller : CatalogController<TABLE11Dto, CreateTABLE11Dto, UpdateTABLE11Dto, long>
{
    public TABLE11Controller(ITABLE11Service service)
        : base(service, "TABLE11", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
