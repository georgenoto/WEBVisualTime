using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5741;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5741Controller : CatalogController<TABLE5741Dto, CreateTABLE5741Dto, UpdateTABLE5741Dto, int>
{
    public TABLE5741Controller(ITABLE5741Service service)
        : base(service, "TABLE5741", "NCODE_STATE", new[] { "NCODE_STATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
