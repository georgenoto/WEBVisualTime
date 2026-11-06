using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5532;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5532Controller : CrudApiController<TABLE5532Dto, CreateTABLE5532Dto, UpdateTABLE5532Dto, int>
{
    public TABLE5532Controller(ITABLE5532Service service) : base(service, dto => dto.NSELLCHANNEL) { }
}
