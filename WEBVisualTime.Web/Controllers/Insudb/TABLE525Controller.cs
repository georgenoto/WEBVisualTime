using WEBVisualTime.Servicios.Insudb.DTOs.TABLE525;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE525Controller : CatalogController<TABLE525Dto, CreateTABLE525Dto, UpdateTABLE525Dto, int>
{
    public TABLE525Controller(ITABLE525Service service)
        : base(service, "TABLE525", "NMOD_TYPE", new[] { "NMOD_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
