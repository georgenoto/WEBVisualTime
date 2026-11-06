using WEBVisualTime.Servicios.Insudb.DTOs.TABLE216;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE216Controller : CrudApiController<TABLE216Dto, CreateTABLE216Dto, UpdateTABLE216Dto, long>
{
    public TABLE216Controller(ITABLE216Service service) : base(service, dto => dto.NRECOVER_TYP) { }
}
