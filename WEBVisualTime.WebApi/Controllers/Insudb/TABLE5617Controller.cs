using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5617;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5617Controller : CrudApiController<TABLE5617Dto, CreateTABLE5617Dto, UpdateTABLE5617Dto, int>
{
    public TABLE5617Controller(ITABLE5617Service service) : base(service, dto => dto.NPAYFREQCREDITCARD) { }
}
