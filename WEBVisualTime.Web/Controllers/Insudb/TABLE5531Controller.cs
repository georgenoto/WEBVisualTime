using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5531;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5531Controller : CatalogController<TABLE5531Dto, CreateTABLE5531Dto, UpdateTABLE5531Dto, int>
{
    public TABLE5531Controller(ITABLE5531Service service)
        : base(service, "TABLE5531", "NCHANGE", new[] { "NCHANGE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
