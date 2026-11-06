using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5533;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5533Controller : CatalogController<TABLE5533Dto, CreateTABLE5533Dto, UpdateTABLE5533Dto, int>
{
    public TABLE5533Controller(ITABLE5533Service service)
        : base(service, "TABLE5533", "NPART_AUTO", new[] { "NPART_AUTO", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
