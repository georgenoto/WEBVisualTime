using WEBVisualTime.Servicios.Insudb.DTOs.TABLE288;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE288Controller : CrudApiController<TABLE288Dto, CreateTABLE288Dto, UpdateTABLE288Dto, int>
{
    public TABLE288Controller(ITABLE288Service service) : base(service, dto => dto.NTYPE_DOC) { }
}
