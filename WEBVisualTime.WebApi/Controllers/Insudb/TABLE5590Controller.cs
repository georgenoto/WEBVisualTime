using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5590;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5590Controller : CrudApiController<TABLE5590Dto, CreateTABLE5590Dto, UpdateTABLE5590Dto, int>
{
    public TABLE5590Controller(ITABLE5590Service service) : base(service, dto => dto.TCREDIT) { }
}
