CREATE DATABASE OrgFinanceDB;
GO
USE OrgFinanceDB;
GO

-- tao bang Users
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(255) UNIQUE NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL,
    Email VARCHAR(255) UNIQUE,
    CreatedAt DATETIME DEFAULT GETDATE()
);

insert into Users (Username, PasswordHash, Email, CreatedAt) values ('ntung', 'ntung', 'ntung@gmail.com', '2025-04-01')

-- Bảng Tài khoản ngân sách / Quỹ tiền
CREATE TABLE FundAccount (
    FundID INT PRIMARY KEY IDENTITY(1,1),
    FundName NVARCHAR(100),
    FundType NVARCHAR(50), -- Tiền mặt, Ngân hàng
    Balance DECIMAL(18,2) DEFAULT 0,
    BankAccount NVARCHAR(50) NULL
);

-- Bảng Danh mục khoản mục thu - chi
CREATE TABLE Category (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(100),
    CategoryType NVARCHAR(10), -- 'Thu' hoặc 'Chi'
);

-- Đối tượng giao dịch (Khách hàng / Nhà cung cấp / Nhân viên)
CREATE TABLE BussinessPartner (
    PartnerID INT PRIMARY KEY IDENTITY(1,1),
    PartnerName NVARCHAR(255),
    PartnerType NVARCHAR(50), -- Customer / Supplier / Staff
    Phone NVARCHAR(50),
    Email NVARCHAR(100)
);

-- Giao dịch tài chính
CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY IDENTITY(1,1),
    FundID INT FOREIGN KEY REFERENCES FundAccount(FundID),
    CategoryID INT FOREIGN KEY REFERENCES Category(CategoryID),
    PartnerID INT NULL FOREIGN KEY REFERENCES BussinessPartner(PartnerID),
    TransactionDate DATE NOT NULL DEFAULT GETDATE(),
    Amount DECIMAL(18,2) NOT NULL,
    TransactionDescription NVARCHAR(255),
    Attachment NVARCHAR(255) NULL
);

select * from Transactions

-- Quản lý công nợ
CREATE TABLE Debt (
    DebtID INT PRIMARY KEY IDENTITY(1,1),
    PartnerID INT FOREIGN KEY REFERENCES BussinessPartner(PartnerID),
    TotalAmount DECIMAL(18,2),
	PaidAmount DECIMAL(18,2) DEFAULT 0,
    RemainAmount AS (TotalAmount - PaidAmount),
    DebtType NVARCHAR(10), -- 'Phải thu' hoặc 'Phải trả'
    DueDate DATE,
    DebtStatus NVARCHAR(50) -- Chưa thanh toán / Đã thanh toán
);

-- Quản lý ngân sách theo năm / quý / tháng
CREATE TABLE Budget (
    BudgetID INT PRIMARY KEY IDENTITY(1,1),
    BudgetYear INT,
    BudgetMonth INT,
    CategoryID INT FOREIGN KEY REFERENCES Category(CategoryID),
    BudgetAmount DECIMAL(18,2),
    Note NVARCHAR(255)
);

CREATE TABLE BusinessGoal (
    GoalID INT PRIMARY KEY IDENTITY(1,1),
    GoalName NVARCHAR(255),
    TargetAmount DECIMAL(18,2),
    CurrentAmount DECIMAL(18,2) DEFAULT 0,
    DueDate DATE,
    GoalStatus NVARCHAR(50) -- Active, Completed, Cancelled
);

-- insert data
-- Sample data for FundAccount
INSERT INTO FundAccount (FundName, FundType, Balance, BankAccount) VALUES
('Cash on Hand', 'Cash', 5000.00, NULL),
('Main Bank Account', 'Bank', 25000.00, '1234567890'),
('Petty Cash', 'Cash', 1000.00, NULL),
('Savings Account', 'Bank', 15000.00, '9876543210');

-- Sample data for Category (Income and Expense)
INSERT INTO Category (CategoryName, CategoryType) VALUES
('Top-up fund', 'Income'),
('Product Sales', 'Income'),
('Service Revenue', 'Income'),
('Investment Income', 'Income'),
('Receive dept payment', 'Income'),
('Utilities Expense', 'Expense'),
('Salary Expense', 'Expense'),
('Office Supplies', 'Expense'),
('Loan Payment', 'Expense'),
('Tax Expense', 'Expense')