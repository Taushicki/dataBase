					--USERS TABLE

					--Create Table Users
-- create table users(
-- 	id serial primary key,
-- 	login varchar(25) not null,
-- 	password varchar(25) not null,
-- 	rights varchar(6) not null default 'user'
-- )



					--Create Function AddUser
-- CREATE OR REPLACE FUNCTION AddUser(new_login VARCHAR(25), new_password VARCHAR(25)) RETURNS VOID AS $$
-- BEGIN
--   INSERT INTO users (login, password) VALUES (new_login, new_password);
-- END;
-- $$ LANGUAGE plpgsql;





					--Create Function GetUserByLogin()
-- CREATE OR REPLACE FUNCTION GetUserByLogin(_login VARCHAR(25)) RETURNS TABLE (
-- 	user_id INT,
--  user_login VARCHAR(25),
-- 	user_password VARCHAR(25),
-- 	user_rights VARCHAR(25)) 
-- AS $$
-- BEGIN
--  	RETURN QUERY
-- 	SELECT * FROM users WHERE login = _login;
-- 	IF NOT FOUND THEN
--     	RETURN;
-- 	END IF;
-- END;
-- $$ LANGUAGE plpgsql;



					--Drop Function GetUserByLogin()
--DROP FUNCTION getuserbylogin(character varying);

					--Test Function GetUserByLogin
--SELECT * FROM GetUserByLogin('admin');



					--CreateFunction UsersSelect()
-- create or replace function UsersSelect() returns table(
-- 	id int,
-- 	login varchar(25),
-- 	password varchar(25),
-- 	rights varchar(6)
-- ) as
-- $$
-- begin
-- 	return query
-- 	select * from users order by id;
-- end
-- $$
-- language plpgsql;


					--Drop Function UsersSelect()
--DROP FUNCTION UsersSelect();

					--Test Function UsersSelect()
--select * from UsersSelect();





					--PRODUCTS TABLE

					--Create Table Products 
-- create table products(
-- 	id serial primary key,
-- 	category varchar(50) not null,
-- 	name varchar(100) not null,
-- 	country varchar(20) not null,
-- 	price money not null,
-- 	count int
-- );



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
-- CREATE OR REPLACE FUNCTION AddProduct(
-- 	_name VARCHAR(100),
-- 	_category VARCHAR(50),
-- 	_country varchar(20),
-- 	_price money,
-- 	_count int) RETURNS VOID AS 
-- $$
-- BEGIN
--   INSERT INTO products (name, category, country, price, count) VALUES (_name, _category, _country, _price, _count);
-- END;
-- $$ LANGUAGE plpgsql;					


					--Drop Function AddProduct()					
-- drop function AddProducts(_name VARCHAR(100), _category VARCHAR(50), _country varchar(20), _price money, _count int);

					--Test Function AddProduct()
-- select AddProduct('ASUS Aspire A7'::varchar(100), 'Laptop'::varchar(50),  'China'::varchar(20), 70000::money, 3);					
-- select * from products;



					--Create Function UpdateProductsTable()
-- create or replace function UpdateProductsTable(_id bigint, _category varchar(50),
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


					--Drop Function UpdateProductsTable()
-- DROP FUNCTION UpdateProductsTable(_id bigint, _category varchar(50),
-- 									   _name varchar(100), _country varchar(20),
-- 									  _price money, _count int);

					--Test Function UpdateProductsTable()
-- select * from UpdateProductsTable(2::bigint, 'Mobile Phone'::varchar(50), 
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
-- select * from GetRecordByNameOrId('Xiaomi POCO X3 PR'::varchar(100), 0);





					--TABLE SELLERS
					
					--Create Table Sellers
-- create table sellers(
-- 	seller_id serial,
-- 	surname varchar(25),
-- 	name varchar(25),
-- 	middle_name varchar(25),
--  post varchar(8),
-- 	passport_data varchar(11),
-- 	itn varchar(12),
-- 	phone_number varchar(12),
-- 	user_id int 
-- );
-- select * from sellers;
-- update sellers
-- set post = 'Director' where seller_id = 1;



-- alter table sellers add constraint FK_sellers_users
-- foreign key (user_id) references users (id);



					--Create Function SellersSelect()
-- create or replace function SellersSelect() returns table(
-- 	"Seller id" int,
-- 	"Surname" varchar(25),
-- 	"Name" varchar(25),
-- 	"Middle name" varchar(25),
--  "Post" varchar(8),
-- 	"Passport data" varchar(11),
-- 	"ITN" varchar(12),
-- 	"Phone number" varchar(12),
-- 	"Login" varchar(25),
-- 	"Password" varchar(25),
-- 	"Rights" varchar(6)
-- ) as
-- $$
-- begin
--  return query
--  select sellers.seller_id, sellers.surname, sellers.name,
--  sellers.middle_name, sellers.post, sellers.passport_data, sellers.itn,
--  sellers.phone_number, users.login, users.password, users.rights from sellers join users on sellers.user_id = users.id;
-- end
-- $$
-- language plpgsql;

					--Drop Function SellersSelect()
-- drop function sellersselect();

					--Test Function SellersSelect()
-- select * from SellersSelect();
-- insert into sellers(surname, name, middle_name, passport_data, itn, phone_number, user_id) values(
-- 	'Ivanov',
-- 	'Ivan',
-- 	'Dmitrievich',
-- 	'4921 666666',
-- 	'123456789101',
-- 	'+79112346578',
-- 	1
-- );


					--Create Function GetSellerDataByUserId()
-- create or replace function GetSellerDataByUserId(_user_id int) return table(
-- 	"Surname" varchar(25),
-- 	"Name" varchar(25),
-- 	"Middle name" varchar(25),
-- 	"Post" varchar(8),
-- 	"Passport data" varchar(11),
-- 	"ITN" varchar(12),
-- 	"Phone number" varchar(12),
-- 	"Login" varchar(25),
-- 	"Password" varchar(25),
-- ) as
-- $$
-- begin 
-- 	return query
-- 	select sellers.seller_id, sellers.surname, sellers.name,
-- 	sellers.middle_name, sellers.post, sellers.passport_data, sellers.itn,
-- 	sellers.phone_number, users.login, users.password from sellers join users on sellers.user_id = _user_id;
-- 	end
-- 	$$
-- 	language plpgsql;



					--Create Function DeleteSellerById()
-- create or replace function DeleteSellerById(_seller_id int) returns int as
-- $$
-- begin
-- 	delete from sellers where seller_id = _seller_id;
-- 	delete from users where id = _seller_id;
-- if found then
-- 		return 1;
-- 	else
-- 		return 0;
-- 	end if;
-- end
-- $$
-- language plpgsql


					--Test Function DeleteSellerById()
-- select * from deletesellerbyid(13);




					--Create Function UpdateSellersData()
-- create or replace function UpdateSellersData(_seller_id int, _surname varchar(25),
-- 									   		_name varchar(25), _middle_name varchar(25),
-- 											_post varchar(8), _passport_data varchar(11),
-- 											_itn varchar(12), _phone_number varchar(12),
-- 											_login varchar(25), _password varchar(25), 
-- 											_rights varchar(25)) returns int as
-- $$
-- begin
-- 	update users 
-- 	set
-- 		login = _login, 
-- 		password = _password,
-- 		rights = _rights 
-- 		where id = (select user_id from sellers where seller_id = _seller_id);

-- 	update sellers
-- 	set
-- 		surname = _surname,
-- 		name = _name,
-- 		middle_name = _middle_name,
-- 		post = _post,
-- 		passport_data = _passport_data,
-- 		itn = _itn,
-- 		phone_number = _phone_number
-- 	where seller_id = _seller_id;
-- 	if found then
-- 		return 1;
-- 	else
-- 		return 0;
-- 	end if;
-- end
-- $$
-- language plpgsql


-- 					--Drop Function UpdateSellersData()
-- drop function UpdateSellersData(_seller_id int, _surname varchar(25),
--  									   		_name varchar(25), _middle_name varchar(25), _post varchar(8),
--  									   		_passport_data varchar(11), _itn varchar(12),
--  											_phone_number varchar(12), _login varchar(25),
--  											_password varchar(25), rights varchar(25));


					--Test Function UpdateSellersData()
-- select * from UpdateSellersData(1, 'Vladimirov'::varchar(25), 'Vlad'::varchar(25), 'Vladimirov'::varchar(25),
--							   'director'::varchar(8),
-- 							   '4921 666666'::varchar(11), '123450989192'::varchar(25), '+79116237173'::varchar(25),
-- 							   'admin'::varchar(25), 'password'::varchar(25), 'admin'::varchar(6));					
-- select * from sellers;


					

					--TABLE ORDER
					
					--Create Table Order
-- create table "order"(
-- 	orderer_id serial,
-- 	seller_id int not null,
-- 	product_id int not null,
-- 	count int not null,
-- 	price money not null,
-- 	order_date date not null
-- );

insert into orders(seller_id, price, order_data) value(
	
)

-- alter table "order" add constraint FK_order_sellers
-- foreign key (seller_id) references sellers (seller_id);



-- alter table "order" add constraint FK_order_products
-- foreign key (product_id) references products (id);


					--Create Function OrdersSellect
-- CREATE OR REPLACE FUNCTION OrdersSelect() RETURNS TABLE (
--     "Order id" int,
--     "Seller id" int,
--     "Price" money,
--     "Date" date
-- ) AS $$
-- BEGIN
--     MERGE INTO orders o
--     USING (
--         SELECT
--             o.order_id,
--             CASE WHEN sum(p.price * pio.count) IS NOT NULL 
--                 THEN sum(p.price * pio.count)::money 
--                 ELSE 0::money 
--             END AS total_price
--         FROM
--             orders o
--         LEFT JOIN
--             products_in_orders pio ON o.order_id = pio.order_id
--         LEFT JOIN
--             products p ON pio.product_id = p.id
--         GROUP BY
--             o.order_id
--     ) temp ON o.order_id = temp.order_id
--     WHEN MATCHED THEN
--         UPDATE SET price = temp.total_price;
    
--     RETURN QUERY 
--     SELECT
--         o.order_id,
--         o.seller_id,
--         COALESCE(o.price, 0::money) AS price,
--         o.order_date
--     FROM
--         orders o;
-- END
-- $$ LANGUAGE plpgsql;


select * from OrdersSelect()
select * from products_in_orders


					--Create Function AddOrder()
-- create or replace function AddOrder(_seller_id int) returns void as
-- $$
-- begin 
-- 	insert into orders(seller_id, order_date) values (_seller_id, current_timestamp);
-- end;
-- $$ language plpgsql;


					--Drop Function AddOrder()
-- drop function AddOrder(_seller_id int);

					--TABLE PRODUCTS_IN_ORDERS

					--Create Table Products_in_orders
-- create table products_in_orders (
-- 	id serial primary key,
-- 	order_id int not null references orders(order_id),
-- 	product_id int not null references products(id),
-- 	count int not null
-- );



					--Create Function ProductsInOrdersSelect()
-- create or replace function ProductsInOrdersSelect(_order_id int) returns table(
-- 	"Order id" int,
-- 	"Product id" int,
-- 	"Name" varchar(100),
-- 	"Price" money,
-- 	"Count" int
-- ) as
-- $$
-- begin
-- 	return query 
-- 	select products_in_orders.order_id, products_in_orders.product_id, products.name, products.price, products_in_orders.count from products_in_orders
-- 	join products on products_in_orders.product_id = products.id where products_in_orders.order_id = _order_id;
-- end
-- $$
-- language plpgsql;


					--Test Function ProductsInOrdersSelect()
-- select * from ProductsInOrdersSelect(2);


					--Drop Function ProductsInOrdersSelect()
-- drop function ProductsInOrdersSelect(_order_id int)




					--Create Function AddProductIntoOrder
-- CREATE OR REPLACE FUNCTION AddProductIntoOrder(_id int, _order_id int, _count int) RETURNS VOID AS
-- $$
-- BEGIN
--     PERFORM 1
--     FROM products_in_orders
--     WHERE order_id = _order_id AND product_id = _id;

--     IF FOUND THEN
--         UPDATE products_in_orders
--         SET count = count + _count
--         WHERE order_id = _order_id AND product_id = _id;
--     ELSE
--         INSERT INTO products_in_orders (order_id, product_id, count)
--         VALUES (_order_id, _id, _count);
--     END IF;
--     UPDATE products
--     SET count = count - _count
--     WHERE id = _id;
-- END;
-- $$ LANGUAGE plpgsql;



					--Test Function AddProductIntoOrder()
-- select * from AddProductIntoOrder(15, 3, 1)



					--Drop Function AddProductIntoOrder
-- drop function AddProductIntoOrder(_id int, _order_id int, _count int);

					--Test Function AddProductIntoOrder()
-- Select * from AddProductIntoOrder();



					--Create Function DeleteProductInOrder
-- create or replace function DeleteProductInOrder(_product_id int, _order_id int) returns void as
-- $$
-- begin 
-- 	update products set count = count + (select count from products_in_orders where product_id = _product_id and order_id = _order_id) 
-- 	where id = _product_id;
-- 	delete from products_in_orders where product_id = _product_id and order_id = _order_id;
-- end;
-- $$
-- language plpgsql;


					--Test Function DeleteProductInOrder() 
-- select * from DeleteProductInOrder(15, 2);



					--TABLE PURCHASE_LIST

					--Create Table Purchase_list
-- create table purchase_list(
-- 	list_id serial,
-- 	product_id int not null,
-- 	count int not null,
-- 	price_per_one money not null,
-- 	fianl_price money not null
-- );



