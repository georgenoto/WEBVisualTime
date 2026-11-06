using WEBVisualTime.Servicios.Insudb.DTOs.TABLE296;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE296Controller : CatalogController<TABLE296Dto, CreateTABLE296Dto, UpdateTABLE296Dto, int>
{
    public TABLE296Controller(ITABLE296Service service)
        : base(service, "TABLE296", "NTYPE_MOV", new[] { "NTYPE_MOV", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
