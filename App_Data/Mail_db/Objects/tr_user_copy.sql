create or replace trigger user_copy
after insert or update on u_profile
for each row
begin
if inserting then
insert into username(user_id) values(:new.username);
end if;
end;
/