using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7Controller : CatalogController<TABLE7Dto, CreateTABLE7Dto, UpdateTABLE7Dto, long>
{
    public TABLE7Controller(ITABLE7Service service)
        : base(service, "TABLE7", "NBANK_CODE", new[] { "NBANK_CODE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
