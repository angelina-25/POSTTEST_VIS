-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 04 Bulan Mei 2025 pada 15.28
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_blt`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_penerima`
--

CREATE TABLE `tb_penerima` (
  `NKK` varchar(20) NOT NULL,
  `Gender` varchar(50) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `Alamat` text NOT NULL,
  `No_telp` varchar(30) NOT NULL,
  `No_rek` varchar(15) NOT NULL,
  `Gajih` double(10,2) NOT NULL,
  `Nominal` double(10,2) NOT NULL,
  `Deskripsi` text NOT NULL,
  `Foto` varchar(5) NOT NULL COMMENT 'path gambar',
  `Status` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_user`
--

CREATE TABLE `tb_user` (
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `role` varchar(20) NOT NULL DEFAULT '''admin'' atau ''user'''
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tb_penerima`
--
ALTER TABLE `tb_penerima`
  ADD PRIMARY KEY (`NKK`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
