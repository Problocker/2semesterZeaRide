select SamkorselID, fraDestination, tilDestination, bemaerkninger, dato, tid, passager from Samkorsel
INNER JOIN Samkorsler ON Samkorsel.samkorselID = Samkorsler.FK_samkorselID
INNER JOIN Bruger ON Samkorsler.FK_brugerID = Bruger.brugerID
WHERE samkorselID = 1