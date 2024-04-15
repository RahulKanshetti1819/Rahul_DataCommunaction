
CREATE TABLE RK (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(50),
    city VARCHAR(50),
    experience INT
);


INSERT INTO RK (name, city, experience)
VALUES ('John Smith', 'New York', 5),
       ('Emma Johnson', 'Los Angeles', 8);
	   
	   
	   select * from RK