using WEBVisualTime.Servicios.Insudb.DTOs.TABLE89;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE89Controller : CatalogController<TABLE89Dto, CreateTABLE89Dto, UpdateTABLE89Dto, long>
{
    public TABLE89Controller(ITABLE89Service service)
        : base(service, "TABLE89", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
