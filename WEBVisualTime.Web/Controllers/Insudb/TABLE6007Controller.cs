using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6007;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6007Controller : CatalogController<TABLE6007Dto, CreateTABLE6007Dto, UpdateTABLE6007Dto, int>
{
    public TABLE6007Controller(ITABLE6007Service service)
        : base(service, "TABLE6007", "NZONETYPE", new[] { "NZONETYPE", "SDESCRIPT", "DCOMPDATE", "NUSERCODE", "SSHORT_DES", "SSTATREGT" }) { }
}
