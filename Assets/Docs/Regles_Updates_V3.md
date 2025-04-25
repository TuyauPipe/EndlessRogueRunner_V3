# 📖 Règles & Updates – Endless Rogue Runner V3

## 🔹 Règles de Dev de Base
- Unity 2022.3 LTS, 2D Core Template, Built-in RP.
- Structure de dossiers obligatoire (`Assets/`, `Scripts/`, `Prefabs/`, `Scenes/`, `UI/`, `Relics/`, `ThirdParty/`).
- FEEL et DOTween utilisés avec parcimonie pour préserver la performance mobile.
- Pas de "God Object" : managers spécialisés (ex : `RunStatsManager`, `MetaProgressionManager`).
- Git obligatoire :
  - `git add .`
  - `git commit -m "message clair"`
  - `git push`
- Sauvegarder à chaque :
  - Fin d'une fonctionnalité majeure
  - Correction critique
  - Ajout d'assets/dossiers
  - Réorganisation de projet

## 🔹 Modifications de Gameplay (V3)
- Runner horizontal automatique.
- Durée cible d'une run : 3 à 7 minutes.
- Revive autorisé via pub vidéo **1 seule fois par run**.
- Système de reliques modulaires avec ScriptableObject et interface `IRelicEffect`.
- Séparation du ScoreManager :
  - `RunStatsManager` : gère la run active.
  - `MetaProgressionManager` : gère les rubis, reliques débloquées.

## 🔹 Historique des Changements
- 2025-04-25 : Création du projet V3 propre, versionné sur Git.
- 2025-04-25 : Décision de limiter les revive à 1 / run.
- 2025-04-25 : Préparation de la séparation du ScoreManager.
