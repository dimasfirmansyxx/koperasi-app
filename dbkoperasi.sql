-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 17, 2018 at 07:14 AM
-- Server version: 5.6.20
-- PHP Version: 5.6.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dbkoperasi`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblanggota`
--

CREATE TABLE IF NOT EXISTS `tblanggota` (
`id` int(11) NOT NULL,
  `kode` varchar(4) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `alamat` text NOT NULL,
  `telepon` varchar(12) NOT NULL,
  `ktp` varchar(16) NOT NULL,
  `saldo` varchar(100) NOT NULL,
  `lvl` enum('A','P','PG') NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `tblanggota`
--

INSERT INTO `tblanggota` (`id`, `kode`, `nama`, `alamat`, `telepon`, `ktp`, `saldo`, `lvl`) VALUES
(1, '051A', 'Budi', 'Batu Ampar', '087798347590', '2171905983798457', '0', 'A'),
(2, '052A', 'Andi', 'Sengkuang', '081295827598', '2171023758297395', '200000', 'A');

-- --------------------------------------------------------

--
-- Table structure for table `tblaturan`
--

CREATE TABLE IF NOT EXISTS `tblaturan` (
  `id` int(11) NOT NULL,
  `simpanan_pokok` int(20) NOT NULL,
  `simpanan_wajib` int(20) NOT NULL,
  `simpanan_sukarela` int(20) NOT NULL,
  `denda` int(20) NOT NULL,
  `maksimal_peminjaman` int(20) NOT NULL,
  `minimal_saldo` int(20) NOT NULL,
  `maks_root` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblaturan`
--

INSERT INTO `tblaturan` (`id`, `simpanan_pokok`, `simpanan_wajib`, `simpanan_sukarela`, `denda`, `maksimal_peminjaman`, `minimal_saldo`, `maks_root`) VALUES
(0, 200000, 100000, 0, 10, 3, 200000, 50);

-- --------------------------------------------------------

--
-- Table structure for table `tblpembayaran`
--

CREATE TABLE IF NOT EXISTS `tblpembayaran` (
  `id` int(11) NOT NULL,
  `tanggal` varchar(10) NOT NULL,
  `kode_pinjaman` int(11) NOT NULL,
  `kode_anggota` varchar(11) NOT NULL,
  `nama_anggota` varchar(100) NOT NULL,
  `bayar` int(11) NOT NULL,
  `tgl` varchar(2) NOT NULL,
  `bln` varchar(2) NOT NULL,
  `thn` varchar(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblpengambilan`
--

CREATE TABLE IF NOT EXISTS `tblpengambilan` (
  `id` int(11) NOT NULL,
  `tanggal` varchar(10) NOT NULL,
  `kode_anggota` varchar(11) NOT NULL,
  `nama_anggota` varchar(100) NOT NULL,
  `jumlah` varchar(100) NOT NULL,
  `tgl` varchar(2) NOT NULL,
  `bln` varchar(2) NOT NULL,
  `thn` varchar(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblpinjaman`
--

CREATE TABLE IF NOT EXISTS `tblpinjaman` (
  `id` int(11) NOT NULL,
  `tanggal` varchar(10) NOT NULL,
  `kode_anggota` varchar(100) NOT NULL,
  `nama_anggota` varchar(100) NOT NULL,
  `bunga` varchar(3) NOT NULL,
  `lama_cicilan` varchar(2) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `angsuran` int(11) NOT NULL,
  `telah_dibayar` int(11) NOT NULL,
  `total_dibayar` int(11) NOT NULL,
  `status` enum('Belum Lunas','Lunas') NOT NULL,
  `tempo` varchar(2) NOT NULL,
  `tgl` varchar(2) NOT NULL,
  `bln` varchar(2) NOT NULL,
  `thn` varchar(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblsimpanan`
--

CREATE TABLE IF NOT EXISTS `tblsimpanan` (
`id` int(11) NOT NULL,
  `tanggal` varchar(10) NOT NULL,
  `kode_anggota` varchar(11) NOT NULL,
  `nama_anggota` varchar(100) NOT NULL,
  `jenis_simpanan` enum('Wajib','Pokok','Sukarela') NOT NULL,
  `jumlah` int(20) NOT NULL,
  `bulan` varchar(50) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=1000000004 ;

--
-- Dumping data for table `tblsimpanan`
--

INSERT INTO `tblsimpanan` (`id`, `tanggal`, `kode_anggota`, `nama_anggota`, `jenis_simpanan`, `jumlah`, `bulan`) VALUES
(1000000001, '17/12/2018', '052A', 'Andi', 'Pokok', 200000, 'Desember 2018');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE IF NOT EXISTS `tbluser` (
`id` int(11) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `username` varchar(16) NOT NULL,
  `password` varchar(16) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`id`, `nama`, `username`, `password`) VALUES
(1, 'Administrator', 'admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblanggota`
--
ALTER TABLE `tblanggota`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblaturan`
--
ALTER TABLE `tblaturan`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblpembayaran`
--
ALTER TABLE `tblpembayaran`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblpengambilan`
--
ALTER TABLE `tblpengambilan`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblpinjaman`
--
ALTER TABLE `tblpinjaman`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblsimpanan`
--
ALTER TABLE `tblsimpanan`
 ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
 ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblanggota`
--
ALTER TABLE `tblanggota`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `tblsimpanan`
--
ALTER TABLE `tblsimpanan`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=1000000004;
--
-- AUTO_INCREMENT for table `tbluser`
--
ALTER TABLE `tbluser`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
