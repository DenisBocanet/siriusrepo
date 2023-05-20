CREATE DATABASE DBAntiGicu
ON PRIMARY
( NAME = N'DBAntiGicu', FILENAME = N'C:\Users\Utente\Desktop\database\DBAntiGicu.mdf' )
LOG ON
( NAME = N'DBAntiGicu_log', FILENAME = N'C:\Users\Utente\Desktop\database\DBAntiGicu.ldf' )


CREATE TABLE TBVendors (
 idVenditori INT NOT NULL,
 txVendors VARCHAR(50) NULL,
 txDowntimeClass VARCHAR(50) NOT NULL,
 PRIMARY KEY(idVenditori)
) 
  SELECT * FROM tbVendors



 


CREATE TABLE TBPlants (
 idPlant INT NOT NULL,
 txPlants VARCHAR(50) NOT NULL,
 txUp VARCHAR(50) NOT NULL,
 txEcName  VARCHAR(50) NOT NULL,
 txSse  VARCHAR(50) NOT NULL,
 txSubSystem  VARCHAR(50) NOT NULL,
 idVenditori INT NOT NULL,
  PRIMARY KEY(idPlant),
  FOREIGN KEY (idVenditori) REFERENCES TBVendors (idVenditori)
) 

  SELECT * FROM TBPlants


CREATE TABLE TBDevices (
 idDevice INT NOT NULL,
 txName VARCHAR(50) NOT NULL,
 nmAltitude INT NULL,
 nmLatitude INT NULL,
 nmLongitude INT NULL,
 nmSerial INT NULL,
 nmYear SMALLINT NOT NULL,
 txModel VARCHAR(50) NOT NULL,
 txTypeSection VARCHAR(50) NOT NULL,
 txNote VARCHAR(100) NOT NULL,
 idPlant INT NOT NULL,

 PRIMARY KEY(idDevice),
 FOREIGN KEY(idPlant) REFERENCES TBPlants (idPlant)
) 

  SELECT * FROM TBDevices


CREATE TABLE TBMeasures (
 idMeasure INT NOT NULL,
 dtDate SMALLDATETIME NOT NULL,
 nmActivePower FLOAT NULL,
 nmAmbientTemp FLOAT NULL,
 nmControllerHubTemp FLOAT NULL,
 nmControllerTopTemp FLOAT NULL,
 nmFrequency FLOAT NOT NULL,
 nmGeneratorSpeed FLOAT NOT NULL,
 nmRotorSpeed FLOAT NOT NULL,
 nmWindSpeed FLOAT NOT NULL,
 nmPressure FLOAT NOT NULL,
 nmNacelleDir FLOAT NOT NULL,
 nmNacelleTemp FLOAT NOT NULL,
 nmProduciblePower INT NOT NULL,
 nmProduciblePowerVestas INT NOT NULL,
 idDevice INT NOT NULL,
 PRIMARY KEY( idMeasure),
 FOREIGN KEY(idDevice) REFERENCES TBDevices(idDevice)
 
) 

 SELECT * FROM TBMeasures
 

 Drop Table TBVendors;

 Use Master
EXEC sp_detach_db 'DBAntigicu', 'true'; 











Use Master
EXEC sp_detach_db 'DBAntigicu', 'true';


ALTER TABLE tbDevices
ADD idPlant int null;

ALTER TABLE tbMeasure
ADD idPlant int null;
