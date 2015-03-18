## SQL Code ##

```
Select count(sn.id)/(.03707*count(o.id)) "Acre",  count(sn.id)/(.0015*count(o.id)) "Hectare",  d.Treatment
from Snag sn, overstory o, survey s,  Transect t,  Stand d,  site i
where sn.Overstory_id = o.id
and   o.Survey_id = s.Id
and   s.Transect_id   = t.Stand_id
and   t.stand_id = d.stand_id
and   d.site_id = i.site_id
and   sn.DiameterBreastHeight*2.54 > 10
group by d.Treatment 
```