using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1014;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE1014Controller : CrudApiController<TABLE1014Dto, CreateTABLE1014Dto, UpdateTABLE1014Dto, int>
{
    public TABLE1014Controller(ITABLE1014Service service) : base(service, dto => dto.NKEYNUM) { }
}
