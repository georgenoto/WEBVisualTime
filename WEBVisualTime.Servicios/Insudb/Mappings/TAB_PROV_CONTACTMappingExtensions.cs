using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_PROV_CONTACT;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_PROV_CONTACTMappingExtensions
{
    public static TAB_PROV_CONTACTDto ToDto(this TAB_PROV_CONTACT entity)
    {
        if (entity == null) return null!;
        return new TAB_PROV_CONTACTDto
        {
            NPROVIDER = entity.NPROVIDER,
            TAB_PROVIDERSSTATREGT = entity.TAB_PROVIDER?.SSTATREGT,
            NSEQ = entity.NSEQ,
            DEFFECDATE = entity.DEFFECDATE,
            DNULLDATE = entity.DNULLDATE,
            NPOSITION = entity.NPOSITION,
            TABLE283SDESCRIPT = entity.TABLE283?.SDESCRIPT,
            SNAME_CONTACT = entity.SNAME_CONTACT,
            SE_MAIL = entity.SE_MAIL,
            SPHONE_CONTACT = entity.SPHONE_CONTACT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
        };
    }

    public static TAB_PROV_CONTACT ToEntity(this CreateTAB_PROV_CONTACTDto dto)
    {
        if (dto == null) return null!;
        return new TAB_PROV_CONTACT
        {
            DNULLDATE = dto.DNULLDATE,
            NPOSITION = dto.NPOSITION,
            SNAME_CONTACT = dto.SNAME_CONTACT,
            SE_MAIL = dto.SE_MAIL,
            SPHONE_CONTACT = dto.SPHONE_CONTACT,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
        };
    }

    public static void UpdateEntity(this TAB_PROV_CONTACT entity, UpdateTAB_PROV_CONTACTDto dto)
    {
        if (entity == null || dto == null) return;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NPOSITION = dto.NPOSITION;
        entity.SNAME_CONTACT = dto.SNAME_CONTACT;
        entity.SE_MAIL = dto.SE_MAIL;
        entity.SPHONE_CONTACT = dto.SPHONE_CONTACT;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
    }
}
