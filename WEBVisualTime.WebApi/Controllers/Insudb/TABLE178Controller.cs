using WEBVisualTime.Servicios.Insudb.DTOs.TABLE178;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE178Controller : CrudApiController<TABLE178Dto, CreateTABLE178Dto, UpdateTABLE178Dto, int>
{
    public TABLE178Controller(ITABLE178Service service) : base(service, dto => dto.NAREA_LED) { }
}
