using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5601;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5601Controller : CatalogController<TABLE5601Dto, CreateTABLE5601Dto, UpdateTABLE5601Dto, int>
{
    public TABLE5601Controller(ITABLE5601Service service)
        : base(service, "TABLE5601", "NCODMODPAY", new[] { "NCODMODPAY", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
