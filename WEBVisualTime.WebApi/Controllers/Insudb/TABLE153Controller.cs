using WEBVisualTime.Servicios.Insudb.DTOs.TABLE153;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE153Controller : CrudApiController<TABLE153Dto, CreateTABLE153Dto, UpdateTABLE153Dto, string>
{
    public TABLE153Controller(ITABLE153Service service) : base(service, dto => dto.SERRORTYP) { }
}
