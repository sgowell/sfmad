## SQL Code ##

```
Select sum(distinct(species)), i.id
from overstory o, survey s,  Transect t,  Stand d,  site i
where o.Survey_id = s.Id
and   s.Transect_id   = t.Stand_id
and   t.stand_id = d.stand_id
and   d.site_id = i.site_id
group by site_id
```