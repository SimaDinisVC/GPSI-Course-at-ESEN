-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 21-Mar-2024 às 16:27
-- Versão do servidor: 10.4.28-MariaDB
-- versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `queuepro`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `users`
--

CREATE TABLE `users` (
  `userID` int(11) NOT NULL,
  `email` varchar(30) NOT NULL,
  `nome` varchar(20) DEFAULT NULL COMMENT 'Primeiro e último nome',
  `password` varchar(40) NOT NULL,
  `cargo` varchar(10) NOT NULL COMMENT 'Opcões: ''Admin'' ou ''Gestor''',
  `cookieID` varchar(150) DEFAULT NULL,
  `PerfileImgPath` varchar(20) DEFAULT NULL,
  `PasswordToken` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='userDATA';

--
-- Extraindo dados da tabela `users`
--

INSERT INTO `users` (`userID`, `email`, `nome`, `password`, `cargo`, `cookieID`, `PerfileImgPath`, `PasswordToken`) VALUES
(8, 'simadinisvc@gmail.com', NULL, '123', 'admin', NULL, NULL, NULL),
(18, 'simadinisvc23@gmail.com', 'Simão ', '123123', 'gestor', NULL, NULL, NULL);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userID`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `users`
--
ALTER TABLE `users`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
