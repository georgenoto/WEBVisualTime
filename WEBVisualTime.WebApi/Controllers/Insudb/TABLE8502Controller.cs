using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8502;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8502Controller : CrudApiController<TABLE8502Dto, CreateTABLE8502Dto, UpdateTABLE8502Dto, int>
{
    public TABLE8502Controller(ITABLE8502Service service) : base(service, dto => dto.NTYPECALCULATEPREMSOAT) { }
}
