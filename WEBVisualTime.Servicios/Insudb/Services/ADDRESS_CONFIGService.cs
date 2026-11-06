using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.ADDRESS_CONFIG;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class ADDRESS_CONFIGService : CrudService<ADDRESS_CONFIG, ADDRESS_CONFIGDto, CreateADDRESS_CONFIGDto, UpdateADDRESS_CONFIGDto, int>, IADDRESS_CONFIGService
{
    public ADDRESS_CONFIGService(IRepository<ADDRESS_CONFIG> repository)
        : base(repository, ADDRESS_CONFIGMappingExtensions.ToDto, ADDRESS_CONFIGMappingExtensions.ToEntity, ADDRESS_CONFIGMappingExtensions.UpdateEntity) { }
}
