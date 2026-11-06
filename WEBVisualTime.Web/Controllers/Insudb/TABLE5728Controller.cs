using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5728;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5728Controller : CatalogController<TABLE5728Dto, CreateTABLE5728Dto, UpdateTABLE5728Dto, int>
{
    public TABLE5728Controller(ITABLE5728Service service)
        : base(service, "TABLE5728", "NFORMPAY", new[] { "NFORMPAY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
