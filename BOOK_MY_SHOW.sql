Create database BOOk_MY_SHOW;
Create Table BMS_Tbl_USERS(
userid bigint primary key Identity(1,1),
username varchar(200),
email varchar(150),
passWord  varchar(100),
mobilenumber bigint,
gender varchar(300),
dob date,
address varchar(500),
created_date date,
updated date ,
login_time date,
logout_time date
);
select * from BMS_Tbl_USERS;
drop  table BMS_Tbl_USERS;

create table BMS_tbl_Admin(
admin_id bigint primary key Identity(1,1),
adminname varchar(200),
email  varchar(200),
password varchar(200),
mobilenumber bigint,
login_time date,
logout_time date
);
select * from BMS_tbl_Admin;

Create table BMS_tbl_SuperAdmin(
superadmin_id bigint primary key Identity(1,1),
adminname varchar(250),
email  varchar(230),
password varchar(100),
mobilenumber bigint,
login_time date,
logout_time date
);
select * from BMS_tbl_SuperAdmin;

create table BMS_tbl_Events(
event_id bigint primary key Identity(1,1),
eventname varchar(250),
venue varchar(150),
location varchar(200),
startdate date,
enddate date,
price decimal,
discription varchar(200)
);
 select * from BMS_tbl_Events;