using WEBVisualTime.Servicios.Insudb.DTOs.TABLE180;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE180Controller : CatalogController<TABLE180Dto, CreateTABLE180Dto, UpdateTABLE180Dto, long>
{
    public TABLE180Controller(ITABLE180Service service)
        : base(service, "TABLE180", "NFOR_PAY", new[] { "NFOR_PAY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
