using WEBVisualTime.Servicios.Insudb.DTOs.TABLE3012;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE3012Controller : CatalogController<TABLE3012Dto, CreateTABLE3012Dto, UpdateTABLE3012Dto, int>
{
    public TABLE3012Controller(ITABLE3012Service service)
        : base(service, "TABLE3012", "NENDORSETYPE", new[] { "NENDORSETYPE", "SDESCRIPT", "SSHORT_DES", "DCOMPDATE", "NUSERCODE", "SSTATREGT" }) { }
}
