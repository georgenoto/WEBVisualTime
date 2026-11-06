using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8602;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8602Controller : CrudApiController<TABLE8602Dto, CreateTABLE8602Dto, UpdateTABLE8602Dto, string>
{
    public TABLE8602Controller(ITABLE8602Service service) : base(service, dto => dto.SGROUP_ILL) { }
}
