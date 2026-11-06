using WEBVisualTime.Servicios.Insudb.DTOs.TABLE298;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE298Controller : CrudApiController<TABLE298Dto, CreateTABLE298Dto, UpdateTABLE298Dto, int>
{
    public TABLE298Controller(ITABLE298Service service) : base(service, dto => dto.NAPLICATION) { }
}
