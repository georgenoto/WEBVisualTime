using WEBVisualTime.Servicios.Insudb.DTOs.ADDRESS_CONFIG;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ADDRESS_CONFIGController : CatalogController<ADDRESS_CONFIGDto, CreateADDRESS_CONFIGDto, UpdateADDRESS_CONFIGDto, int>
{
    public ADDRESS_CONFIGController(IADDRESS_CONFIGService service)
        : base(service, "ADDRESS_CONFIG", "COUNTRY", new[] { "COUNTRY", "ADDRESS_SETTINGS", "PHONE_SETTINGS", "NUSERCODE", "UPDATEDATE" }) { }
}
