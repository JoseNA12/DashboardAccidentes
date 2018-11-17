--Tipo de afectado (Rol)
SELECT rol.rol, ac.annio, COUNT(*) AS accidentes
FROM	ACCIDENTE ac INNER JOIN 
		AFECTADO af ON ac.ID_Afectado = af.ID_Afectado INNER JOIN
		ROLAFECTADO rol ON af.ID_Rol = rol.ID_Rol
GROUP BY rol.rol, ac.annio
ORDER BY rol.rol, ac.annio;

-- Genero
SELECT g.sexo, ac.annio, COUNT(*) AS accidentes
FROM	ACCIDENTE ac INNER JOIN
		AFECTADO af ON ac.ID_Afectado = af.ID_Afectado INNER JOIN
		GENERO g ON af.ID_Sexo = g.ID_Sexo
GROUP BY g.sexo, ac.annio
ORDER BY g.sexo, ac.annio;

-- Tipo de lesion
SELECT l.tipo_lesion, ac.annio, COUNT(*) AS accidentes
FROM	ACCIDENTE ac INNER JOIN
		AFECTADO af ON ac.ID_Afectado = af.ID_Afectado INNER JOIN
		LESION l ON af.ID_Lesion = l.ID_Lesion
GROUP BY l.tipo_lesion, ac.annio
ORDER BY l.tipo_lesion, ac.annio;

-- Edad quinquenal
SELECT af.edad_quinquenal, ac.annio, COUNT(*) AS accidentes
FROM	ACCIDENTE ac INNER JOIN
		AFECTADO af ON ac.ID_Afectado = af.ID_Afectado
GROUP BY af.edad_quinquenal, ac.annio
ORDER BY af.edad_quinquenal, ac.annio;

-- Prueba para sacar valores de un indicador
-- Este mejor se hace con codigo C# despues de sacar la consulta
SELECT dat.rol
FROM(
SELECT rol.rol, ac.annio, COUNT(*) AS accidentes
FROM	ACCIDENTE ac INNER JOIN 
		AFECTADO af ON ac.ID_Afectado = af.ID_Afectado INNER JOIN
		ROLAFECTADO rol ON af.ID_Rol = rol.ID_Rol
GROUP BY rol.rol, ac.annio) as dat
GROUP BY dat.rol;