using WEBVisualTime.Servicios.Insudb.DTOs.TABLE693;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE693Controller : CrudApiController<TABLE693Dto, CreateTABLE693Dto, UpdateTABLE693Dto, int>
{
    public TABLE693Controller(ITABLE693Service service) : base(service, dto => dto.NPRERECEIPT) { }
}
