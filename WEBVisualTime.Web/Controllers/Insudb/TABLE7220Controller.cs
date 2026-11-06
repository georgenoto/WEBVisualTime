using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7220;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7220Controller : CatalogController<TABLE7220Dto, CreateTABLE7220Dto, UpdateTABLE7220Dto, int>
{
    public TABLE7220Controller(ITABLE7220Service service)
        : base(service, "TABLE7220", "NSECTION", new[] { "NSECTION", "SDESCRIPT", "SSHORT_DES", "DCOMPDATE", "NUSERCODE", "SSTATREGT" }) { }
}
