using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5622;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5622Controller : CatalogController<TABLE5622Dto, CreateTABLE5622Dto, UpdateTABLE5622Dto, int>
{
    public TABLE5622Controller(ITABLE5622Service service)
        : base(service, "TABLE5622", "NTYPEOFWORK", new[] { "NTYPEOFWORK", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
