using WEBVisualTime.Servicios.Insudb.DTOs.TABLE34;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE34Controller : CatalogController<TABLE34Dto, CreateTABLE34Dto, UpdateTABLE34Dto, long>
{
    public TABLE34Controller(ITABLE34Service service)
        : base(service, "TABLE34", "NANLIFINT", new[] { "NANLIFINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
