using WEBVisualTime.Servicios.Insudb.DTOs.TABLE642;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE642Controller : CrudApiController<TABLE642Dto, CreateTABLE642Dto, UpdateTABLE642Dto, int>
{
    public TABLE642Controller(ITABLE642Service service) : base(service, dto => dto.NPROV_GROUP) { }
}
