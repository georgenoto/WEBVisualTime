using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5677;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5677Controller : CrudApiController<TABLE5677Dto, CreateTABLE5677Dto, UpdateTABLE5677Dto, int>
{
    public TABLE5677Controller(ITABLE5677Service service) : base(service, dto => dto.NREPINSURED) { }
}
