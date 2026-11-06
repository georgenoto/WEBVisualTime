using WEBVisualTime.Servicios.Insudb.DTOs.TABLE19;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE19Controller : CatalogController<TABLE19Dto, CreateTABLE19Dto, UpdateTABLE19Dto, int>
{
    public TABLE19Controller(ITABLE19Service service)
        : base(service, "TABLE19", "NSTATUS_PRE", new[] { "NSTATUS_PRE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
