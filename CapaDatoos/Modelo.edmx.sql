
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/24/2018 19:24:33
-- Generated from EDMX file: C:\Users\Estudiante\Source\Repos\Etramul\CapaDatoos\Modelo.edmx
-- --------------------------------------------------
CREATE DATABASE Etramulv2;
go

SET QUOTED_IDENTIFIER OFF;
GO
USE [Etramulv2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PersonasUsuarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuariosSet] DROP CONSTRAINT [FK_PersonasUsuarios];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonasConductor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ConductorSet] DROP CONSTRAINT [FK_PersonasConductor];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonasSocio]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SocioSet] DROP CONSTRAINT [FK_PersonasSocio];
GO
IF OBJECT_ID(N'[dbo].[FK_VehiculoCarrera]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarreraSet] DROP CONSTRAINT [FK_VehiculoCarrera];
GO
IF OBJECT_ID(N'[dbo].[FK_VehiculoTransaccion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TransaccionSet] DROP CONSTRAINT [FK_VehiculoTransaccion];
GO
IF OBJECT_ID(N'[dbo].[FK_SocioVehiculo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[VehiculoSet] DROP CONSTRAINT [FK_SocioVehiculo];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoUsuarioUsuarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UsuariosSet] DROP CONSTRAINT [FK_TipoUsuarioUsuarios];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoEgresoEgreso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleSet] DROP CONSTRAINT [FK_TipoEgresoEgreso];
GO
IF OBJECT_ID(N'[dbo].[FK_TransaccionEgreso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleSet] DROP CONSTRAINT [FK_TransaccionEgreso];
GO
IF OBJECT_ID(N'[dbo].[FK_ConductorCarrera]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarreraSet] DROP CONSTRAINT [FK_ConductorCarrera];
GO
IF OBJECT_ID(N'[dbo].[FK_DetalleAbono]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AbonoSet] DROP CONSTRAINT [FK_DetalleAbono];
GO
IF OBJECT_ID(N'[dbo].[FK_DetalleSaldo_detalle]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Saldo_detalleSet] DROP CONSTRAINT [FK_DetalleSaldo_detalle];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PersonasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonasSet];
GO
IF OBJECT_ID(N'[dbo].[UsuariosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsuariosSet];
GO
IF OBJECT_ID(N'[dbo].[ConductorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ConductorSet];
GO
IF OBJECT_ID(N'[dbo].[SocioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SocioSet];
GO
IF OBJECT_ID(N'[dbo].[VehiculoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[VehiculoSet];
GO
IF OBJECT_ID(N'[dbo].[TipoUsuarioSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoUsuarioSet];
GO
IF OBJECT_ID(N'[dbo].[TransaccionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TransaccionSet];
GO
IF OBJECT_ID(N'[dbo].[DetalleSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalleSet];
GO
IF OBJECT_ID(N'[dbo].[TipoDetalleSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoDetalleSet];
GO
IF OBJECT_ID(N'[dbo].[CarreraSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarreraSet];
GO
IF OBJECT_ID(N'[dbo].[AbonoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AbonoSet];
GO
IF OBJECT_ID(N'[dbo].[Saldo_detalleSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Saldo_detalleSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PersonasSet'
CREATE TABLE [dbo].[PersonasSet] (
    [Id_persona] int IDENTITY(1,1) NOT NULL,
    [Identificacion] nvarchar(max)  NOT NULL,
    [Nombres] nvarchar(max)  NOT NULL,
    [Apellidos] nvarchar(max)  NOT NULL,
    [Direccion] nvarchar(max)  NOT NULL,
    [Telefono] nvarchar(max)  NOT NULL,
    [Correo] nvarchar(max)  NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'UsuariosSet'
CREATE TABLE [dbo].[UsuariosSet] (
    [Id_usuario] int  NOT NULL,
    [Nickname] nvarchar(max)  NOT NULL,
    [Clave] nvarchar(max)  NOT NULL,
    [Id_tipo] int  NOT NULL,
    [Personas_Id_persona] int  NOT NULL
);
GO

-- Creating table 'ConductorSet'
CREATE TABLE [dbo].[ConductorSet] (
    [Id_conductor] int  NOT NULL,
    [Licencia] nvarchar(max)  NOT NULL,
    [Personas_Id_persona] int  NOT NULL
);
GO

-- Creating table 'SocioSet'
CREATE TABLE [dbo].[SocioSet] (
    [Id_socio] int  NOT NULL,
    [FechaAsociacion] datetime  NOT NULL,
    [Personas_Id_persona] int  NOT NULL
);
GO

-- Creating table 'VehiculoSet'
CREATE TABLE [dbo].[VehiculoSet] (
    [Id_Vehiculo] int IDENTITY(1,1) NOT NULL,
    [Placa] nvarchar(max)  NOT NULL,
    [Marca] nvarchar(max)  NOT NULL,
    [Modelo] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL,
    [Id_socio] int  NOT NULL
);
GO

-- Creating table 'TipoUsuarioSet'
CREATE TABLE [dbo].[TipoUsuarioSet] (
    [Id_tipo] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TransaccionSet'
CREATE TABLE [dbo].[TransaccionSet] (
    [IdTransaccion] int IDENTITY(1,1) NOT NULL,
    [Id_usuario] int  NOT NULL,
    [Id_Vehiculo] int  NOT NULL,
    [FechaTransaccion] datetime  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'DetalleSet'
CREATE TABLE [dbo].[DetalleSet] (
    [IdDetalle] int IDENTITY(1,1) NOT NULL,
    [IdTransaccion] int  NOT NULL,
    [TipoDetalle] int  NOT NULL,
    [TipoTransaccion] int  NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Cantidad] decimal(18,0)  NOT NULL,
    [Activo] bit  NOT NULL,
    [Cancelado] bit  NOT NULL
);
GO

-- Creating table 'TipoDetalleSet'
CREATE TABLE [dbo].[TipoDetalleSet] (
    [IdTipoDetalle] int IDENTITY(1,1) NOT NULL,
    [Descripcion] nvarchar(max)  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'CarreraSet'
CREATE TABLE [dbo].[CarreraSet] (
    [Id_carrera] int IDENTITY(1,1) NOT NULL,
    [Id_conductor] int  NOT NULL,
    [Id_vehiculo] int  NOT NULL,
    [No_transaccion] int  NOT NULL,
    [HoraSalida] time  NOT NULL,
    [HoraLlegada] time  NOT NULL,
    [FechaCarrera] datetime  NOT NULL,
    [Vuelta_Completa] bit  NOT NULL,
    [Activo] bit  NOT NULL
);
GO

-- Creating table 'AbonoSet'
CREATE TABLE [dbo].[AbonoSet] (
    [Id_abono] int IDENTITY(1,1) NOT NULL,
    [Id_transaccion] int  NOT NULL,
    [id_detalle] int  NOT NULL,
    [Monto] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'Saldo_detalleSet'
CREATE TABLE [dbo].[Saldo_detalleSet] (
    [Id_saldo] int IDENTITY(1,1) NOT NULL,
    [id_detalle] int  NOT NULL,
    [Saldo] decimal(18,0)  NOT NULL,
    [Detalle_IdDetalle] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_persona] in table 'PersonasSet'
ALTER TABLE [dbo].[PersonasSet]
ADD CONSTRAINT [PK_PersonasSet]
    PRIMARY KEY CLUSTERED ([Id_persona] ASC);
GO

-- Creating primary key on [Id_usuario] in table 'UsuariosSet'
ALTER TABLE [dbo].[UsuariosSet]
ADD CONSTRAINT [PK_UsuariosSet]
    PRIMARY KEY CLUSTERED ([Id_usuario] ASC);
GO

-- Creating primary key on [Id_conductor] in table 'ConductorSet'
ALTER TABLE [dbo].[ConductorSet]
ADD CONSTRAINT [PK_ConductorSet]
    PRIMARY KEY CLUSTERED ([Id_conductor] ASC);
GO

-- Creating primary key on [Id_socio] in table 'SocioSet'
ALTER TABLE [dbo].[SocioSet]
ADD CONSTRAINT [PK_SocioSet]
    PRIMARY KEY CLUSTERED ([Id_socio] ASC);
GO

-- Creating primary key on [Id_Vehiculo] in table 'VehiculoSet'
ALTER TABLE [dbo].[VehiculoSet]
ADD CONSTRAINT [PK_VehiculoSet]
    PRIMARY KEY CLUSTERED ([Id_Vehiculo] ASC);
GO

-- Creating primary key on [Id_tipo] in table 'TipoUsuarioSet'
ALTER TABLE [dbo].[TipoUsuarioSet]
ADD CONSTRAINT [PK_TipoUsuarioSet]
    PRIMARY KEY CLUSTERED ([Id_tipo] ASC);
GO

-- Creating primary key on [IdTransaccion] in table 'TransaccionSet'
ALTER TABLE [dbo].[TransaccionSet]
ADD CONSTRAINT [PK_TransaccionSet]
    PRIMARY KEY CLUSTERED ([IdTransaccion] ASC);
GO

-- Creating primary key on [IdDetalle] in table 'DetalleSet'
ALTER TABLE [dbo].[DetalleSet]
ADD CONSTRAINT [PK_DetalleSet]
    PRIMARY KEY CLUSTERED ([IdDetalle] ASC);
GO

-- Creating primary key on [IdTipoDetalle] in table 'TipoDetalleSet'
ALTER TABLE [dbo].[TipoDetalleSet]
ADD CONSTRAINT [PK_TipoDetalleSet]
    PRIMARY KEY CLUSTERED ([IdTipoDetalle] ASC);
GO

-- Creating primary key on [Id_carrera] in table 'CarreraSet'
ALTER TABLE [dbo].[CarreraSet]
ADD CONSTRAINT [PK_CarreraSet]
    PRIMARY KEY CLUSTERED ([Id_carrera] ASC);
GO

-- Creating primary key on [Id_abono] in table 'AbonoSet'
ALTER TABLE [dbo].[AbonoSet]
ADD CONSTRAINT [PK_AbonoSet]
    PRIMARY KEY CLUSTERED ([Id_abono] ASC);
GO

-- Creating primary key on [Id_saldo] in table 'Saldo_detalleSet'
ALTER TABLE [dbo].[Saldo_detalleSet]
ADD CONSTRAINT [PK_Saldo_detalleSet]
    PRIMARY KEY CLUSTERED ([Id_saldo] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Personas_Id_persona] in table 'UsuariosSet'
ALTER TABLE [dbo].[UsuariosSet]
ADD CONSTRAINT [FK_PersonasUsuarios]
    FOREIGN KEY ([Personas_Id_persona])
    REFERENCES [dbo].[PersonasSet]
        ([Id_persona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonasUsuarios'
CREATE INDEX [IX_FK_PersonasUsuarios]
ON [dbo].[UsuariosSet]
    ([Personas_Id_persona]);
GO

-- Creating foreign key on [Personas_Id_persona] in table 'ConductorSet'
ALTER TABLE [dbo].[ConductorSet]
ADD CONSTRAINT [FK_PersonasConductor]
    FOREIGN KEY ([Personas_Id_persona])
    REFERENCES [dbo].[PersonasSet]
        ([Id_persona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonasConductor'
CREATE INDEX [IX_FK_PersonasConductor]
ON [dbo].[ConductorSet]
    ([Personas_Id_persona]);
GO

-- Creating foreign key on [Personas_Id_persona] in table 'SocioSet'
ALTER TABLE [dbo].[SocioSet]
ADD CONSTRAINT [FK_PersonasSocio]
    FOREIGN KEY ([Personas_Id_persona])
    REFERENCES [dbo].[PersonasSet]
        ([Id_persona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonasSocio'
CREATE INDEX [IX_FK_PersonasSocio]
ON [dbo].[SocioSet]
    ([Personas_Id_persona]);
GO

-- Creating foreign key on [Id_vehiculo] in table 'CarreraSet'
ALTER TABLE [dbo].[CarreraSet]
ADD CONSTRAINT [FK_VehiculoCarrera]
    FOREIGN KEY ([Id_vehiculo])
    REFERENCES [dbo].[VehiculoSet]
        ([Id_Vehiculo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VehiculoCarrera'
CREATE INDEX [IX_FK_VehiculoCarrera]
ON [dbo].[CarreraSet]
    ([Id_vehiculo]);
GO

-- Creating foreign key on [Id_Vehiculo] in table 'TransaccionSet'
ALTER TABLE [dbo].[TransaccionSet]
ADD CONSTRAINT [FK_VehiculoTransaccion]
    FOREIGN KEY ([Id_Vehiculo])
    REFERENCES [dbo].[VehiculoSet]
        ([Id_Vehiculo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VehiculoTransaccion'
CREATE INDEX [IX_FK_VehiculoTransaccion]
ON [dbo].[TransaccionSet]
    ([Id_Vehiculo]);
GO

-- Creating foreign key on [Id_socio] in table 'VehiculoSet'
ALTER TABLE [dbo].[VehiculoSet]
ADD CONSTRAINT [FK_SocioVehiculo]
    FOREIGN KEY ([Id_socio])
    REFERENCES [dbo].[SocioSet]
        ([Id_socio])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SocioVehiculo'
CREATE INDEX [IX_FK_SocioVehiculo]
ON [dbo].[VehiculoSet]
    ([Id_socio]);
GO

-- Creating foreign key on [Id_tipo] in table 'UsuariosSet'
ALTER TABLE [dbo].[UsuariosSet]
ADD CONSTRAINT [FK_TipoUsuarioUsuarios]
    FOREIGN KEY ([Id_tipo])
    REFERENCES [dbo].[TipoUsuarioSet]
        ([Id_tipo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoUsuarioUsuarios'
CREATE INDEX [IX_FK_TipoUsuarioUsuarios]
ON [dbo].[UsuariosSet]
    ([Id_tipo]);
GO

-- Creating foreign key on [TipoDetalle] in table 'DetalleSet'
ALTER TABLE [dbo].[DetalleSet]
ADD CONSTRAINT [FK_TipoEgresoEgreso]
    FOREIGN KEY ([TipoDetalle])
    REFERENCES [dbo].[TipoDetalleSet]
        ([IdTipoDetalle])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoEgresoEgreso'
CREATE INDEX [IX_FK_TipoEgresoEgreso]
ON [dbo].[DetalleSet]
    ([TipoDetalle]);
GO

-- Creating foreign key on [IdTransaccion] in table 'DetalleSet'
ALTER TABLE [dbo].[DetalleSet]
ADD CONSTRAINT [FK_TransaccionEgreso]
    FOREIGN KEY ([IdTransaccion])
    REFERENCES [dbo].[TransaccionSet]
        ([IdTransaccion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransaccionEgreso'
CREATE INDEX [IX_FK_TransaccionEgreso]
ON [dbo].[DetalleSet]
    ([IdTransaccion]);
GO

-- Creating foreign key on [Id_conductor] in table 'CarreraSet'
ALTER TABLE [dbo].[CarreraSet]
ADD CONSTRAINT [FK_ConductorCarrera]
    FOREIGN KEY ([Id_conductor])
    REFERENCES [dbo].[ConductorSet]
        ([Id_conductor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConductorCarrera'
CREATE INDEX [IX_FK_ConductorCarrera]
ON [dbo].[CarreraSet]
    ([Id_conductor]);
GO

-- Creating foreign key on [id_detalle] in table 'AbonoSet'
ALTER TABLE [dbo].[AbonoSet]
ADD CONSTRAINT [FK_DetalleAbono]
    FOREIGN KEY ([id_detalle])
    REFERENCES [dbo].[DetalleSet]
        ([IdDetalle])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetalleAbono'
CREATE INDEX [IX_FK_DetalleAbono]
ON [dbo].[AbonoSet]
    ([id_detalle]);
GO

-- Creating foreign key on [Detalle_IdDetalle] in table 'Saldo_detalleSet'
ALTER TABLE [dbo].[Saldo_detalleSet]
ADD CONSTRAINT [FK_DetalleSaldo_detalle]
    FOREIGN KEY ([Detalle_IdDetalle])
    REFERENCES [dbo].[DetalleSet]
        ([IdDetalle])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetalleSaldo_detalle'
CREATE INDEX [IX_FK_DetalleSaldo_detalle]
ON [dbo].[Saldo_detalleSet]
    ([Detalle_IdDetalle]);
GO

-- Creating foreign key on [Id_transaccion] in table 'AbonoSet'
ALTER TABLE [dbo].[AbonoSet]
ADD CONSTRAINT [FK_TransaccionAbono]
    FOREIGN KEY ([Id_transaccion])
    REFERENCES [dbo].[TransaccionSet]
        ([IdTransaccion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransaccionAbono'
CREATE INDEX [IX_FK_TransaccionAbono]
ON [dbo].[AbonoSet]
    ([Id_transaccion]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------