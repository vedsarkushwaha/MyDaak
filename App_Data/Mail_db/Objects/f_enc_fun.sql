create or replace function enc_fun(user_n in varchar2,passw in varchar2) return varchar2 as
raw_n varchar2(100);
n number;
i number;
z number;
y number;
m number;
begin
y:=1;
raw_n:=user_n;
n:=length(user_n);
for i in 1..n
loop
z:=ascii(substr(passw,i,i));
raw_n:=substr(raw_n,1,i-1)||chr(ascii(substr(raw_n,i,i))+z+y)||substr(raw_n,i+1,n);
y:=y+1;
end loop;
m:=length(passw)-length(user_n);
for i in 1..n
loop
raw_n:=substr(raw_n,1,i-1)||chr(ascii(substr(raw_n,i,i))-m)||substr(raw_n,i+1,n);
end loop;
return raw_n;
end;
/