using WEBVisualTime.Servicios.Insudb.DTOs.ADDRESS_CONFIG;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class ADDRESS_CONFIGController : CrudApiController<ADDRESS_CONFIGDto, CreateADDRESS_CONFIGDto, UpdateADDRESS_CONFIGDto, int>
{
    public ADDRESS_CONFIGController(IADDRESS_CONFIGService service) : base(service, dto => dto.COUNTRY) { }
}
