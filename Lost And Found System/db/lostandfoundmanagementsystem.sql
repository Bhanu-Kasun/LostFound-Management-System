CREATE DATABASE lost_found_db;
USE lost_found_db;

CREATE TABLE users (
    user_id VARCHAR(20) PRIMARY KEY,
    full_name VARCHAR(100) NOT NULL,
    email VARCHAR(100),
    password_hash VARCHAR(64) NOT NULL,
    role ENUM('student','staff','admin') DEFAULT 'student',
    created_at DATETIME DEFAULT NOW()
);
CREATE TABLE lost_items (
    report_id VARCHAR(20) PRIMARY KEY,
    user_id VARCHAR(20),
    item_name VARCHAR(100) NOT NULL,
    category VARCHAR(50),
    description TEXT,
    date_lost DATE NOT NULL,
    location VARCHAR(100),
    status ENUM('Pending','Matched','Claimed') DEFAULT 'Pending',
    reported_at DATETIME DEFAULT NOW(),
    FOREIGN KEY (user_id) REFERENCES users(user_id)
);
CREATE TABLE found_items (
    found_id INT AUTO_INCREMENT PRIMARY KEY,
    staff_id VARCHAR(20),
    item_name VARCHAR(100) NOT NULL,
    category VARCHAR(50),
    description TEXT,
    date_found DATE NOT NULL,
    location VARCHAR(100),
    image_path VARCHAR(255),
    status ENUM('Pending','Matched','Claimed') DEFAULT 'Pending',
    registered_at DATETIME DEFAULT NOW(),
    FOREIGN KEY (staff_id) REFERENCES users(user_id)
);

CREATE TABLE claim_requests (
    claim_id INT AUTO_INCREMENT PRIMARY KEY,
    found_item_id INT,
    claimant_user_id VARCHAR(20),
    requested_at DATETIME DEFAULT NOW(),
    status ENUM('Pending','Approved','Rejected') DEFAULT 'Pending',
    FOREIGN KEY (found_item_id) REFERENCES found_items(found_id),
    FOREIGN KEY (claimant_user_id) REFERENCES users(user_id)
);

INSERT INTO users VALUES (
    'ADMIN001', 'Admin User', 'admin@uom.lk',
    SHA2('admin123', 256), 'admin', NOW()
);
