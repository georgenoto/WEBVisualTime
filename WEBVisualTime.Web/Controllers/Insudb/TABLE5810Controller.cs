using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5810;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5810Controller : CatalogController<TABLE5810Dto, CreateTABLE5810Dto, UpdateTABLE5810Dto, int>
{
    public TABLE5810Controller(ITABLE5810Service service)
        : base(service, "TABLE5810", "NQAMENTYPE", new[] { "NQAMENTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
