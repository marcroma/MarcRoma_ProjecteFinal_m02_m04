CREATE TABLE customers (
  id INT PRIMARY KEY AUTO_INCREMENT,
  name VARCHAR(255),
  email VARCHAR(255),
  phone VARCHAR(255),
  address VARCHAR(255)
);

CREATE TABLE contacts (
  id INT PRIMARY KEY AUTO_INCREMENT,
  customerId INT,
  name VARCHAR(255),
  email VARCHAR(255),
  phone VARCHAR(255),
  company VARCHAR(255),
  FOREIGN KEY (customerId) REFERENCES customers(id)
  ON DELETE CASCADE
);

CREATE TABLE opportunities (
  id INT PRIMARY KEY AUTO_INCREMENT,
  customerId INT,
  amount DECIMAL(10,2),
  status VARCHAR(255),
  FOREIGN KEY (customerId) REFERENCES customers(id)
  ON DELETE CASCADE
);