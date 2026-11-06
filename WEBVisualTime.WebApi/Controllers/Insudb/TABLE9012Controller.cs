using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9012;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9012Controller : CrudApiController<TABLE9012Dto, CreateTABLE9012Dto, UpdateTABLE9012Dto, int>
{
    public TABLE9012Controller(ITABLE9012Service service) : base(service, dto => dto.NTYPECIA) { }
}
