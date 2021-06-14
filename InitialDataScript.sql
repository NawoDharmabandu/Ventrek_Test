  insert into [NebulaDB].[dbo].[STATUS]([STATUS_ID],[STATUS_NAME])
  values(0,'Inactive'),(1,'Active'),(2,'Unfinished'),(3,'Completed');
  
    
   insert into [NebulaDB].[dbo].[USER]([USER_ID],[USER_PASSWORD],[USER_TITLE],[USER_FNAME],[USER_LNAME],[USER_CONTACT],[USER_EMAIL],[USER_STATUS],
  [CREATED_BY],[CREATED_DATE],[MODERATED_BY],[MODERATED_DATE],[DEACTIVATED_BY],[DEATIVATED_DATE])
values('0001','pwd0001','Ms','Nawoda','Dharmabandu','0710000000','ptnawoda@gmail.com',1,
'0001','2021-06-11',null,'2021-06-11',null,'2021-06-11'),
('0002','pwd0002','Ms','Isha','Amerasinghe','0710000001','ishah@gmail.com',1,
'0001','2021-06-11',null,'2021-06-11',null,'2021-06-11');