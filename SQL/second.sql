select avg(vl.durata)
from voli vl 
inner join viaggi vg on vg.numerovolo = ar.codice
where vl.apartenza = "FRA" 
    and ar.aarrivo in 
        (select codice from aeroporti where nazione = 'USA')
    and vg.matricola in  
        (select matricola 
         from aerei ae
         where ae.matricola = vg.matricola 
          and modello in 
          (select modello
           from aerei int_aerei
           where int_aerei.matricola = ae.matricola
           group by modello
           having count(*) > 10)
       )
