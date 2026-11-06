using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5605;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5605Controller : CatalogController<TABLE5605Dto, CreateTABLE5605Dto, UpdateTABLE5605Dto, int>
{
    public TABLE5605Controller(ITABLE5605Service service)
        : base(service, "TABLE5605", "NDOC_TYPE", new[] { "NDOC_TYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
