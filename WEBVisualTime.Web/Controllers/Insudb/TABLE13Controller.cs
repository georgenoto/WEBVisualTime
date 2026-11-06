using WEBVisualTime.Servicios.Insudb.DTOs.TABLE13;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE13Controller : CatalogController<TABLE13Dto, CreateTABLE13Dto, UpdateTABLE13Dto, int>
{
    public TABLE13Controller(ITABLE13Service service)
        : base(service, "TABLE13", "NNULLCODE", new[] { "NNULLCODE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
