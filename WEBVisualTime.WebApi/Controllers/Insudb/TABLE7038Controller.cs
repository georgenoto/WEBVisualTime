using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7038;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7038Controller : CrudApiController<TABLE7038Dto, CreateTABLE7038Dto, UpdateTABLE7038Dto, int>
{
    public TABLE7038Controller(ITABLE7038Service service) : base(service, dto => dto.NROOFTYPE) { }
}
