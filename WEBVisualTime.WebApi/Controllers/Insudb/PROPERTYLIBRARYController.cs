using WEBVisualTime.Servicios.Insudb.DTOs.PROPERTYLIBRARY;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class PROPERTYLIBRARYController : CrudApiController<PROPERTYLIBRARYDto, CreatePROPERTYLIBRARYDto, UpdatePROPERTYLIBRARYDto, int>
{
    public PROPERTYLIBRARYController(IPROPERTYLIBRARYService service) : base(service, dto => dto.NIDPROPERTY) { }
}
