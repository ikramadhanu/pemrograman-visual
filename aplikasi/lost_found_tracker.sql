
-- Buat database
CREATE DATABASE IF NOT EXISTS lost_found_tracker;

-- Gunakan database
USE lost_found_tracker;

-- Tabel: items (barang ditemukan)
CREATE TABLE IF NOT EXISTS items (
    id INT AUTO_INCREMENT PRIMARY KEY,
    item_name VARCHAR(100) NOT NULL,
    description TEXT,
    category VARCHAR(50),
    location_found VARCHAR(100),
    date_found DATE,
    photo_url VARCHAR(255),
    status ENUM('Tersedia', 'Sudah Diklaim') DEFAULT 'Tersedia',
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
);

-- Tabel: claims (riwayat klaim barang)
CREATE TABLE IF NOT EXISTS claims (
    id INT AUTO_INCREMENT PRIMARY KEY,
    item_id INT,
    claimant_name VARCHAR(100),
    contact_info VARCHAR(100),
    proof_description TEXT,
    claim_date DATE,
    FOREIGN KEY (item_id) REFERENCES items(id) ON DELETE CASCADE
);

-- Tabel: admin (user tunggal)
CREATE TABLE IF NOT EXISTS admin (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL,
    email VARCHAR(100),
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
