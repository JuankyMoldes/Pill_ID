DROP DATABASE IF EXISTS pharma;

CREATE DATABASE pharma;

USE pharma;

CREATE TABLE pharma.Users
(
	username varchar(15) NOT NULL,
    pass varchar(15) NOT NULL
);

	INSERT INTO pharma.Users (username, pass)
		VALUES('Juanky', 'tempPassword');

CREATE TABLE pharma.Pills
(
	pill_imprint varchar(15) NOT NULL,
    pill_color varchar(15) NOT NULL,
    pill_shape varchar(15),
	drug_name varchar(75) NOT NULL,
    drug_strength varchar(75),
    pill_photo varchar(50),
    creation_date timestamp NOT NULL 
);
    
    INSERT INTO pharma.Pills (pill_imprint, pill_color, pill_shape, drug_name, drug_strength, pill_photo, creation_date)
			VALUES ('9 3 5510','Yellow', 'Round', 'Mercatoupurine', '50 mg', 'mercatopurine.jpg', '2017-1-11 10:55:36'); 
            
select count(*) from  pills;

select * from pills;