using WEBVisualTime.Servicios.Insudb.DTOs.TABLE313;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE313Controller : CatalogController<TABLE313Dto, CreateTABLE313Dto, UpdateTABLE313Dto, int>
{
    public TABLE313Controller(ITABLE313Service service)
        : base(service, "TABLE313", "NOPERATOR", new[] { "NOPERATOR", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
