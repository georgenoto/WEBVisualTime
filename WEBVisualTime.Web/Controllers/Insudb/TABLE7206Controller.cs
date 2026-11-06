using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7206;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7206Controller : CatalogController<TABLE7206Dto, CreateTABLE7206Dto, UpdateTABLE7206Dto, int>
{
    public TABLE7206Controller(ITABLE7206Service service)
        : base(service, "TABLE7206", "NINSURTYPE", new[] { "NINSURTYPE", "SDESCRIPT", "SSHORT_DES", "DCOMPDATE", "NUSERCODE", "SSTATREGT" }) { }
}
