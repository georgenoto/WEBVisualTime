using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8008;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8008Controller : CrudApiController<TABLE8008Dto, CreateTABLE8008Dto, UpdateTABLE8008Dto, int>
{
    public TABLE8008Controller(ITABLE8008Service service) : base(service, dto => dto.NORIGINS) { }
}
