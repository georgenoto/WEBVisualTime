using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8018;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8018Controller : CatalogController<TABLE8018Dto, CreateTABLE8018Dto, UpdateTABLE8018Dto, int>
{
    public TABLE8018Controller(ITABLE8018Service service)
        : base(service, "TABLE8018", "NNOTINFORMEMAIL", new[] { "NNOTINFORMEMAIL", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
