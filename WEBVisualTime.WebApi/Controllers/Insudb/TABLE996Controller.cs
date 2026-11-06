using WEBVisualTime.Servicios.Insudb.DTOs.TABLE996;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE996Controller : CrudApiController<TABLE996Dto, CreateTABLE996Dto, UpdateTABLE996Dto, int>
{
    public TABLE996Controller(ITABLE996Service service) : base(service, dto => dto.NSECUR_CIA) { }
}
