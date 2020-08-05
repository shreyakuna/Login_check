create table login_details(
user_id int primary key,
user_name varchar(50),
user_password varchar(10)
)
Go
select * from login_details
Go
insert into login_details values (1,'John','john@54'),(2,'Kevin','kevin99'),(3,'Harry','james')
Go
