using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8202;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8202Controller : CatalogController<TABLE8202Dto, CreateTABLE8202Dto, UpdateTABLE8202Dto, long>
{
    public TABLE8202Controller(ITABLE8202Service service)
        : base(service, "TABLE8202", "NSTATUS", new[] { "NSTATUS", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
