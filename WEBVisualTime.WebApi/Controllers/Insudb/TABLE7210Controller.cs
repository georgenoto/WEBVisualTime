using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7210;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7210Controller : CrudApiController<TABLE7210Dto, CreateTABLE7210Dto, UpdateTABLE7210Dto, int>
{
    public TABLE7210Controller(ITABLE7210Service service) : base(service, dto => dto.NDEPRECIATION) { }
}
