ALTER TABLE tbVendors
ADD CONSTRAINT FK_idDevice
FOREIGN KEY (idPlant) REFERENCES tbPlants(idPlants);




