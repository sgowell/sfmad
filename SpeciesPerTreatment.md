## SQL Code ##

```
Select sum(distinct(species)), d.Treatment
from overstory o, survey s,  Transect t,  Stand d
where o.Survey_id = s.Id
and   s.Transect_id   = t.Stand_id
and   t.stand_id = d.stand_id
group by d.Treatment
```