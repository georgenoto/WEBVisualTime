using WEBVisualTime.Servicios.Insudb.DTOs.TABLE187;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE187Controller : CatalogController<TABLE187Dto, CreateTABLE187Dto, UpdateTABLE187Dto, int>
{
    public TABLE187Controller(ITABLE187Service service)
        : base(service, "TABLE187", "NSTA_CHEQUE", new[] { "NSTA_CHEQUE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
