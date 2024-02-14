-- Modifica della tabella in modo tale che ciascuna delle 3 sale abbia solo 120 posti
ALTER TABLE Entries
ADD CONSTRAINT SalaLimitCheck 
CHECK (
    Sala = 1 AND (SELECT COUNT(*) FROM Cinema WHERE Sala = 1) <= 120
    AND
    Sala = 2 AND (SELECT COUNT(*) FROM Cinema WHERE Sala = 2) <= 120
    AND
    Sala = 3 AND (SELECT COUNT(*) FROM Cinema WHERE Sala = 3) <= 120
);