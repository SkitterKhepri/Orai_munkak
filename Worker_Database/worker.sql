CREATE DATABASE worker;
USE worker;

CREATE TABLE roles(
	rid INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
	role VARCHAR(20)
);

CREATE TABLE cities(
	cid INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
	city VARCHAR(20)
);

CREATE TABLE workers(
	wid INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
	name VARCHAR(50),
	born DATE,
	salary INTEGER,
	roleid INTEGER,
	cityid INTEGER,
	FOREIGN KEY (roleid) REFERENCES roles(rid),
	FOREIGN KEY (cityid) REFERENCES cities(cid)
);

INSERT INTO roles(role) VALUES
("Munkás"),
("Irodista"),
("Meos");

INSERT INTO cities(city) VALUES
("Budapest"),
("Vác"),
("Szeged"),
("Kecskemét"),
("Miskolc");

INSERT INTO workers( name, born, salary, roleid, cityid ) VALUES
("Har Mónika", "1998-02-05", 650000, 2, 3),
("Kala Pál", "2000-10-22", 875000, 3, 1),
("Fá Zoltán", "1995-09-01", 480000, 1, 5),
("Csák Ányos", "2005-06-14", 450000, 1, 2),
("Techno Kolos", "1997-11-30", 510000, 1, 4);
