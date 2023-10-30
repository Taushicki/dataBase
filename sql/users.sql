CREATE OR REPLACE FUNCTION AddUser(new_login VARCHAR(25), new_password VARCHAR(25)) RETURNS VOID AS $$
BEGIN
  INSERT INTO users (login, password) VALUES (new_login, new_password);
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION GetUserByLogin(_login VARCHAR(25)) RETURNS TABLE (
	user_id INT,
  	user_login VARCHAR(25),
	user_password VARCHAR(25),
	user_rights VARCHAR(25)) 
AS $$
BEGIN
 	RETURN QUERY
	SELECT * FROM users WHERE login = _login;
	IF NOT FOUND THEN
    	RETURN;
	END IF;
END;
$$ LANGUAGE plpgsql;


DROP FUNCTION getuserbylogin(character varying);
SELECT * FROM GetUserByLogin('admin'); 

SELECT * FROM users;

ALTER TABLE users DROP COLUMN name;
delete from users where login = 'valera';
ALTER TABLE users ADD rights VARCHAR(6) NOT NULL DEFAULT 'user';
UPDATE users SET rights = 'admin' WHERE login = 'admin';