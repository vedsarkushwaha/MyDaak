insert into u_profile values('ved','kush','19-mar-1992','m','99716200660','vedsar@yahoo.co.in','ved','Who is your first crush ?','me','ghaziabad');
insert into u_profile values('vedu','kush','19-mar-1992','m','99716200660','vedsar@yahoo.co.in','vedu','Who is your first crush ?','me','ghaziabad');
insert into u_profile values('vedsar','kush','19-mar-1992','m','99716200660','vedsar@yahoo.co.in','vedsar','Who is your first crush ?','me','ghaziabad');
insert into u_profile values('test','kush','19-mar-1992','m','99716200660','vedsar@yahoo.co.in','test','Who is your first crush ?','me','ghaziabad');
insert into u_profile values('one','kush','19-mar-1992','m','99716200660','vedsar@yahoo.co.in','one','Who is your first crush ?','me','ghaziabad');
insert into u_profile values('two','kush','19-mar-1992','m','99716200660','vedsar@yahoo.co.in','two','Who is your first crush ?','me','ghaziabad');

update username set password='ved' where user_id='ved';
update username set password='vedu' where user_id='vedu';
update username set password='vedsar' where user_id='vedsar';
update username set password='test' where user_id='test';
update username set password='one' where user_id='one';
update username set password='two' where user_id='two';

insert into messages values(1,'test1','ved_to_vedu','NA',sysdate,sysdate,'read');
insert into messages values(2,'test2','ved_to_one','NA',sysdate,sysdate,'read');
insert into messages values(3,'test3','ved_to_two','NA',sysdate,sysdate,'read');
insert into messages values(4,'test4','ved_to_vedsar','NA',sysdate,sysdate,'read');
insert into messages values(5,'test5','ved_to_test','NA',sysdate,sysdate,'read');
insert into messages values(6,'test6','ved_to_ved','NA',sysdate,sysdate,'read');
insert into messages values(7,'test7','vedsar_to_ved','NA',sysdate,sysdate,'read');
insert into messages values(8,'test8','vedsar_to_vedu','NA',sysdate,sysdate,'read');

insert into mail_exchange values('ved',1,sysdate,sysdate,'vedu');
insert into mail_exchange values('ved',2,sysdate,sysdate,'one');
insert into mail_exchange values('ved',3,sysdate,sysdate,'two');
insert into mail_exchange values('ved',4,sysdate,sysdate,'vedsar');
insert into mail_exchange values('ved',5,sysdate,sysdate,'test');
insert into mail_exchange values('ved',6,sysdate,sysdate,'ved');
insert into mail_exchange values('vedsar',7,sysdate,sysdate,'ved');
insert into mail_exchange values('vedsar',8,sysdate,sysdate,'vedu');

insert into draft values(7);
insert into draft values(8);

commit;