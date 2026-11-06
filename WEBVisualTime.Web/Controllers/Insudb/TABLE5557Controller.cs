using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5557;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5557Controller : CatalogController<TABLE5557Dto, CreateTABLE5557Dto, UpdateTABLE5557Dto, int>
{
    public TABLE5557Controller(ITABLE5557Service service)
        : base(service, "TABLE5557", "NCONTYPE", new[] { "NCONTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
