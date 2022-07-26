select ae.marca
from aerei ae
inner join viaggi vg on vg.aereo = ae.matricola
inner join voli vl on vg.numerovolo = vl.codice
where 
    vl.apartenza not in (select codice from aeroporti where nazione = 'USA')
    AND
    vl.aarrivo not in (select codice from aeroporti where nazione = 'USA')
     

