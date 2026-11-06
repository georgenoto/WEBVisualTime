using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9108;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9108Controller : CatalogController<TABLE9108Dto, CreateTABLE9108Dto, UpdateTABLE9108Dto, int>
{
    public TABLE9108Controller(ITABLE9108Service service)
        : base(service, "TABLE9108", "NTYPE_CONTRAT", new[] { "NTYPE_CONTRAT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
