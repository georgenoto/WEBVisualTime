using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5552;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5552Controller : CrudApiController<TABLE5552Dto, CreateTABLE5552Dto, UpdateTABLE5552Dto, int>
{
    public TABLE5552Controller(ITABLE5552Service service) : base(service, dto => dto.NTYPECAP) { }
}
