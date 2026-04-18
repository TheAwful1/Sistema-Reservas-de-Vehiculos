# 🚗 Sistema de Reservas de Vehículos

Aplicación web desarrollada con **ASP.NET Core MVC** y **SQL Server** para la gestión de usuarios, vehículos y reservas, implementando lógica de negocio real como validación de fechas y cálculo automático de costos.

---

## 📸 Vista General

Sistema orientado a la gestión de reservas donde los usuarios pueden seleccionar vehículos disponibles y registrar períodos de uso sin conflictos de fechas.

---

## ⚙️ Funcionalidades

- 👤 Gestión de usuarios (CRUD)
- 🚘 Gestión de vehículos (CRUD)
- 📅 Creación de reservas
- ❌ Validación de fechas inválidas
- 🔁 Prevención de reservas solapadas
- 💰 Cálculo automático del precio total
- 📊 Visualización de reservas con datos relacionados

---

## 🧠 Lógica de Negocio

- Verificación de conflictos de fechas en reservas
- Cálculo dinámico del costo en base a días de uso
- Relaciones entre entidades (Usuario - Vehículo - Reserva)
- Uso de ViewModels para separar datos de presentación

---

## 🛠 Tecnologías

- ASP.NET Core MVC (.NET 8)
- Entity Framework Core
- SQL Server
- Razor Views

---

---

## 🚀 Cómo ejecutar

1. Clonar el repositorio

```bash
git clone https://github.com/TheAwful1/Sistema-Reservas-de-Vehiculos.git
```
---
## 🗄 Base de Datos

Ejecutar el script `Database.sql` en SQL Server para crear las tablas necesarias.
