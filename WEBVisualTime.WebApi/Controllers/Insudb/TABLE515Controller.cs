using WEBVisualTime.Servicios.Insudb.DTOs.TABLE515;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE515Controller : CrudApiController<TABLE515Dto, CreateTABLE515Dto, UpdateTABLE515Dto, long>
{
    public TABLE515Controller(ITABLE515Service service) : base(service, dto => dto.NCODIGINT) { }
}
