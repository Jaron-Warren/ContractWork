CREATE TABLE contractors(
  id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) NOT NULL COMMENT 'Contractor Name',
  email varchar(255) COMMENT 'Contractor Email'
) default charset utf8 COMMENT '';
CREATE TABLE companies(
  id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) NOT NULL COMMENT 'company Name',
  website varchar(255) COMMENT 'Company website'
) default charset utf8 COMMENT '';
CREATE TABLE jobs(
  id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  contractorId int NOT NULL COMMENT 'User Name',
  companyId int COMMENT 'User Email',
  FOREIGN KEY (contractorId) REFERENCES contractors(id) ON DELETE CASCADE,
  FOREIGN KEY (companyId) REFERENCES companies(id) ON DELETE CASCADE
) default charset utf8 COMMENT '';
DROP TABLE contractor