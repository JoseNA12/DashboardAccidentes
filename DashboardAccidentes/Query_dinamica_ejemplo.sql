SELECT p.nombre_provincia, l.latitud, l.longitud, COUNT(*) 
FROM 
(
ACCIDENTE ac INNER JOIN 
LOCALIZACION l ON ac.ID_Localizacion = l.ID_Localizacion INNER JOIN
PROVINCIA p ON l.ID_Provincia = p.ID_Provincia INNER JOIN
CANTON c ON l.ID_Canton = c.ID_Canton INNER JOIN 
DISTRITO d ON l.ID_Distrito = d.ID_Distrito
) 
INNER JOIN
(
AFECTADO af INNER JOIN GENERO g ON af.ID_Sexo = g.ID_Sexo INNER JOIN
LESION le ON af.ID_Lesion = le.ID_Lesion INNER JOIN
ROLAFECTADO rol ON af.ID_Rol = rol.ID_Rol
) 
ON ac.ID_Afectado = af.ID_Afectado

WHERE
--Condiciones de rango de annios
(
ac.annio >= 2012 AND ac.annio <= 2013
)
AND
--Condiciones de localizaciones
(
(p.nombre_provincia = 'San José' OR p.nombre_provincia = 'Puntarenas') --AND 
--(c.nombre_canton = 'Curridabat' OR c.nombre_canton = 'Desamparados') --AND 
--(d.nombre_distrito = 'Curridabat' OR d.nombre_distrito = 'Tirrases' OR d.nombre_distrito = 'Granadilla')
)
AND
--Condiciones de indicadores
(g.sexo = 'Hombre' AND rol.rol = 'Conductor')

GROUP BY p.nombre_provincia, l.latitud, l.longitud;