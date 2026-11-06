using WEBVisualTime.Servicios.Insudb.DTOs.TABLE149;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE149Controller : CatalogController<TABLE149Dto, CreateTABLE149Dto, UpdateTABLE149Dto, int>
{
    public TABLE149Controller(ITABLE149Service service)
        : base(service, "TABLE149", "NHOUSE_TYPE", new[] { "NHOUSE_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
