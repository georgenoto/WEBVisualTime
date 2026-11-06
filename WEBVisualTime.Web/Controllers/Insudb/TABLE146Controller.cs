using WEBVisualTime.Servicios.Insudb.DTOs.TABLE146;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE146Controller : CatalogController<TABLE146Dto, CreateTABLE146Dto, UpdateTABLE146Dto, int>
{
    public TABLE146Controller(ITABLE146Service service)
        : base(service, "TABLE146", "NCLASS", new[] { "NCLASS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
