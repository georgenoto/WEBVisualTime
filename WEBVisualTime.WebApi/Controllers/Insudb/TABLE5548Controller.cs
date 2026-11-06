using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5548;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5548Controller : CrudApiController<TABLE5548Dto, CreateTABLE5548Dto, UpdateTABLE5548Dto, int>
{
    public TABLE5548Controller(ITABLE5548Service service) : base(service, dto => dto.NLEVEL) { }
}
