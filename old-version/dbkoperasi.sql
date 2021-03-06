-- phpMyAdmin SQL Dump
-- version 4.2.7.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 10, 2018 at 05:00 AM
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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `tblanggota`
--

INSERT INTO `tblanggota` (`id`, `kode`, `nama`, `alamat`, `telepon`, `ktp`, `saldo`, `lvl`) VALUES
(1, '051A', 'Budi', 'Batu Ampar', '087798347590', '2171905983798457', '200000', 'A'),
(2, '052A', 'Andi', 'Sengkuang', '081295827598', '2171023758297395', '0', 'A');

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
  `minimal_saldo` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblaturan`
--

INSERT INTO `tblaturan` (`id`, `simpanan_pokok`, `simpanan_wajib`, `simpanan_sukarela`, `denda`, `maksimal_peminjaman`, `minimal_saldo`) VALUES
(0, 200000, 100000, 0, 10, 3, 200000);

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

--
-- Dumping data for table `tblpembayaran`
--

INSERT INTO `tblpembayaran` (`id`, `tanggal`, `kode_pinjaman`, `kode_anggota`, `nama_anggota`, `bayar`, `tgl`, `bln`, `thn`) VALUES
(1000000001, '10/12/2018', 40001, '051A', 'Budi', 42917, '10', '12', '2018'),
(1000000002, '11/01/2019', 40001, '051A', 'Budi', 47209, '11', '01', '2019');

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

--
-- Dumping data for table `tblpengambilan`
--

INSERT INTO `tblpengambilan` (`id`, `tanggal`, `kode_anggota`, `nama_anggota`, `jumlah`, `tgl`, `bln`, `thn`) VALUES
(1000000001, '10/12/2018', '051A', 'Budi', '100000', '10', '12', '2018');

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

--
-- Dumping data for table `tblpinjaman`
--

INSERT INTO `tblpinjaman` (`id`, `tanggal`, `kode_anggota`, `nama_anggota`, `bunga`, `lama_cicilan`, `jumlah`, `angsuran`, `telah_dibayar`, `total_dibayar`, `status`, `tempo`, `tgl`, `bln`, `thn`) VALUES
(40001, '10/12/2018', '051A', 'Budi', '3', '12', 500000, 42917, 85834, 515004, 'Belum Lunas', '10', '10', '12', '2018');

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
  `tgl` varchar(2) NOT NULL,
  `bln` varchar(2) NOT NULL,
  `thn` varchar(4) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=1000000024 ;

--
-- Dumping data for table `tblsimpanan`
--

INSERT INTO `tblsimpanan` (`id`, `tanggal`, `kode_anggota`, `nama_anggota`, `jenis_simpanan`, `jumlah`, `tgl`, `bln`, `thn`) VALUES
(1000000001, '10/12/2018', '051A', 'Budi', 'Pokok', 200000, '10', '12', '2018'),
(1000000002, '10/12/2018', '051A', 'Budi', 'Wajib', 100000, '10', '12', '2018');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE IF NOT EXISTS `tbluser` (
`id` int(11) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `username` varchar(16) NOT NULL,
  `password` varchar(16) NOT NULL
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`id`, `nama`, `username`, `password`) VALUES
(1, 'Admin', 'admin', 'admin');

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
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `tblsimpanan`
--
ALTER TABLE `tblsimpanan`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=1000000024;
--
-- AUTO_INCREMENT for table `tbluser`
--
ALTER TABLE `tbluser`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
