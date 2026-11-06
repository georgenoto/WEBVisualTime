using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5661;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5661Controller : CrudApiController<TABLE5661Dto, CreateTABLE5661Dto, UpdateTABLE5661Dto, int>
{
    public TABLE5661Controller(ITABLE5661Service service) : base(service, dto => dto.NTYPE_COST) { }
}
