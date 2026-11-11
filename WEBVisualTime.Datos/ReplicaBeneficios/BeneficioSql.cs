namespace WEBVisualTime.Datos.ReplicaBeneficios;

public static class BeneficioSql
{
    public const string Target = "INSUDB.MEDBENEFITS_PROD";
    public const string Jobs = "INSUDB.TEMP_VT_BEN_REPLICA";
    public const string Dest = "INSUDB.TEMP_VT_BEN_DESTINO";
    public const string Snapshot = "INSUDB.TEMP_VT_BEN_SNAPSHOT";
    public const string Stage = "INSUDB.TEMP_VT_BEN_STAGE";
    public const string Columns = "NBRANCH,NPRODUCT,NMODULEC,DEFFECDATE,NCOVER,NROLE,NDED_TYPE,NQUANTITY,NAMOUNT_BENE,NPERCEN_HOSPITAL,NPERCEN_AMBULATORY,SCHANALLO,DNULLDATE,DCOMPDATE,NUSERCODE,SCAREN_TYPE,NCAREN_QUANT,NOFFICE_PROD,NAMOUNT_COPAY,NFRANCFIX,NAGESTART,NAGEEND,SSEXCLIEN,NPROVIDER,NATTENSYSTEM,NTYPEEXHAUS,SILLNESS,SCLARIFICACT,NINDPRINT,NBENEFCATEG,NIDMEDBENEF,SBENEFCATEG_CODE,SPRINT_DES,NORDER";
    public static string Cols(string alias) => string.Join(",", Columns.Split(',').Select(c => alias + "." + c));
    public static string Selected => $"SELECT {Cols("t")} FROM {Target} t WHERE t.NBRANCH=:ramo AND t.NPRODUCT=:producto AND t.NMODULEC IN (SELECT NMODULEC FROM {Dest} WHERE ID=:id)";
    public static string Delete => $"DELETE FROM {Target} WHERE NBRANCH=:ramo AND NPRODUCT=:producto AND NMODULEC IN (SELECT NMODULEC FROM {Dest} WHERE ID=:id)";
    public static string Insert(string source, string filter) => $"INSERT INTO {Target}({Columns}) SELECT {Columns} FROM {source} WHERE ID=:id {filter}";
    public static string Difference(string left, string right) => $"SELECT COUNT(*) FROM ({left} MINUS {right})";
    public static string Prepare
    {
        get
        {
            var projection = string.Join(",", Columns.Split(',').Select(col => (col switch
            { "NMODULEC" => "d.NMODULEC", "NUSERCODE" => ":usuario", "DCOMPDATE" => "j.FECHA_COPIA", _ => "b." + col }) + " AS " + col));
            return $"INSERT INTO {Stage}(ID,ITEM_NO,{Columns}) SELECT :id,ITEM_NO,{Columns} FROM (SELECT ((d.ORDEN-1)*j.BASE_FILAS+b.ITEM_NO) ITEM_NO,{projection} FROM {Snapshot} b JOIN {Dest} d ON d.ID=b.ID JOIN {Jobs} j ON j.ID=b.ID WHERE b.ID=:id AND b.TIPO='BASE') WHERE ITEM_NO>:startNo AND ITEM_NO<=:endNo";
        }
    }
}
