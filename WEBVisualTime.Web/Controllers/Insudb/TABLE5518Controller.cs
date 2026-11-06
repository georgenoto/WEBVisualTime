using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5518;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5518Controller : CatalogController<TABLE5518Dto, CreateTABLE5518Dto, UpdateTABLE5518Dto, int>
{
    public TABLE5518Controller(ITABLE5518Service service)
        : base(service, "TABLE5518", "NNATIONALITY", new[] { "NNATIONALITY", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
