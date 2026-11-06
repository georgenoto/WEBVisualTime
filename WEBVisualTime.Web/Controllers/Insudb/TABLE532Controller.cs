using WEBVisualTime.Servicios.Insudb.DTOs.TABLE532;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE532Controller : CatalogController<TABLE532Dto, CreateTABLE532Dto, UpdateTABLE532Dto, int>
{
    public TABLE532Controller(ITABLE532Service service)
        : base(service, "TABLE532", "NTYP_AMOUNT", new[] { "NTYP_AMOUNT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
