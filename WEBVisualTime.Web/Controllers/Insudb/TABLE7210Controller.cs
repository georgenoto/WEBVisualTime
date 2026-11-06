using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7210;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7210Controller : CatalogController<TABLE7210Dto, CreateTABLE7210Dto, UpdateTABLE7210Dto, int>
{
    public TABLE7210Controller(ITABLE7210Service service)
        : base(service, "TABLE7210", "NDEPRECIATION", new[] { "NDEPRECIATION", "SDESCRIPT", "DCOMPDATE", "NUSERCODE", "SSHORT_DES", "SSTATREGT" }) { }
}
