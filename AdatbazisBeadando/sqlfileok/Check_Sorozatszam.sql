create or replace function sf_check_sorozatszam
(
    p_sorozatszam  in laptopok.sorozatszam%type
)
return int
deterministic
as
    v_sorozatszam_char char(1);
    v_i int;
begin
    if p_sorozatszam is null then
        return 0;
    end if;

    if length(trim(p_sorozatszam)) > 10 then
        return 0;
    end if;
    while v_i <= length(trim(p_sorozatszam)) loop
            v_sorozatszam_char := substr(p_sorozatszam, v_i, 1);
            if not (ascii('A') <= ascii(v_sorozatszam_char) and ascii(v_sorozatszam_char) <= ascii('Z')) then
                return 0;            
            end if;
            v_i := v_i + 1;
    end loop;

    return 1;
end sf_check_sorozatszam;