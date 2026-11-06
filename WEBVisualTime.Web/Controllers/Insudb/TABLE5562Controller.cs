using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5562;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5562Controller : CatalogController<TABLE5562Dto, CreateTABLE5562Dto, UpdateTABLE5562Dto, int>
{
    public TABLE5562Controller(ITABLE5562Service service)
        : base(service, "TABLE5562", "NCASH_OPERTYP", new[] { "NCASH_OPERTYP", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
