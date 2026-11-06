using WEBVisualTime.Servicios.Insudb.DTOs.TABLE78;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE78Controller : CatalogController<TABLE78Dto, CreateTABLE78Dto, UpdateTABLE78Dto, int>
{
    public TABLE78Controller(ITABLE78Service service)
        : base(service, "TABLE78", "NMOV_TYPE", new[] { "NMOV_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
