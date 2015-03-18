# Sql Code #

```
Select count(OI.id)/(.03707*count(o.id)) "Acre",  count(OI.id)/(.0015*count(o.id)) "Hectare" , d.stand_id
from OverstoryItem OI, overstory o, survey s,  Transect t,  Stand d
where OI.Overstory_id = o.id
and   o.Survey_id = s.Id
and   s.Transect_id   = t.Stand_id
and   t.stand_id = d.stand_id
and   d.site_id = i.site_id
group by o.id
```