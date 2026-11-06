using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5728;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5728Controller : CrudApiController<TABLE5728Dto, CreateTABLE5728Dto, UpdateTABLE5728Dto, int>
{
    public TABLE5728Controller(ITABLE5728Service service) : base(service, dto => dto.NFORMPAY) { }
}
