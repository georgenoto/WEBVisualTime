using WEBVisualTime.Servicios.Insudb.DTOs.TABLE697;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE697Controller : CrudApiController<TABLE697Dto, CreateTABLE697Dto, UpdateTABLE697Dto, int>
{
    public TABLE697Controller(ITABLE697Service service) : base(service, dto => dto.NSHEET) { }
}
