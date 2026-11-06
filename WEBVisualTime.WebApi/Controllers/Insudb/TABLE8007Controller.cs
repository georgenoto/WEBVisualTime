using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8007;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8007Controller : CrudApiController<TABLE8007Dto, CreateTABLE8007Dto, UpdateTABLE8007Dto, int>
{
    public TABLE8007Controller(ITABLE8007Service service) : base(service, dto => dto.NAFECBASADI) { }
}
