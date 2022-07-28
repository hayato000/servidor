--Se il fatto che lo stato del viaggio non sia realmente da considerare
select count(*)
from voli vl 
where vl.apartenza = "VCE" 
    
--Considerando anche il viaggio    
select count(*)
from voli vl 
inner join viaggi vg on vl.numero = vl.numerovolo
where vl.apartenza = "VCE" 
