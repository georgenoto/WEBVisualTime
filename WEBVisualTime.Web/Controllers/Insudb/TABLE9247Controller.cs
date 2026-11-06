using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9247;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9247Controller : CatalogController<TABLE9247Dto, CreateTABLE9247Dto, UpdateTABLE9247Dto, int>
{
    public TABLE9247Controller(ITABLE9247Service service)
        : base(service, "TABLE9247", "NFOREIGNDOCTYPE", new[] { "NFOREIGNDOCTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
