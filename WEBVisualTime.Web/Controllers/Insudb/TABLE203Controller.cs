using WEBVisualTime.Servicios.Insudb.DTOs.TABLE203;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE203Controller : CatalogController<TABLE203Dto, CreateTABLE203Dto, UpdateTABLE203Dto, int>
{
    public TABLE203Controller(ITABLE203Service service)
        : base(service, "TABLE203", "NSTATUS_DOC", new[] { "NSTATUS_DOC", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
