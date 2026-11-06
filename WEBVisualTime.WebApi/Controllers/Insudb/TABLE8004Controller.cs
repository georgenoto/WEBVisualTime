using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8004;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8004Controller : CrudApiController<TABLE8004Dto, CreateTABLE8004Dto, UpdateTABLE8004Dto, int>
{
    public TABLE8004Controller(ITABLE8004Service service) : base(service, dto => dto.NTYPEPOP) { }
}
