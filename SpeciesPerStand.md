## Sql Code ##

```
Select sum(distinct(species)), d.Stand_id
from overstory o, survey s,  Transect t,  Stand d
where o.Survey_id = s.Id
and   s.Transect_id   = t.Stand_id
and   t.stand_id = d.stand_id
group by d.stand_id
```