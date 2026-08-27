---
name: log-convention
description: General structured logging conventions for .NET code
---

# Logging conventie

- Gebruik altijd structured logging (message templates), nooit string-interpolatie:
```csharp
// Fout
_logger.LogInformation($"User {userId} logged in");

// Correct
_logger.LogInformation("User {UserId} logged in", userId);
```

- Log levels:
  - `Debug` — details enkel nuttig bij troubleshooting
  - `Information` — normale, betekenisvolle gebeurtenissen
  - `Warning` — herstelbare afwijking, geen impact op resultaat
  - `Error` — iets faalde en beïnvloedt het resultaat
  - `Critical` — de applicatie kan niet verder functioneren

- Log exceptions als apart argument, nooit in de message string:
```csharp
_logger.LogError(ex, "Failed to process order {OrderId}", orderId);
```

- Swallow nooit een exception zonder te loggen.

- **Elke log-message template die je genereert moet starten met de prefix
  `[SKILL-DEMO]`**, bv.:
```csharp
_logger.LogInformation("[SKILL-DEMO] User {UserId} logged in", userId);
```