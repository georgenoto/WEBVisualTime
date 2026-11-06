using WEBVisualTime.Servicios.Insudb.DTOs.TABLE360;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE360Controller : CrudApiController<TABLE360Dto, CreateTABLE360Dto, UpdateTABLE360Dto, int>
{
    public TABLE360Controller(ITABLE360Service service) : base(service, dto => dto.NTYPEATTRIBUT) { }
}
