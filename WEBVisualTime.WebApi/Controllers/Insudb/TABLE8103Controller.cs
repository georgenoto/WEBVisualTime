using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8103;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8103Controller : CrudApiController<TABLE8103Dto, CreateTABLE8103Dto, UpdateTABLE8103Dto, int>
{
    public TABLE8103Controller(ITABLE8103Service service) : base(service, dto => dto.NWAIT_CODE) { }
}
