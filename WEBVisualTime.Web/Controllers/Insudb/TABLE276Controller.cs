using WEBVisualTime.Servicios.Insudb.DTOs.TABLE276;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE276Controller : CatalogController<TABLE276Dto, CreateTABLE276Dto, UpdateTABLE276Dto, string>
{
    public TABLE276Controller(ITABLE276Service service)
        : base(service, "TABLE276", "STYPE_INFOR", new[] { "STYPE_INFOR", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
