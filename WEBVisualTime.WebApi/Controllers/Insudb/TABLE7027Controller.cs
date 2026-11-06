using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7027;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7027Controller : CrudApiController<TABLE7027Dto, CreateTABLE7027Dto, UpdateTABLE7027Dto, int>
{
    public TABLE7027Controller(ITABLE7027Service service) : base(service, dto => dto.NTYPEPROV) { }
}
