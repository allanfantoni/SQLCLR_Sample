-- ALTER DATABASE SQLCLRDB SET TRUSTWORTHY ON

-- Enable CLR
EXEC sp_configure 'show advanced options', 1;
RECONFIGURE;
EXEC sp_configure 'clr enabled', 1;
RECONFIGURE;

-- CLR status
SELECT name, value_in_use
FROM sys.configurations
WHERE name = 'clr enabled';

-- Running a CLR function
SELECT dbo.fncCalcula_Idade('1988-09-22', GETDATE())

SELECT dbo.fncArquivo_Existe('D:\Projects\SQLCLR_Sample\README.md')