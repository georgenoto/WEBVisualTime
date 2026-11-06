using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5576;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5576Controller : CatalogController<TABLE5576Dto, CreateTABLE5576Dto, UpdateTABLE5576Dto, int>
{
    public TABLE5576Controller(ITABLE5576Service service)
        : base(service, "TABLE5576", "NCHEQUE_STAT", new[] { "NCHEQUE_STAT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
