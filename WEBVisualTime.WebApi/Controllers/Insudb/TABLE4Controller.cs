using WEBVisualTime.Servicios.Insudb.DTOs.TABLE4;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE4Controller : CrudApiController<TABLE4Dto, CreateTABLE4Dto, UpdateTABLE4Dto, int>
{
    public TABLE4Controller(ITABLE4Service service) : base(service, dto => dto.NBILL_ITEM) { }
}
