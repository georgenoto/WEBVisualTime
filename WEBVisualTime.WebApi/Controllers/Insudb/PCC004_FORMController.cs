using WEBVisualTime.Servicios.Insudb.DTOs.PCC004_FORM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class PCC004_FORMController : CrudApiController<PCC004_FORMDto, CreatePCC004_FORMDto, UpdatePCC004_FORMDto, long>
{
    public PCC004_FORMController(IPCC004_FORMService service) : base(service, dto => dto.NNUM_PCC004) { }
}
