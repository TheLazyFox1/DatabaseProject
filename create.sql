-- Table: Laptop
CREATE TABLE IF NOT EXISTS Laptop (
    LaptopName TEXT,
    SerialNumber TEXT PRIMARY KEY,
    PurchaseTime TIMESTAMP,
    Brand TEXT,
    Model TEXT,
    Price REAL
);
