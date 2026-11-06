using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5640;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5640Controller : CrudApiController<TABLE5640Dto, CreateTABLE5640Dto, UpdateTABLE5640Dto, int>
{
    public TABLE5640Controller(ITABLE5640Service service) : base(service, dto => dto.NDEFAULTDAT) { }
}
