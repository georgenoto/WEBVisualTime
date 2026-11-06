using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5615;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5615Controller : CrudApiController<TABLE5615Dto, CreateTABLE5615Dto, UpdateTABLE5615Dto, long>
{
    public TABLE5615Controller(ITABLE5615Service service) : base(service, dto => dto.NVALUE_TYP) { }
}
