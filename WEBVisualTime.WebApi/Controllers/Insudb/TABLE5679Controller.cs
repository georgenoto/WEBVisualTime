using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5679;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5679Controller : CrudApiController<TABLE5679Dto, CreateTABLE5679Dto, UpdateTABLE5679Dto, int>
{
    public TABLE5679Controller(ITABLE5679Service service) : base(service, dto => dto.NCAUSE) { }
}
