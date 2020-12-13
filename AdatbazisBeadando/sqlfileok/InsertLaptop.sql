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
    v_check_sorozatszam int;
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
    v_check_sorozatszam := sf_check_sorozatszam(p_sorozatszam);
    if v_check_sorozatszam = 1 then
        insert into laptopok
            (id, sorozatszam, tipus, gyarto, processzor, videokartya, ram, kepernyomeret,processzororajel)
        values
            (p_id, p_sorozatszam,p_tipus,v_gyarto_id,p_processzor,p_videokartya,p_ram,p_kepernyomeret,p_processzororajel);
        p_out_rowcnt := SQL%rowcount;
        commit;
    end if;
end spInsert_laptopok;