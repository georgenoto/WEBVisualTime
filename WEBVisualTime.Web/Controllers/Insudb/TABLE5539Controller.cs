using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5539;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5539Controller : CatalogController<TABLE5539Dto, CreateTABLE5539Dto, UpdateTABLE5539Dto, int>
{
    public TABLE5539Controller(ITABLE5539Service service)
        : base(service, "TABLE5539", "NINSTRUMENT_TY", new[] { "NINSTRUMENT_TY", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
