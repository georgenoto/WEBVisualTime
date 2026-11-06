using WEBVisualTime.Servicios.Insudb.DTOs.TABLE140;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE140Controller : CrudApiController<TABLE140Dto, CreateTABLE140Dto, UpdateTABLE140Dto, int>
{
    public TABLE140Controller(ITABLE140Service service) : base(service, dto => dto.NOPER_TYPE) { }
}
