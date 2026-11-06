using WEBVisualTime.Servicios.Insudb.DTOs.TABLE163;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE163Controller : CrudApiController<TABLE163Dto, CreateTABLE163Dto, UpdateTABLE163Dto, int>
{
    public TABLE163Controller(ITABLE163Service service) : base(service, dto => dto.NNULLCODE) { }
}
