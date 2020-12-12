create or replace procedure spInsert_laptopok(
    p_id in laptopok.id%type,
    p_sorozatszam in laptopok.sorozatszam%type,
    p_tipus in laptopok.tipus%type,
    p_gyarto in gyartok.nev%type,
    p_processzor in laptopok.processzor%type,
    p_videokartya in laptopok.videokartya%type,
    p_ram in laptopok.ram%type,
    p_kepernyomeret in laptopok.kepernyomeret%type,
    p_processzororajel in laptopok.processzororajel%type,
    p_out_rowcnt out int
)
authid definer
as
    v_check_rendszam int;
    v_gyarto_id int;
begin
    p_out_rowcnt := 0;
    --nincs AI
    v_gyarto_id := sf_getGyartoId(p_gyarto);
    if v_gyarto_id is null then
        sp_insertGyartok(p_gyarto);
        v_gyarto_id := sf_getGyartoId(p_gyarto);
    end if;
    --Ellenőrzöm a rendszám helyességét
    v_check_rendszam := sf_check_rendszam(p_rendszam);
    if v_check_rendszam = 1 then
        insert into autok
            (rendszam, alvazszam, gyarto_id, tipus, uzemanyag, evjarat, gyorsulas, meghajtas)
        values
            (p_rendszam, p_alvazszam, v_gyarto_id, p_tipus, p_uzemanyag, p_evjarat, p_gyorsulas, p_meghajtas);
        p_out_rowcnt := SQL%rowcount;
        commit;
    end if;
end spInsert_autok;