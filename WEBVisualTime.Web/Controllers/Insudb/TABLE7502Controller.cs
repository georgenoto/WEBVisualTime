using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7502;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7502Controller : CatalogController<TABLE7502Dto, CreateTABLE7502Dto, UpdateTABLE7502Dto, string>
{
    public TABLE7502Controller(ITABLE7502Service service)
        : base(service, "TABLE7502", "SREL_TYPE", new[] { "SREL_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
