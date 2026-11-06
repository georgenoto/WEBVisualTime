using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7046;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7046Controller : CrudApiController<TABLE7046Dto, CreateTABLE7046Dto, UpdateTABLE7046Dto, int>
{
    public TABLE7046Controller(ITABLE7046Service service) : base(service, dto => dto.NFAMILY) { }
}
