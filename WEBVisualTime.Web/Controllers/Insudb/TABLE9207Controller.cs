using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9207;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9207Controller : CatalogController<TABLE9207Dto, CreateTABLE9207Dto, UpdateTABLE9207Dto, int>
{
    public TABLE9207Controller(ITABLE9207Service service)
        : base(service, "TABLE9207", "NDISSUR_TYPE", new[] { "NDISSUR_TYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
