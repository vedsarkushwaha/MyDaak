create table messages(m_uid number constraint messages_pk primary key,m_heading varchar2(200),m_body varchar2(4000),attachment varchar2(1000), m_created_date date,m_modified_date date,status varchar2(20));