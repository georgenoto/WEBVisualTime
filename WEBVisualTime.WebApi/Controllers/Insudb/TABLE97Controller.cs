using WEBVisualTime.Servicios.Insudb.DTOs.TABLE97;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE97Controller : CrudApiController<TABLE97Dto, CreateTABLE97Dto, UpdateTABLE97Dto, int>
{
    public TABLE97Controller(ITABLE97Service service) : base(service, dto => dto.NTYPE_PER) { }
}
