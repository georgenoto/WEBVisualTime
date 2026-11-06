using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5719;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5719Controller : CrudApiController<TABLE5719Dto, CreateTABLE5719Dto, UpdateTABLE5719Dto, int>
{
    public TABLE5719Controller(ITABLE5719Service service) : base(service, dto => dto.NREASON) { }
}
