insert into products(category, name, country, price, count) values('mobile phone', 'IPhone 15 Pro', 'China', 220000.00, 3);
					--Create Function ProductsSelect()
-- create or replace function ProductsSelect() returns table(
-- 	_id bigint,
-- 	_category varchar(50),
-- 	_name varchar(100),
-- 	_country varchar(20),
-- 	_price money,
-- 	_count int
-- )as
-- $$
-- begin 
-- 	return query
-- 	select * from products order by id;
-- end
-- $$
-- language plpgsql

					--Drop Function ProductsSelect()
--DROP FUNCTION ProductsSelect();

					--Test Function ProductsSelect()
--select * from ProductsSelect();






					--Create Function AddProduct()
					
					
					
					
					
					
					--Create Function UPDATE
-- create or replace function UpdateTable(_id bigint, _category varchar(50),
-- 									   _name varchar(100), _country varchar(20),
-- 									  _price money, _count int) returns int as
-- $$
-- begin
-- 	update products
-- 	set
-- 		id = _id,
-- 		category = _category,
-- 		name = _name,
-- 		country = _country,
-- 		price = _price,
-- 		count = _count
-- 	where id = _id;
-- 	if found then
-- 		return 1;
-- 	else
-- 		return 0;
-- 	end if;
-- end
-- $$
-- language plpgsql

					--Drop Function UpdateTable()
-- DROP FUNCTION updatetable(_id bigint, _category varchar(50),
-- 									   _name varchar(100), _country varchar(20),
-- 									  _price money, _count int);

					--Test Function UpdateTable()
-- select * from UpdateTable(1::bigint, 'Mobile Phone'::varchar(50), 
-- 						  'Samsung Galaxy S23'::varchar(100), 'China'::varchar(20),
-- 						  40000::money, 3);






					--Create Function DeleteData()
-- create or replace function DeleteData(_id bigint) returns int as
-- $$
-- begin
-- 	delete from products where id = _id;
-- if found then
-- 		return 1;
-- 	else
-- 		return 0;
-- 	end if;
-- end
-- $$
-- language plpgsql

					--Drop Function DeleteData()
--drop function DeleteData(_id bigint)

					--Test Function DeleteData()
--select * from DeleteData(1);






					--Create Function GetRecordByNameOrId()
-- CREATE OR REPLACE FUNCTION GetRecordByNameOrId(RecordName varchar(100), RecordId int)
-- returns table(
-- 	_id bigint,
-- 	_category varchar(50),
-- 	_name varchar(100),
-- 	_country varchar(20),
-- 	_price money,
-- 	_count int
-- )as
-- $$
-- BEGIN
--     RETURN QUERY
--     SELECT * FROM products
--     WHERE name = RecordName OR id = RecordId;
-- END;
-- $$ LANGUAGE plpgsql;

					--Drop Function GetRecordByNameOrId()
-- drop function GetRecordByNameOrId(RecordName varchar(100), RecordId int);

					--Test Function GetRecordByNameOrId()
select * from GetRecordByNameOrId('Xiaomi POCO X3 PR'::varchar(100), 0);