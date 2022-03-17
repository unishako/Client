create schema client;
GO

create table client.emp
(
    id   int identity
        constraint emp_pk
        primary key,
    name nvarchar(100)
);
GO

insert client.emp values (N'兎田ぺこら');
insert client.emp values (N'潤羽るしあ');
insert client.emp values (N'不知火フレア');
insert client.emp values (N'白銀ノエル');
insert client.emp values (N'宝鐘マリン');
