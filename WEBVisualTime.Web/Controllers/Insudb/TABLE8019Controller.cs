using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8019;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8019Controller : CatalogController<TABLE8019Dto, CreateTABLE8019Dto, UpdateTABLE8019Dto, int>
{
    public TABLE8019Controller(ITABLE8019Service service)
        : base(service, "TABLE8019", "NGROUP_SAVING", new[] { "NGROUP_SAVING", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
