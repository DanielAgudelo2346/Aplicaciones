-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 14-01-2019 a las 20:47:34
-- Versión del servidor: 10.1.37-MariaDB
-- Versión de PHP: 7.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `programaprueba`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbcitas`
--

CREATE TABLE `tbcitas` (
  `Numerocita` int(20) NOT NULL,
  `IdentificacionPaciente` varchar(100) NOT NULL,
  `NombreMedico` varchar(100) NOT NULL,
  `EspecialidadMedico` varchar(100) NOT NULL,
  `DiaCita` date NOT NULL,
  `Hora` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbcitas`
--

INSERT INTO `tbcitas` (`Numerocita`, `IdentificacionPaciente`, `NombreMedico`, `EspecialidadMedico`, `DiaCita`, `Hora`) VALUES
(1, '657', '657', '657', '2019-01-23', 'gytu'),
(2, '5432', 'Luisa Sarmiento', 'Pediatría', '2019-01-11', '05:00'),
(3, '5432', 'Luisa Sarmiento', 'Pediatría', '2019-01-20', '04:00'),
(4, '5432', 'Luisa Sarmiento', 'Pediatría', '2019-01-13', '06:00'),
(5, '5432', 'Luisa Sarmiento', 'Pediatría', '2019-01-19', '12:30'),
(6, '5432', 'Luisa Sarmiento', 'Pediatría', '2019-01-12', '12:30'),
(7, '5432', 'Luisa Sarmiento', 'Pediatría', '2019-01-12', '12:30'),
(8, '5432', 'Luisa Sarmiento', 'Pediatría', '2019-01-12', '12:30'),
(9, '5432', 'Luisa Sarmiento', 'Pediatría', '2019-01-14', '04:00'),
(10, '5432', 'Luisa Sarmiento', 'Pediatría', '2019-01-13', '07:30'),
(11, '5432', 'Sara Camargo', 'Odontología', '2019-01-12', '04:00'),
(12, '5432', 'Sara Camargo', 'Odontología', '2019-01-19', '04:00'),
(13, '5432', 'Sara Camargo', 'Odontología', '2019-01-19', '03:00'),
(14, '5432', 'raul rodriguez', 'Oftamología', '2019-01-19', '06:30'),
(19, '5432', 'Erick Perez', 'Ginecología', '2019-01-18', '04:00'),
(20, '5432', 'Erick Perez', 'Ginecología', '2019-01-19', '04:00'),
(21, '5432', 'Erick Perez', 'Ginecología', '2019-01-14', '04:30'),
(22, '5432', 'Erick Perez', 'Ginecología', '2019-04-19', '12:30'),
(23, '5432', 'Erick Perez', 'Ginecología', '2019-04-19', '11:30'),
(24, '1234', 'laura borges', 'Hematología', '2019-01-19', '07:00'),
(25, '1234', 'gustavo daza', 'Hematología', '2019-01-13', '13:30'),
(26, '1234', 'gustavo daza', 'Hematología', '2019-01-13', '12:30');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbmedicos`
--

CREATE TABLE `tbmedicos` (
  `Identificacion` varchar(100) NOT NULL,
  `NombreCompleto` varchar(100) NOT NULL,
  `TipoIdentificacion` varchar(100) NOT NULL,
  `NumTarjetaProf` varchar(100) NOT NULL,
  `AniosExp` decimal(10,1) NOT NULL,
  `Especialidad` varchar(100) NOT NULL,
  `HoraInicio` varchar(100) NOT NULL,
  `HoraFin` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbmedicos`
--

INSERT INTO `tbmedicos` (`Identificacion`, `NombreCompleto`, `TipoIdentificacion`, `NumTarjetaProf`, `AniosExp`, `Especialidad`, `HoraInicio`, `HoraFin`) VALUES
('234234', 'Sara Camargo', 'Cédula de ciudadanía', '234324', '5.0', 'Odontología', '03:00', '06:00'),
('4343', 'Luisa Sarmiento', 'Cédula de ciudadanía', '545445', '1.3', 'Pediatría', '04:00', '15:00'),
('435435', 'laura borges', 'Número de pasaporte', '3454656', '11.0', 'Hematología', '02:00', '11:00'),
('4535435', 'pedro forero', 'Número de pasaporte', '43543534', '23.0', 'Pediatría', '04:00', '15:00'),
('45654', 'gustavo daza', 'Cédula de ciudadanía', '9789879', '7.0', 'Hematología', '07:00', '20:00'),
('54654', 'raul rodriguez', 'Cédula de ciudadanía', '56757', '9.9', 'Oftamología', '04:00', '20:00'),
('564', 'Hector Carreño', 'Cédula de ciudadanía', '98789', '5.8', 'Medicina General', '07:00', '13:00'),
('879789', 'Erick Perez', 'Cédula de ciudadanía', '5476657', '7.0', 'Ginecología', '02:00', '15:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbpacientes`
--

CREATE TABLE `tbpacientes` (
  `Identificacion` varchar(100) NOT NULL,
  `TipoIdentificacion` varchar(100) NOT NULL,
  `NombreCompleto` varchar(100) NOT NULL,
  `FechaNacimiento` date NOT NULL,
  `Eps` varchar(100) NOT NULL,
  `HistoriaClinica` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbpacientes`
--

INSERT INTO `tbpacientes` (`Identificacion`, `TipoIdentificacion`, `NombreCompleto`, `FechaNacimiento`, `Eps`, `HistoriaClinica`) VALUES
('1234', 'Cédula de ciudadanía', 'luis coraje', '2019-01-08', 'Famisanar', 'Cuadro De Rinitis'),
('5432', 'Cédula de ciudadanía', 'ariel galindo', '2019-01-08', 'Sanitas', 'Cuidados Intensivos');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `tbcitas`
--
ALTER TABLE `tbcitas`
  ADD PRIMARY KEY (`Numerocita`);

--
-- Indices de la tabla `tbmedicos`
--
ALTER TABLE `tbmedicos`
  ADD PRIMARY KEY (`Identificacion`);

--
-- Indices de la tabla `tbpacientes`
--
ALTER TABLE `tbpacientes`
  ADD PRIMARY KEY (`Identificacion`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `tbcitas`
--
ALTER TABLE `tbcitas`
  MODIFY `Numerocita` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
