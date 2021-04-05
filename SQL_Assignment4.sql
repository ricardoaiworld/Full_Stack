--1
create table Office(Id int primary key, Name varchar(20) unique not null, City varchar(20), Country varchar(20), Address varchar(20), Phone int, Director varchar(20))

create table Project(Code int primary key, title varchar(20), StartDate date, EndDate date, Budget float, Manager varchar(20))

--2
create table Lender(Id int primary key, Name varchar(20), Amount float)

create table Borrower(Id int primary key, Name varchar(20), RiskValue float)

create table Loan(Code int primary key, Lender int not null, Borrower int not null, Amount float, Deadline date, InterestRate float, purpose varchar(500)
constraint lender foreign key(Lender) references Lender(Id),
constraint borrower foreign key(Borrower) references Borrower(Id))

--3
create table Course(Id int primary key, Name varchar(20), Descrption varchar(500), Price float, Category varchar(20), Employee varchar(20))

create table Recipe(Id int primary key, Name varchar(20))

create table Ingredient(Id int primary key, Name varchar(20), Amount float)

create table RecipeIngredient(Rid int not null, Iid int not null, Amount float, Unit varchar(20)
constraint recipe foreign key(Rid) references Recipe(Id),
constraint ingredient foreign key(Iid) references Ingredient(Id))


