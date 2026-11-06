using WEBVisualTime.Servicios.Insudb.DTOs.TABLE127;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE127Controller : CrudApiController<TABLE127Dto, CreateTABLE127Dto, UpdateTABLE127Dto, int>
{
    public TABLE127Controller(ITABLE127Service service) : base(service, dto => dto.NTYPE_RESERVE) { }
}
