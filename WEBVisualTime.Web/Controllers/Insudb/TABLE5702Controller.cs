using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5702;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5702Controller : CatalogController<TABLE5702Dto, CreateTABLE5702Dto, UpdateTABLE5702Dto, int>
{
    public TABLE5702Controller(ITABLE5702Service service)
        : base(service, "TABLE5702", "NFIELDTYPE", new[] { "NFIELDTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
