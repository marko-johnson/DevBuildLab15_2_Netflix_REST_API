create database Netflix;
use Netflix;
create table movies (
    id int NOT NULL AUTO_INCREMENT,
    title varchar(50),
    category varchar(50),
    PRIMARY KEY (id)
);

insert into movies (id, title, category) values (1,'Is This The End','Comedy');
insert into movies (id, title, category) values (2,'Pineapple Express','Comedy');
insert into movies (id, title, category) values (3,'Candyman','Horror');
insert into movies (id, title, category) values (4,'Us','Horror');
insert into movies (id, title, category) values (5,'Queen & Slim','Romance/Drama');
insert into movies (id, title, category) values (6,'True Romance','Crime/Romance');
insert into movies (id, title, category) values (7,'Jaws','Thriller/Adventure');
insert into movies (id, title, category) values (8,'Exodus','Comedy');
insert into movies (id, title, category) values (9,'Avengers: Endgame','Action/Sci-fi');
insert into movies (id, title, category) values (10,'Zack Snyder''s Justice League','Action/Adventure');
