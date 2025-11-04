# Setup AI para iRacing 🏁

Proyecto educativo para construir una aplicación que analiza telemetría de iRacing y genera recomendaciones de setup usando inteligencia artificial. Cada línea de código es escrita manualmente para aprender a fondo, guiado paso a paso con explicaciones detalladas.

## 🎯 Objetivo

Crear un MVP funcional, modular y escalable que reciba datos de telemetría, los analice, y sugiera ajustes de setup para mejorar el rendimiento en pista.

## 🧱 Estructura del proyecto

SetupAI-iRacing/
├── Backend/ │
              ├── Models/ │ 
              ├── Controllers/ │ 
              ├── Services/ │ 
              └── SetupAI.API.csproj
├── Frontend/ 
├── TelemetrySamples/ 
              │ └── sample1.json 
├── README.md 
└── .gitignore


## 🔧 Tecnologías utilizadas

- C# / .NET 8
- ASP.NET Core Web API
- Blazor (o HTML + JavaScript)
- Azure OpenAI (fase 2)
- Azure App Service (fase 2)
- GitHub Actions (CI/CD)

## 🧪 Telemetría simulada

Datos incluidos:
- Nombre de pista
- Modelo de coche
- Tiempo de vuelta
- Velocidad promedio
- Presión de neumáticos

## 🧠 Flujo de desarrollo

1. Crear modelo `TelemetryData.cs`
2. Simular almacenamiento con `TelemetryStore.cs`
3. Construir controlador `TelemetryController.cs`
4. Crear archivo JSON de ejemplo
5. Construir frontend mínimo
6. Testear funcionalidad local
7. Integrar AI (fase 2)
8. Migrar a Azure (fase 2)

## 🚀 Estado actual

✅ Repositorio creado  
🔜 Backend desde cero  
🔜 Modelo `TelemetryData.cs`  
🔜 Simulación de telemetría  
🔜 Frontend mínimo  
🔜 Integración AI y despliegue

---

Este proyecto forma parte de mi formación como software engineer en WGU y Microsoft MSSA. Cada componente está diseñado para aprender, mejorar y compartir conocimiento técnico.
