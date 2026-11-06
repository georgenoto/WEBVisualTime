using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9202;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9202Controller : CatalogController<TABLE9202Dto, CreateTABLE9202Dto, UpdateTABLE9202Dto, int>
{
    public TABLE9202Controller(ITABLE9202Service service)
        : base(service, "TABLE9202", "NCATEGORY", new[] { "NCATEGORY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "NINTERM_TYP" }) { }
}
