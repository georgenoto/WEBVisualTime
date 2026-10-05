using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.SECUR_SCHE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class SECUR_SCHEMappingExtensions
{
    public static SECUR_SCHEDto ToDto(this SECUR_SCHE entity)
    {
        if (entity == null) return null!;
        return new SECUR_SCHEDto
        {
            SSCHE_CODE = entity.SSCHE_CODE,
            NACCESOF = entity.NACCESOF,
            DCOMPDATE = entity.DCOMPDATE,
            DDATE_FROM = entity.DDATE_FROM,
            DDATE_TO = entity.DDATE_TO,
            NIND_CURREN = entity.NIND_CURREN,
            NIND_LIMITS = entity.NIND_LIMITS,
            SLONGDESC = entity.SLONGDESC,
            NSECURLEV = entity.NSECURLEV,
            SSHORTDES = entity.SSHORTDES,
            SSTATREGT = entity.SSTATREGT,
            STIME1_FROM = entity.STIME1_FROM,
            STIME1_TO = entity.STIME1_TO,
            STIME2_FROM = entity.STIME2_FROM,
            STIME2_TO = entity.STIME2_TO,
            STIMEQ1_FRO = entity.STIMEQ1_FRO,
            STIMEQ1_TO = entity.STIMEQ1_TO,
            STIMEQ2_FRO = entity.STIMEQ2_FRO,
            STIMEQ2_TO = entity.STIMEQ2_TO,
            SUSEQUERY = entity.SUSEQUERY,
            NIND_CONCE = entity.NIND_CONCE,
            NUSERCODE = entity.NUSERCODE,
            NDURATION = entity.NDURATION,
            NDAYSADV = entity.NDAYSADV,
            SENCRYPTED = entity.SENCRYPTED,
        };
    }

    public static SECUR_SCHE ToEntity(this CreateSECUR_SCHEDto dto)
    {
        if (dto == null) return null!;
        return new SECUR_SCHE
        {
            NACCESOF = dto.NACCESOF,
            DCOMPDATE = dto.DCOMPDATE,
            DDATE_FROM = dto.DDATE_FROM,
            DDATE_TO = dto.DDATE_TO,
            NIND_CURREN = dto.NIND_CURREN,
            NIND_LIMITS = dto.NIND_LIMITS,
            SLONGDESC = dto.SLONGDESC,
            NSECURLEV = dto.NSECURLEV,
            SSHORTDES = dto.SSHORTDES,
            SSTATREGT = dto.SSTATREGT,
            STIME1_FROM = dto.STIME1_FROM,
            STIME1_TO = dto.STIME1_TO,
            STIME2_FROM = dto.STIME2_FROM,
            STIME2_TO = dto.STIME2_TO,
            STIMEQ1_FRO = dto.STIMEQ1_FRO,
            STIMEQ1_TO = dto.STIMEQ1_TO,
            STIMEQ2_FRO = dto.STIMEQ2_FRO,
            STIMEQ2_TO = dto.STIMEQ2_TO,
            SUSEQUERY = dto.SUSEQUERY,
            NIND_CONCE = dto.NIND_CONCE,
            NUSERCODE = dto.NUSERCODE,
            NDURATION = dto.NDURATION,
            NDAYSADV = dto.NDAYSADV,
            SENCRYPTED = dto.SENCRYPTED,
        };
    }

    public static void UpdateEntity(this SECUR_SCHE entity, UpdateSECUR_SCHEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.NACCESOF = dto.NACCESOF;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.DDATE_FROM = dto.DDATE_FROM;
        entity.DDATE_TO = dto.DDATE_TO;
        entity.NIND_CURREN = dto.NIND_CURREN;
        entity.NIND_LIMITS = dto.NIND_LIMITS;
        entity.SLONGDESC = dto.SLONGDESC;
        entity.NSECURLEV = dto.NSECURLEV;
        entity.SSHORTDES = dto.SSHORTDES;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.STIME1_FROM = dto.STIME1_FROM;
        entity.STIME1_TO = dto.STIME1_TO;
        entity.STIME2_FROM = dto.STIME2_FROM;
        entity.STIME2_TO = dto.STIME2_TO;
        entity.STIMEQ1_FRO = dto.STIMEQ1_FRO;
        entity.STIMEQ1_TO = dto.STIMEQ1_TO;
        entity.STIMEQ2_FRO = dto.STIMEQ2_FRO;
        entity.STIMEQ2_TO = dto.STIMEQ2_TO;
        entity.SUSEQUERY = dto.SUSEQUERY;
        entity.NIND_CONCE = dto.NIND_CONCE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NDURATION = dto.NDURATION;
        entity.NDAYSADV = dto.NDAYSADV;
        entity.SENCRYPTED = dto.SENCRYPTED;
    }
}
