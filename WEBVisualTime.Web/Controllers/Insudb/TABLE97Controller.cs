using WEBVisualTime.Servicios.Insudb.DTOs.TABLE97;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE97Controller : CatalogController<TABLE97Dto, CreateTABLE97Dto, UpdateTABLE97Dto, int>
{
    public TABLE97Controller(ITABLE97Service service)
        : base(service, "TABLE97", "NTYPE_PER", new[] { "NTYPE_PER", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
