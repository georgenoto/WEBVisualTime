using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7038;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7038Controller : CatalogController<TABLE7038Dto, CreateTABLE7038Dto, UpdateTABLE7038Dto, int>
{
    public TABLE7038Controller(ITABLE7038Service service)
        : base(service, "TABLE7038", "NROOFTYPE", new[] { "NROOFTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
