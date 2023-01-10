-- create table for Salutation
create table Salutation (
  salutationId int NOT NULL auto_increment PRIMARY KEY,
  label varchar(255)
);

-- create table for Postal
create table Postal (
  postalId int NOT NULL auto_increment PRIMARY KEY,
  label varchar(255)
);

-- create table for PhoneType
create table PhoneType (
  phoneTypeId int NOT NULL auto_increment PRIMARY KEY,
  label varchar(255)
);

-- create table for Company
create table Company (
  companyId int NOT NULL auto_increment PRIMARY KEY,
  label varchar(255)
);

-- Contact Table
create table Contact (
  contactId int NOT NULL auto_increment PRIMARY KEY,
  salutationId int,
  firstname varchar(255),
  surname varchar(255),
  street varchar(255),
  postalId int,
  phone varchar(255),
  phoneTypeId int,
  mobil varchar(255),
  companyId int,
  department varchar(255),
  CONSTRAINT FK_Contact_Salutation FOREIGN KEY (salutationId) REFERENCES Salutation(salutationId),
  CONSTRAINT FK_Contact_Postal FOREIGN KEY (postalId) REFERENCES Postal(postalId),
  CONSTRAINT FK_Contact_PhoneType FOREIGN KEY (phoneTypeId) REFERENCES PhoneType(phoneTypeId),
  CONSTRAINT FK_Contact_Company FOREIGN KEY (companyId) REFERENCES Company(companyId)
);

-- Appointments Table
create table Appointment (
  appointmentId int NOT NULL auto_increment PRIMARY KEY,
  contactId int,
  time date,
  description varchar(255),
  FOREIGN KEY (contactId) REFERENCES Contact(contactId)
);