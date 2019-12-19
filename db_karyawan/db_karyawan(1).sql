-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 08 Okt 2019 pada 06.05
-- Versi server: 10.3.16-MariaDB
-- Versi PHP: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_karyawan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_karyawan`
--

CREATE TABLE `t_karyawan` (
  `nik` varchar(15) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `tempat_lahir` varchar(20) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `agama` varchar(15) NOT NULL,
  `status` varchar(15) NOT NULL,
  `kewarganegaraan` varchar(15) NOT NULL,
  `no_hp` varchar(13) NOT NULL,
  `email` varchar(25) NOT NULL,
  `alamat` varchar(35) NOT NULL,
  `pendidikan_terakhir` varchar(4) NOT NULL,
  `pt_terakhir` varchar(50) NOT NULL,
  `jabatan` varchar(15) NOT NULL,
  `tgl_masuk` date NOT NULL,
  `bagian` varchar(20) NOT NULL,
  `gaji` varchar(20) NOT NULL,
  `status_karyawan` varchar(15) NOT NULL,
  `status_kerja` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `t_karyawan`
--

INSERT INTO `t_karyawan` (`nik`, `nama`, `tempat_lahir`, `tgl_lahir`, `agama`, `status`, `kewarganegaraan`, `no_hp`, `email`, `alamat`, `pendidikan_terakhir`, `pt_terakhir`, `jabatan`, `tgl_masuk`, `bagian`, `gaji`, `status_karyawan`, `status_kerja`) VALUES
('18084100400043', 'Titrit Aryanti', 'Kobar', '0000-00-00', 'Islam', 'Belum Nikah', 'WNI', '081350188512', 'titritaryanti@gmail.com', 'Jln. jati raya 1', 'S2', 'Universitas Indonesia', 'Manajer', '0000-00-00', 'Prosedure', '50.000.000', 'Tetap', 'Aktif'),
('18084100400043', 'Titrit Aryanti', 'Kobar', '0000-00-00', 'Islam', 'Belum Nikah', 'WNI', '081350188512', 'titritaryanti@gmail.com', 'Jln. jati raya 1', 'S2', 'Universitas Indonesia', 'Manajer', '0000-00-00', 'Prosedure', '50.000.000', 'Tetap', 'Aktif');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
