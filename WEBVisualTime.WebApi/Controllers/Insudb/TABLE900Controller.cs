using WEBVisualTime.Servicios.Insudb.DTOs.TABLE900;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE900Controller : CrudApiController<TABLE900Dto, CreateTABLE900Dto, UpdateTABLE900Dto, long>
{
    public TABLE900Controller(ITABLE900Service service) : base(service, dto => dto.SCODIGINT) { }
}
