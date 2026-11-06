using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6034;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6034Controller : CatalogController<TABLE6034Dto, CreateTABLE6034Dto, UpdateTABLE6034Dto, int>
{
    public TABLE6034Controller(ITABLE6034Service service)
        : base(service, "TABLE6034", "NMODALITYSUMINS", new[] { "NMODALITYSUMINS", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
