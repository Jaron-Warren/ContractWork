namespace ContractWork.Models
{
  public class Contractor
  {
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
  }
}

// CREATE TABLE contractors(
//   id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
//   createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
//   updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
//   name varchar(255) NOT NULL COMMENT 'Contractor Name',
//   email varchar(255) COMMENT 'Contractor Email'
// ) default charset utf8 COMMENT '';