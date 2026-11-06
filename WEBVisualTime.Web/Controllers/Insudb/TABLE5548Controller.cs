using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5548;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5548Controller : CatalogController<TABLE5548Dto, CreateTABLE5548Dto, UpdateTABLE5548Dto, int>
{
    public TABLE5548Controller(ITABLE5548Service service)
        : base(service, "TABLE5548", "NLEVEL", new[] { "NLEVEL", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
