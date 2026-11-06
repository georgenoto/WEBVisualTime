using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5530;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5530Controller : CatalogController<TABLE5530Dto, CreateTABLE5530Dto, UpdateTABLE5530Dto, int>
{
    public TABLE5530Controller(ITABLE5530Service service)
        : base(service, "TABLE5530", "NCOMP_TYPE", new[] { "NCOMP_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
