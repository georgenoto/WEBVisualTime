using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5532;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5532Controller : CatalogController<TABLE5532Dto, CreateTABLE5532Dto, UpdateTABLE5532Dto, int>
{
    public TABLE5532Controller(ITABLE5532Service service)
        : base(service, "TABLE5532", "NSELLCHANNEL", new[] { "NSELLCHANNEL", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
