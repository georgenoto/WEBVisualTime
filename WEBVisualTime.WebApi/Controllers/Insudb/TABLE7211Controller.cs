using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7211;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7211Controller : CrudApiController<TABLE7211Dto, CreateTABLE7211Dto, UpdateTABLE7211Dto, int>
{
    public TABLE7211Controller(ITABLE7211Service service) : base(service, dto => dto.NEQUIPMENT_TYPE) { }
}
