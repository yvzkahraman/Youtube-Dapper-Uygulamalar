create database DapperYoutube
use DapperYoutube
create table Ogrenci(
Id int identity(1,1) primary key,
Ad nvarchar(100),
DogumTarih datetime
)
create table OgrenciGiris(
Id int primary key,
Email nvarchar(50),
Sifre nvarchar(15),
foreign key(Id) references Ogrenci(Id)
)

create table OgrenciAdres(
Id int identity(1,1) primary key,
Tanim nvarchar(50),
OgrenciId int,
foreign key(OgrenciId) references Ogrenci(Id)
)
create table Ders(
Id int identity(1,1) primary key,
Ad nvarchar(100),
Ucret decimal(12,3)
)
create table OgrenciDers(
OgrenciId int,
DersId int,
primary key(OgrenciId,DersId),
foreign key(OgrenciId) references Ogrenci(Id),
foreign key(DersId) references Ders(Id)
)

select * from Ogrenci

insert into Ogrenci values('Yavuz','3/24/1993')

insert into Ogrenci values('Ahmet','5/24/1995')
insert into Ogrenci values('Ali','7/24/1997')
insert into Ogrenci values('Ayşe','2/24/1996')
insert into Ogrenci values('Tuğba','5/24/1995')

select * from Ogrenci
select * from OgrenciAdres
insert into OgrenciAdres values('Ev adresi',1)
insert into OgrenciAdres values('İş adresi',1)
insert into OgrenciAdres values('Okul adresi',1)

select * from Ogrenci inner join OgrenciAdres
                        on Ogrenci.Id=OgrenciAdres.OgrenciId where Ogrenci.Id=1



create procedure upOgrenciEkle
(
@Ad nvarchar(100),@DogumTarih datetime
)
as
begin
insert into Ogrenci(Ad,DogumTarih) values(@Ad,@DogumTarih)
end 

exec upOgrenciEkle 'YeniOgrenci','3/12/1993'

select * from Ogrenci




create proc upOgrenciSil(
@Id int
)
as
begin
delete from Ogrenci where Id=@Id
end 

exec upOgrenciSil 17
select * from Ogrenci

select * from OgrenciDers
--create table Ogrenci(
--Id int identity(1,1) primary key,
--Ad nvarchar(100),
--DogumTarih datetime
--)

create proc upOgrenciDuzenle(
@id int,
@ad nvarchar(100),
@dogumTarih datetime
)
as
begin
update Ogrenci set Ad=@ad, DogumTarih=@dogumTarih where Id=@id
end

select * from Ogrenci

select * from OgrenciGiris

insert into OgrenciGiris values(1,'yvz','1')

select  * from Ders
insert into Ders values('VTYS',190.5)
insert into Ders values('NYP',190.5)
insert into Ders values('Fizik',220)
insert into Ders values('Algoritma',220)

select * from OgrenciDers
insert into OgrenciDers values(1,6)
insert into OgrenciDers values(1,7)
insert into OgrenciDers values(1,9)

insert into OgrenciDers values(2,8)
insert into OgrenciDers values(2,9)

select * from Ogrenci 
inner join OgrenciGiris
on Ogrenci.Id= OgrenciGiris.Id
where Ogrenci.Id=1


select * from Ogrenci
inner join OgrenciDers
on Ogrenci.Id=OgrenciDers.OgrenciId
inner join Ders 
on OgrenciDers.DersId=Ders.Id
where Ogrenci.Id=1


create table Hesap(
Id int identity(1,1) primary key,
Kullanici nvarchar(100),
Bakiye decimal(15,3)
)

select * from Hesap
insert into Hesap values('Yavuz',600)
insert into Hesap values('Ahmet',100)


Update Hesap set Bakiye=600 where Id=1
Update Hesap set Bakiye=100 where Id=2