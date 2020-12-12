drop table laptopok;
create table laptopok
(
    id int not null,
    sorozatszam varchar2(250) not null,
    tipus varchar2(250) not null,
    gyarto_id int not null,
    processzor varchar2(250) not null,
    videokartya varchar2(250) not null,
    ram int not null,
    kepernyomeret number(2,1) not null,
    processzororajel int not null
    
    constraint pk_laptopok primary key(id),
    constraint uq_laptopok_sorozatszam unique(sorozatszam),
    constraint ch_laptopok_kepernyomeret check(kepernyomeret in (11,14,15.6,17.3)),
    constraint fk_gyartok foreign key(gyarto_id) references gyartok(id)
);