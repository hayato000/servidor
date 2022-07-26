create table voli
(numero integer,
hpartenza date,
harrivo date,
apartenza char(3),
aarrivo char(3),
durata integer,
primary key (numero)
foreign key (apartenza) references aeroporti on delete no action
foreign key (aarrivo) references aeroporti on delete no action
);

create table aeroporti
(codice char(3),
nome char(50),
citta char(50),
nazione char(50),
primary key (codice)
);

create table viaggi
(vid integer,
stato char(20),
data date,
aereo char(10),
primary key (vid)
foreign key (aereo) references aerei on delete no action
);

create table aerei
(matricola char(10),
modello char(50),
marca char(50),
anno integer,
primary key (matricola)
);