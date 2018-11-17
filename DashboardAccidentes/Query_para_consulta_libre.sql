--San Jose
SELECT rol.rol, COUNT(*) AS accidentes
FROM (ACCIDENTE ac INNER JOIN 
		(AFECTADO af INNER JOIN ROLAFECTADO rol ON af.ID_Rol = rol.ID_Rol) 
	 ON ac.ID_Afectado = af.ID_Afectado) INNER JOIN
		(LOCALIZACION l INNER JOIN PROVINCIA p ON l.ID_Provincia = p.ID_Provincia)
	 ON ac.ID_Localizacion = l.ID_Localizacion
WHERE p.nombre_provincia = 'San José' AND ac.annio = 2014
GROUP BY rol.rol;