using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9024;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9024Controller : CatalogController<TABLE9024Dto, CreateTABLE9024Dto, UpdateTABLE9024Dto, int>
{
    public TABLE9024Controller(ITABLE9024Service service)
        : base(service, "TABLE9024", "NLIQACD", new[] { "NLIQACD", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
