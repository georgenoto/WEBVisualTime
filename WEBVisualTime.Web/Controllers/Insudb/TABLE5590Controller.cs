using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5590;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5590Controller : CatalogController<TABLE5590Dto, CreateTABLE5590Dto, UpdateTABLE5590Dto, int>
{
    public TABLE5590Controller(ITABLE5590Service service)
        : base(service, "TABLE5590", "TCREDIT", new[] { "TCREDIT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
