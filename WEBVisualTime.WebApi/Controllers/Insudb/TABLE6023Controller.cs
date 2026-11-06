using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6023;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6023Controller : CrudApiController<TABLE6023Dto, CreateTABLE6023Dto, UpdateTABLE6023Dto, int>
{
    public TABLE6023Controller(ITABLE6023Service service) : base(service, dto => dto.NCLASSTYPDOC) { }
}
