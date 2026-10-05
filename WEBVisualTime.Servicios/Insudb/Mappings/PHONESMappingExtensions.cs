using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PHONES;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PHONESMappingExtensions
{
    public static PHONESDto ToDto(this PHONES entity)
    {
        if (entity == null) return null!;
        return new PHONESDto
        {
            NRECOWNER = entity.NRECOWNER,
            SKEYADDRESS = entity.SKEYADDRESS,
            NKEYPHONES = entity.NKEYPHONES,
            DEFFECDATE = entity.DEFFECDATE,
            NBESTTIMETOCALL = entity.NBESTTIMETOCALL,
            TABLE8060SSTATREGT = entity.TABLE8060?.SSTATREGT,
            NAREA_CODE = entity.NAREA_CODE,
            SPHONE = entity.SPHONE,
            NORDER = entity.NORDER,
            NEXTENS1 = entity.NEXTENS1,
            NEXTENS2 = entity.NEXTENS2,
            NPHONE_TYPE = entity.NPHONE_TYPE,
            TABLE564SDESCRIPT = entity.TABLE564?.SDESCRIPT,
            NUSERCODE = entity.NUSERCODE,
            DCOMPDATE = entity.DCOMPDATE,
            DNULLDATE = entity.DNULLDATE,
            NCOUNTRY_CODE = entity.NCOUNTRY_CODE,
            SASSOCADDR = entity.SASSOCADDR,
            NPHONECLAS = entity.NPHONECLAS,
        };
    }

    public static PHONES ToEntity(this CreatePHONESDto dto)
    {
        if (dto == null) return null!;
        return new PHONES
        {
            NBESTTIMETOCALL = dto.NBESTTIMETOCALL,
            NAREA_CODE = dto.NAREA_CODE,
            SPHONE = dto.SPHONE,
            NORDER = dto.NORDER,
            NEXTENS1 = dto.NEXTENS1,
            NEXTENS2 = dto.NEXTENS2,
            NPHONE_TYPE = dto.NPHONE_TYPE,
            NUSERCODE = dto.NUSERCODE,
            DCOMPDATE = dto.DCOMPDATE,
            DNULLDATE = dto.DNULLDATE,
            NCOUNTRY_CODE = dto.NCOUNTRY_CODE,
            SASSOCADDR = dto.SASSOCADDR,
            NPHONECLAS = dto.NPHONECLAS,
        };
    }

    public static void UpdateEntity(this PHONES entity, UpdatePHONESDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NBESTTIMETOCALL = dto.NBESTTIMETOCALL;
        entity.NAREA_CODE = dto.NAREA_CODE;
        entity.SPHONE = dto.SPHONE;
        entity.NORDER = dto.NORDER;
        entity.NEXTENS1 = dto.NEXTENS1;
        entity.NEXTENS2 = dto.NEXTENS2;
        entity.NPHONE_TYPE = dto.NPHONE_TYPE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DNULLDATE = dto.DNULLDATE;
        entity.NCOUNTRY_CODE = dto.NCOUNTRY_CODE;
        entity.SASSOCADDR = dto.SASSOCADDR;
        entity.NPHONECLAS = dto.NPHONECLAS;
    }
}
