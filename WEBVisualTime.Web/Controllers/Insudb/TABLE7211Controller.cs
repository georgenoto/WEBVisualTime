using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7211;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7211Controller : CatalogController<TABLE7211Dto, CreateTABLE7211Dto, UpdateTABLE7211Dto, int>
{
    public TABLE7211Controller(ITABLE7211Service service)
        : base(service, "TABLE7211", "NEQUIPMENT_TYPE", new[] { "NEQUIPMENT_TYPE", "SDESCRIPT", "SSHORT_DES", "DCOMPDATE", "NUSERCODE", "SSTATREGT" }) { }
}
