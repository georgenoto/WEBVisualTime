using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9236;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9236Controller : CatalogController<TABLE9236Dto, CreateTABLE9236Dto, UpdateTABLE9236Dto, int>
{
    public TABLE9236Controller(ITABLE9236Service service)
        : base(service, "TABLE9236", "NTYPE_ID", new[] { "NTYPE_ID", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
