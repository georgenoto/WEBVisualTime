using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6023;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6023Controller : CatalogController<TABLE6023Dto, CreateTABLE6023Dto, UpdateTABLE6023Dto, int>
{
    public TABLE6023Controller(ITABLE6023Service service)
        : base(service, "TABLE6023", "NCLASSTYPDOC", new[] { "NCLASSTYPDOC", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
