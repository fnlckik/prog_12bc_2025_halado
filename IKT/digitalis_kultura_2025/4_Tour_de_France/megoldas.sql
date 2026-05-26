-- 2start
SELECT ev, start, orszag
FROM tour
WHERE orszag IS NOT NULL;

-- 3feladok
SELECT ev, tav, feladok / indulok AS gyenguszok
FROM tour
ORDER BY feladok / indulok DESC;
