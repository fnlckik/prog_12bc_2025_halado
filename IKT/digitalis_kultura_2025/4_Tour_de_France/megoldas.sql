-- 2start
SELECT ev, start, orszag
FROM tour
WHERE orszag IS NOT NULL;

-- 3feladok
SELECT ev, tav, feladok / indulok AS gyenguszok
FROM tour
ORDER BY feladok / indulok DESC;

-- 4utolso
SELECT TOP 1 tour.ev, gyoztesek.vnev, tour.csapat
FROM tour INNER JOIN gyoztesek ON tour.gyoztesid = gyoztesek.vazon
WHERE vorszag = "FRA"
ORDER BY tour.ev DESC;

-- 5tobbszor
-- WHERE: rekordra feltétel
-- HAVING: csoportra feltétel
SELECT gyoztesek.vnev, COUNT(*) AS `győzelmek száma`
FROM tour INNER JOIN gyoztesek ON tour.gyoztesid = gyoztesek.vazon
GROUP BY gyoztesek.vazon, gyoztesek.vnev
HAVING COUNT(*) > 1
ORDER BY COUNT(*) DESC;