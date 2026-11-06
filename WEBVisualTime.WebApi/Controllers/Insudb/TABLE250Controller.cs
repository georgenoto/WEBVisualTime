using WEBVisualTime.Servicios.Insudb.DTOs.TABLE250;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE250Controller : CrudApiController<TABLE250Dto, CreateTABLE250Dto, UpdateTABLE250Dto, int>
{
    public TABLE250Controller(ITABLE250Service service) : base(service, dto => dto.NFRECUENCY) { }
}
