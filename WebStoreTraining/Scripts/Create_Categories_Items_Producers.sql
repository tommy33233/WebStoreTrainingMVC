if object_id('Producers') is  null
begin
create table Producers
(ProducerId int identity(1,1) primary key,
Name nvarchar(max) null
)
end


if object_id('Categories') is null
begin 
create table Categories(
CategoryId int identity(1,1) primary key,
Name nvarchar(max) null,
Description nvarchar(max) null
)
end

if object_id('Items') is null
begin
create table Items(
ItemId int identity(1,1) primary key,
Title nvarchar(max) null,
ProducerId int not null,
Price decimal null,
ItemArtUrl nvarchar(max) null,
)
end

insert into Producers(Name)
values('Beats'),
('Philips'),
('Zara'), ('Brown')

insert into Categories(Name)
values('Electronics'), ('Accessories')

insert into Items(Title,ProducerId,Price)
values ('Speakers', 1,23)