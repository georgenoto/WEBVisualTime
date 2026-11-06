using WEBVisualTime.Servicios.Insudb.DTOs.TABLE13;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE13Controller : CrudApiController<TABLE13Dto, CreateTABLE13Dto, UpdateTABLE13Dto, int>
{
    public TABLE13Controller(ITABLE13Service service) : base(service, dto => dto.NNULLCODE) { }
}
