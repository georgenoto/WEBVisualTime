using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8016;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8016Controller : CatalogController<TABLE8016Dto, CreateTABLE8016Dto, UpdateTABLE8016Dto, int>
{
    public TABLE8016Controller(ITABLE8016Service service)
        : base(service, "TABLE8016", "NTYPMOV_GUAR", new[] { "NTYPMOV_GUAR", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
