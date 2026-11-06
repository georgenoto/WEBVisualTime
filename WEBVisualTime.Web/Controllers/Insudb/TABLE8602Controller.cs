using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8602;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8602Controller : CatalogController<TABLE8602Dto, CreateTABLE8602Dto, UpdateTABLE8602Dto, string>
{
    public TABLE8602Controller(ITABLE8602Service service)
        : base(service, "TABLE8602", "SGROUP_ILL", new[] { "SGROUP_ILL", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
