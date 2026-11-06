using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7996;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7996Controller : CrudApiController<TABLE7996Dto, CreateTABLE7996Dto, UpdateTABLE7996Dto, int>
{
    public TABLE7996Controller(ITABLE7996Service service) : base(service, dto => dto.NLOAD_TYPE) { }
}
