using WEBVisualTime.Servicios.Insudb.DTOs.TABLE141;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE141Controller : CrudApiController<TABLE141Dto, CreateTABLE141Dto, UpdateTABLE141Dto, int>
{
    public TABLE141Controller(ITABLE141Service service) : base(service, dto => dto.NEVALSTAT) { }
}
