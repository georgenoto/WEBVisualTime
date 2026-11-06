using WEBVisualTime.Servicios.Insudb.DTOs.TABLE997;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE997Controller : CatalogController<TABLE997Dto, CreateTABLE997Dto, UpdateTABLE997Dto, int>
{
    public TABLE997Controller(ITABLE997Service service)
        : base(service, "TABLE997", "NMODULE_ERR", new[] { "NMODULE_ERR", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
