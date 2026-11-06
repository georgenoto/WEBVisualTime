using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5581;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5581Controller : CatalogController<TABLE5581Dto, CreateTABLE5581Dto, UpdateTABLE5581Dto, int>
{
    public TABLE5581Controller(ITABLE5581Service service)
        : base(service, "TABLE5581", "NTYPE_REC", new[] { "NTYPE_REC", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
