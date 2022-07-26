select avg(vl.durata)
from voli vl 
left join viaggi vg on vg.numerovolo = ar.codice
where vl.apartenza = "FRA" 
    and ar.aarrivo in 
        (select codice from aeroporti where nazione = 'USA')
    and (select count(vid) 
            from viaggi vg
            left join aerei ae on vg.matricola = ae.matricola  
            ) > 10

