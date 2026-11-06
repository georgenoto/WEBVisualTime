using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8103;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8103Controller : CatalogController<TABLE8103Dto, CreateTABLE8103Dto, UpdateTABLE8103Dto, int>
{
    public TABLE8103Controller(ITABLE8103Service service)
        : base(service, "TABLE8103", "NWAIT_CODE", new[] { "NWAIT_CODE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
