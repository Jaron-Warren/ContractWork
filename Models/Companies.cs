namespace ContractWork.Models
{
  public class Companies
  {
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
  }
}

// CREATE TABLE companies(
//   id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
//   createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
//   updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
//   name varchar(255) NOT NULL COMMENT 'company Name',
//   website varchar(255) COMMENT 'Company website'
// ) default charset utf8 COMMENT '';