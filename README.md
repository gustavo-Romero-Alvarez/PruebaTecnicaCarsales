# API .NET 8 — Proyecto Resumido

Esta es una API desarrollada con **.NET 8**, arquitectura limpia (**Clean Architecture**) y C#. Expone endpoints para obtener episodios, personajes y ubicaciones utilizando un servicio interno.

---

## 🚀 Endpoints Principales

Controlador: **EpisodesController**
Ruta base: `api/episodes`

### ▶️ Obtener episodios

```
GET /api/episodes?page={num}
```

Devuelve episodios paginados.

### ▶️ Obtener personajes

```
GET /api/episodes/characters?page={num}&name={texto}&status={texto}
```

Permite filtrar por página, nombre y estado.

### ▶️ Obtener ubicaciones

```
GET /api/episodes/locations?page={num}
```

Devuelve ubicaciones paginadas.

---

## 📂 Arquitectura

Se utiliza **Clean Architecture**, separada en:

* **API:** Controladores, configuración.
* **Application:** Interfaces, lógica de aplicación.
* **Domain:** Entidades básicas.
* **Infrastructure:** Implementaciones de servicios externos.

---

## ▶️ Ejecución

1. Restaurar dependencias:

```bash
dotnet restore
```

2. Ejecutar API:

```bash
dotnet run --project API
```

La API se inicia típicamente en:

```
https://localhost:7297
```

---

## 🧩 Tecnologías

* .NET 8
* C#
* Clean Architecture
* Inyección de dependencias
* Swagger (si está configurado)

---

## 🧑‍💻 Autor

**Gustavo Romero**
