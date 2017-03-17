--PoolSYS.sql
-- This Oracle script builds the database for the pool system
--Author: Katie Griffiths
DROP TABLE Registration;
DROP TABLE Members;
DROP TABLE Activities;


CREATE TABLE Members 
(Member_ID numeric NOT NULL,
Surname char(25),
Forename char(35),
House_No numeric,
Street char(25),
Town char(20),
County char(25),
Phone char(14),
Email char(35),
Status char(1) CHECK (Status IN ('A','I','B')),
CONSTRAINT pk_Members PRIMARY KEY(Member_ID));

CREATE TABLE Activities
(Activity_No numeric(4),
Activity_Name char(30),
Description char(75),
Start_Date date,
Duration numeric(2),
Rate decimal(6,2),
No_Of_Spaces numeric(2),
Availability numeric(2),
CONSTRAINT pk_Activities PRIMARY KEY(Activity_No));

CREATE TABLE Registration
(Registration_No numeric(4),
Registration_Date date,
Member_Id numeric(4),
Activity_No numeric(4),
CONSTRAINT pk_Registration PRIMARY KEY(Registration_No),
CONSTRAINT fk_Members FOREIGN KEY (Member_Id) REFERENCES Members(Member_Id),
CONSTRAINT fk_Activities FOREIGN KEY (Activity_No) REFERENCES Activities(Activity_No));


