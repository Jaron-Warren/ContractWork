namespace ContractWork.Models
{
  public class Jobs
  {
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
  }
}

// CREATE TABLE jobs(
//   id int NOT NULL primary key AUTO_INCREMENT COMMENT 'primary key',
//   createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
//   contractorId int NOT NULL COMMENT 'User Name',
//   companyId int COMMENT 'User Email',
//   FOREIGN KEY (contractorId) REFERENCES contractors(id) ON DELETE CASCADE,
//   FOREIGN KEY (companyId) REFERENCES companies(id) ON DELETE CASCADE
// ) default charset utf8 COMMENT '';