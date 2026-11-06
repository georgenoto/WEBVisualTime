using WEBVisualTime.Servicios.Insudb.DTOs.TABLE245;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE245Controller : CrudApiController<TABLE245Dto, CreateTABLE245Dto, UpdateTABLE245Dto, long>
{
    public TABLE245Controller(ITABLE245Service service) : base(service, dto => dto.NTYPELOAN) { }
}
