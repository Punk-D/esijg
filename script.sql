USE [master]
GO
/****** Object:  Database [esi]    Script Date: 20.11.2024 1:19:05 ******/
CREATE DATABASE [esi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'esi', FILENAME = N'C:\Users\Doctor\esi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'esi_log', FILENAME = N'C:\Users\Doctor\esi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [esi] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [esi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [esi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [esi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [esi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [esi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [esi] SET ARITHABORT OFF 
GO
ALTER DATABASE [esi] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [esi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [esi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [esi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [esi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [esi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [esi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [esi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [esi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [esi] SET  ENABLE_BROKER 
GO
ALTER DATABASE [esi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [esi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [esi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [esi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [esi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [esi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [esi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [esi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [esi] SET  MULTI_USER 
GO
ALTER DATABASE [esi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [esi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [esi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [esi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [esi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [esi] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [esi] SET QUERY_STORE = OFF
GO
USE [esi]
GO
/****** Object:  Table [dbo].[Elevi]    Script Date: 20.11.2024 1:19:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Elevi](
	[ID_Elev] [int] NOT NULL,
	[Nume] [nvarchar](20) NOT NULL,
	[Prenume] [nvarchar](20) NOT NULL,
	[ID_Grupa] [int] NOT NULL,
	[Anul_Nasterii] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Elev] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grupe]    Script Date: 20.11.2024 1:19:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grupe](
	[ID_Grupa] [int] NOT NULL,
	[An_de_Studii] [int] NOT NULL,
	[Specialitate] [nvarchar](100) NOT NULL,
	[ID_Profesor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Grupa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Note]    Script Date: 20.11.2024 1:19:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Note](
	[ID_Nota] [int] NOT NULL,
	[ID_Elev] [int] NOT NULL,
	[ID_Obiect] [int] NOT NULL,
	[ID_Profesor] [int] NOT NULL,
	[Nota] [float] NOT NULL,
	[Data_Notarii] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Nota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Obiecte]    Script Date: 20.11.2024 1:19:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Obiecte](
	[ID_Obiect] [int] NOT NULL,
	[Denumire] [nvarchar](100) NOT NULL,
	[ID_Profesor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Obiect] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesori]    Script Date: 20.11.2024 1:19:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesori](
	[ID_Profesor] [int] NOT NULL,
	[Nume] [nvarchar](20) NOT NULL,
	[Prenume] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Profesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Elevi]  WITH CHECK ADD FOREIGN KEY([ID_Grupa])
REFERENCES [dbo].[Grupe] ([ID_Grupa])
GO
ALTER TABLE [dbo].[Grupe]  WITH CHECK ADD FOREIGN KEY([ID_Profesor])
REFERENCES [dbo].[Profesori] ([ID_Profesor])
GO
ALTER TABLE [dbo].[Note]  WITH CHECK ADD FOREIGN KEY([ID_Elev])
REFERENCES [dbo].[Elevi] ([ID_Elev])
GO
ALTER TABLE [dbo].[Note]  WITH CHECK ADD FOREIGN KEY([ID_Obiect])
REFERENCES [dbo].[Obiecte] ([ID_Obiect])
GO
ALTER TABLE [dbo].[Note]  WITH CHECK ADD FOREIGN KEY([ID_Profesor])
REFERENCES [dbo].[Profesori] ([ID_Profesor])
GO
ALTER TABLE [dbo].[Obiecte]  WITH CHECK ADD FOREIGN KEY([ID_Profesor])
REFERENCES [dbo].[Profesori] ([ID_Profesor])
GO
ALTER TABLE [dbo].[Note]  WITH CHECK ADD CHECK  (([Nota]>=(1.0) AND [Nota]<=(10.0)))
GO
/****** Object:  StoredProcedure [dbo].[GetCollegeAverage]    Script Date: 20.11.2024 1:19:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCollegeAverage]
AS
BEGIN
    SELECT AVG(GradeAverage) AS CollegeAverage
    FROM (
        SELECT AVG(N.Nota) AS GradeAverage
        FROM Note AS N
        GROUP BY N.ID_Obiect
    ) AS SubQuery;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetGroupAverage]    Script Date: 20.11.2024 1:19:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetGroupAverage]
    @GroupID INT
AS
BEGIN
    SELECT AVG(GradeAverage) AS GroupAverage
    FROM (
        SELECT AVG(N.Nota) AS GradeAverage
        FROM Note AS N
        INNER JOIN Elevi AS E ON N.ID_Elev = E.ID_Elev
        WHERE E.ID_Grupa = @GroupID
        GROUP BY N.ID_Obiect
    ) AS SubQuery;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetStudentAverage]    Script Date: 20.11.2024 1:19:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetStudentAverage]
    @StudentID INT
AS
BEGIN
    SELECT AVG(GradeAverage) AS PersonalAverage
    FROM (
        SELECT AVG(N.Nota) AS GradeAverage
        FROM Note AS N
        INNER JOIN Elevi AS E ON N.ID_Elev = E.ID_Elev
        INNER JOIN Grupe AS G ON E.ID_Grupa = G.ID_Grupa
        WHERE E.ID_Elev = @StudentID
        GROUP BY N.ID_Obiect
    ) AS SubQuery;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetYearAverage]    Script Date: 20.11.2024 1:19:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetYearAverage]
    @Year INT
AS
BEGIN
    SELECT AVG(GradeAverage) AS YearAverage
    FROM (
        SELECT AVG(N.Nota) AS GradeAverage
        FROM Note AS N
        INNER JOIN Elevi AS E ON N.ID_Elev = E.ID_Elev
        INNER JOIN Grupe AS G ON E.ID_Grupa = G.ID_Grupa
        WHERE G.An_de_studii = @Year
        GROUP BY N.ID_Obiect
    ) AS SubQuery;
END;
GO
USE [master]
GO
ALTER DATABASE [esi] SET  READ_WRITE 
GO
