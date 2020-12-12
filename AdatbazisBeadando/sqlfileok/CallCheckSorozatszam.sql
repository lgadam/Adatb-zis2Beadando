set serveroutput on;
declare 
    v_call_sorozatszam int;
    v_sorozatszam laptopok.sorozatszam%type := 'RGX23321FA';
begin
v_call_sorozatszam := sf_check_sorozatszam(v_sorozatszam);
    
    IF v_call_sorozatszam = 1 THEN
        DBMS_OUTPUT.PUT_LINE('Az alábbi sorozatszam helyes: '||v_sorozatszam);
    ELSE 
        DBMS_OUTPUT.PUT_LINE('Az alábbi sorozatszam helytelen: '||v_sorozatszam);    
    END IF;
END;