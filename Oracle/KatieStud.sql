INSERT INTO Members (Member_ID,Surname,Forename,House_NO,Street,Town,County,Phone,Email,Status)
values (1,'Smith','Joe',12,'Vally Street','nashvile','Cork',0214567,'JoeSmith@gmail.com','N');

INSERT INTO Members (Member_ID,Surname,Forename,House_NO,Street,Town,County,Phone,Email,Status)
values (2,'bloggs','Joe',13,'Hilly Street','Camp','Kerry',066785463,'JoeBloggs@gmail.com','N');

Commit;

SELECT Start_Date, Start_Date + (duration*7) AS END
FROM Activities
WHERE Start_Date >= Sysdate OR
Start_Date + (duration*7) >= sysdate;

Select * From Registration Where Member_Id=1 AND Activity_No = 1