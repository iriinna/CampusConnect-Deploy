# CampusConnect - Ghid Complet de Deployment

## Cuprins
1. [Prezentare Generală](#prezentare-generală)
2. [Arhitectura de Deployment](#arhitectura-de-deployment)
3. [Environment-uri și Diferențe](#environment-uri-și-diferențe)
4. [Pas 1: Configurare Azure SQL Database](#pas-1-configurare-azure-sql-database)
5. [Pas 2: Configurare Render (Backend)](#pas-2-configurare-render-backend)
6. [Pas 3: Configurare Vercel (Frontend)](#pas-3-configurare-vercel-frontend)
7. [Pas 4: Configurare Finală și Testare](#pas-4-configurare-finală-și-testare)
8. [Troubleshooting](#troubleshooting)

---

## Prezentare Generală

### Stack Tehnologic
| Componentă | Tehnologie | Hosting |
|------------|------------|---------|
| Frontend | React + Vite + TypeScript | Vercel |
| Backend | ASP.NET Core 9.0 | Render (Docker) |
| Bază de date | SQL Server | Azure SQL Database |

### URL-uri Finale (după deploy)
- **Frontend Production:** `https://campusconnect-client.vercel.app`
- **Backend Production:** `https://campus-api.onrender.com`
- **API Documentation:** `https://campus-api.onrender.com/swagger`

---

## Arhitectura de Deployment

```
┌─────────────────────────────────────────────────────────────────┐
│                         PRODUCTION                               │
├─────────────────────────────────────────────────────────────────┤
│                                                                  │
│   ┌─────────────┐         ┌─────────────┐         ┌───────────┐ │
│   │   Vercel    │  HTTP   │   Render    │  SQL    │   Azure   │ │
│   │  (Frontend) │ ──────► │  (Backend)  │ ──────► │ SQL DB    │ │
│   │  React+Vite │         │  .NET API   │         │           │ │
│   └─────────────┘         └─────────────┘         └───────────┘ │
│                                                                  │
└─────────────────────────────────────────────────────────────────┘

┌─────────────────────────────────────────────────────────────────┐
│                         DEVELOPMENT                              │
├─────────────────────────────────────────────────────────────────┤
│                                                                  │
│   ┌─────────────┐         ┌─────────────┐         ┌───────────┐ │
│   │ localhost   │  Proxy  │ localhost   │  SQL    │ LocalDB   │ │
│   │    :5173    │ ──────► │    :5099    │ ──────► │ (mssql)   │ │
│   │  Vite Dev   │         │ dotnet run  │         │           │ │
│   └─────────────┘         └─────────────┘         └───────────┘ │
│                                                                  │
└─────────────────────────────────────────────────────────────────┘
```

---

## Environment-uri și Diferențe

### Comparație Development vs Production

| Aspect | Development | Production |
|--------|-------------|------------|
| **Frontend URL** | `http://localhost:5173` | `https://campusconnect-client.vercel.app` |
| **Backend URL** | `http://localhost:5099` | `https://campus-api.onrender.com` |
| **API URL (din frontend)** | `http://localhost:5099/api` | `https://campus-api.onrender.com/api` |
| **Bază de date** | LocalDB (SQL Server Express) | Azure SQL Database |
| **CORS** | AllowAll | AllowAll (poate fi restricționat) |
| **Swagger** | Activat | Activat |
| **Seed Data** | Da (date demo) | Nu |
| **Logging Level** | Information | Warning |
| **HTTPS** | Opțional | Obligatoriu |

### Fișiere de Configurare

#### Frontend

| Fișier | Scop | Când se folosește |
|--------|------|-------------------|
| `.env.development` | Configurare development | `npm run dev` |
| `.env.production` | Configurare production | `npm run build` |
| `vercel.json` | Configurare Vercel | Deploy automat |

**`.env.development`**
```env
VITE_API_URL=http://localhost:5099/api
```

**`.env.production`**
```env
VITE_API_URL=https://campus-api.onrender.com/api
```

#### Backend

| Fișier | Scop | Când se folosește |
|--------|------|-------------------|
| `appsettings.json` | Configurare de bază | Toate mediile |
| `appsettings.Development.json` | Override-uri development | `ASPNETCORE_ENVIRONMENT=Development` |
| `appsettings.Production.json` | Override-uri production | `ASPNETCORE_ENVIRONMENT=Production` |

### Environment Variables (Production)

Aceste variabile trebuie configurate în Render:

```bash
# Mediul ASP.NET
ASPNETCORE_ENVIRONMENT=Production

# Conexiune bază de date (de la Azure)
ConnectionStrings__DefaultConnection=Server=tcp:your-server.database.windows.net,1433;Initial Catalog=CampusConnectDb;Persist Security Info=False;User ID=your-username;Password=your-password;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;

# JWT (generează un secret unic de min 32 caractere)
JwtSettings__Secret=YourSuperSecretKeyThatIsAtLeast32CharactersLong!

# Email (Gmail App Password)
EmailSettings__Username=your-email@gmail.com
EmailSettings__Password=your-app-password

# Frontend URL (pentru CORS și email links)
AppSettings__FrontendUrl=https://campusconnect-client.vercel.app

# Gemini AI (opțional)
Gemini__ApiKey=your-gemini-api-key
```

---

## Pas 1: Configurare Azure SQL Database

### 1.1 Creare Cont Azure

1. Accesează [portal.azure.com](https://portal.azure.com)
2. Creează un cont nou (dacă nu ai) - oferă $200 credit gratuit pentru 30 zile
3. După autentificare, vei ajunge în Azure Portal

### 1.2 Creare Resource Group

1. În bara de căutare, tastează **"Resource groups"**
2. Click **"Create"**
3. Completează:
   - **Subscription:** Selectează subscription-ul tău
   - **Resource group:** `campusconnect-rg`
   - **Region:** `West Europe` (sau cea mai apropiată)
4. Click **"Review + create"** → **"Create"**

### 1.3 Creare SQL Server

1. În bara de căutare, tastează **"SQL servers"**
2. Click **"Create"**
3. Completează **Basics:**
   - **Resource group:** `campusconnect-rg`
   - **Server name:** `campusconnect-sql-server` (trebuie să fie unic global)
   - **Location:** `West Europe`
   - **Authentication method:** `Use SQL authentication`
   - **Server admin login:** `campusadmin`
   - **Password:** `<creează o parolă puternică>` (notează-o!)
4. Click **"Next: Networking"**
5. La **Firewall rules:**
   - **Allow Azure services and resources to access this server:** `Yes`
6. Click **"Review + create"** → **"Create"**

### 1.4 Creare Database

1. După ce serverul e creat, click pe el
2. În meniul din stânga, click **"SQL databases"**
3. Click **"Create database"**
4. Completează:
   - **Database name:** `CampusConnectDb`
   - **Want to use SQL elastic pool?:** `No`
   - **Workload environment:** `Development` (pentru cost mai mic)
5. La **Compute + storage**, click **"Configure database"**
   - Selectează **"Basic"** (5 DTUs) - cel mai ieftin, ~$5/lună
   - Sau **"Serverless"** pentru pay-per-use
6. Click **"Review + create"** → **"Create"**

### 1.5 Configurare Firewall

1. Navighează la SQL Server-ul creat
2. În meniul din stânga, click **"Networking"**
3. La **Firewall rules:**
   - Click **"Add your client IPv4 address"** (pentru acces local)
   - **Allow Azure services:** `Yes` (pentru Render)
4. Click **"Save"**

### 1.6 Obținere Connection String

1. Navighează la database-ul `CampusConnectDb`
2. În meniul din stânga, click **"Connection strings"**
3. Copiază connection string-ul **ADO.NET (SQL authentication)**
4. Înlocuiește `{your_password}` cu parola reală

**Exemplu Connection String:**
```
Server=tcp:campusconnect-sql-server.database.windows.net,1433;Initial Catalog=CampusConnectDb;Persist Security Info=False;User ID=campusadmin;Password=YOUR_PASSWORD_HERE;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
```

### 1.7 Rulare Migrații (din Local)

Înainte de deploy, rulează migrațiile pentru a crea tabelele:

```bash
# În folderul src/CampusConnect/CampusConnect.Api
# Setează temporar connection string-ul Azure

# Windows PowerShell
$env:ConnectionStrings__DefaultConnection="Server=tcp:campusconnect-sql-server.database.windows.net,1433;Initial Catalog=CampusConnectDb;..."

# Apoi rulează migrațiile
dotnet ef database update --project ../CampusConnect.Infrastructure
```

Sau modifică temporar `appsettings.json` cu connection string-ul Azure și rulează:
```bash
dotnet ef database update --project ../CampusConnect.Infrastructure
```

---

## Pas 2: Configurare Render (Backend)

### 2.1 Creare Cont Render

1. Accesează [render.com](https://render.com)
2. Click **"Get Started for Free"**
3. Autentifică-te cu **GitHub** (recomandat pentru deploy automat)

### 2.2 Conectare Repository

1. În Dashboard, click **"New +"** → **"Web Service"**
2. Selectează **"Build and deploy from a Git repository"**
3. Click **"Connect"** lângă repository-ul `proiect-inginerie-software-super_team`
4. Dacă nu apare, click **"Configure account"** și dă acces la repository

### 2.3 Configurare Web Service

Completează formularul:

| Câmp | Valoare |
|------|---------|
| **Name** | `campus-api` |
| **Region** | `Frankfurt (EU Central)` |
| **Branch** | `main` |
| **Root Directory** | ` ` (lasă gol - rădăcina repo) |
| **Runtime** | `Docker` |
| **Instance Type** | `Free` (sau `Starter` pentru performanță mai bună) |

### 2.4 Configurare Environment Variables

În secțiunea **"Environment Variables"**, adaugă:

| Key | Value |
|-----|-------|
| `ASPNETCORE_ENVIRONMENT` | `Production` |
| `ConnectionStrings__DefaultConnection` | `<Connection String de la Azure - Pasul 1.6>` |
| `JwtSettings__Secret` | `CampusConnect2025$SecureKey#Production!RandomString12345678` |
| `EmailSettings__Username` | `irina.istrate.maria04@gmail.com` |
| `EmailSettings__Password` | `<App Password Gmail>` |
| `AppSettings__FrontendUrl` | `https://campusconnect-client.vercel.app` |
| `Gemini__ApiKey` | `<Cheia API Gemini>` |

> **Notă:** Pentru `JwtSettings__Secret`, generează un string unic de minim 32 caractere. Poți folosi: https://randomkeygen.com/

### 2.5 Generare Gmail App Password

Pentru a trimite email-uri din aplicație:

1. Accesează [myaccount.google.com](https://myaccount.google.com)
2. Click **"Security"** în meniul din stânga
3. La **"Signing in to Google"**, activează **"2-Step Verification"** (dacă nu e activă)
4. După activare, revino la Security
5. Click **"App passwords"**
6. Selectează:
   - **App:** `Mail`
   - **Device:** `Other (Custom name)` → `CampusConnect`
7. Click **"Generate"**
8. Copiază parola de 16 caractere generată (fără spații)

### 2.6 Deploy

1. Click **"Create Web Service"**
2. Render va:
   - Clona repository-ul
   - Detecta Dockerfile-ul
   - Construi imaginea Docker
   - Deploya aplicația
3. Așteaptă până statusul devine **"Live"** (poate dura 5-10 minute)

### 2.7 Verificare Deploy

1. Click pe URL-ul generat (ex: `https://campus-api.onrender.com`)
2. Accesează `https://campus-api.onrender.com/swagger` pentru documentația API
3. Verifică logurile în tab-ul **"Logs"** pentru erori

---

## Pas 3: Configurare Vercel (Frontend)

### 3.1 Creare Cont Vercel

1. Accesează [vercel.com](https://vercel.com)
2. Click **"Sign Up"**
3. Autentifică-te cu **GitHub** (recomandat)

### 3.2 Import Proiect

1. În Dashboard, click **"Add New..."** → **"Project"**
2. Găsește repository-ul `proiect-inginerie-software-super_team`
3. Click **"Import"**

### 3.3 Configurare Proiect

Completează formularul:

| Câmp | Valoare |
|------|---------|
| **Project Name** | `campusconnect-client` |
| **Framework Preset** | `Vite` (detectat automat) |
| **Root Directory** | Click "Edit" → `src/campusconnect-client` |
| **Build Command** | `npm run build` (default) |
| **Output Directory** | `dist` (default) |
| **Install Command** | `npm install` (default) |

### 3.4 Configurare Environment Variables

În secțiunea **"Environment Variables"**, adaugă:

| Key | Value | Environment |
|-----|-------|-------------|
| `VITE_API_URL` | `https://campus-api.onrender.com/api` | Production |

> **Important:** Variabilele Vite trebuie să înceapă cu `VITE_` pentru a fi accesibile în frontend.

### 3.5 Deploy

1. Click **"Deploy"**
2. Vercel va:
   - Instala dependențele (`npm install`)
   - Construi aplicația (`npm run build`)
   - Deploya fișierele statice
3. Așteaptă până se termină (1-3 minute)

### 3.6 Verificare Deploy

1. Click pe URL-ul generat (ex: `https://campusconnect-client.vercel.app`)
2. Testează funcționalitățile de bază (login, register)

### 3.7 Configurare Domeniu Custom (Opțional)

1. În proiectul Vercel, click **"Settings"** → **"Domains"**
2. Adaugă domeniul tău (ex: `campusconnect.ro`)
3. Urmează instrucțiunile pentru configurare DNS

---

## Pas 4: Configurare Finală și Testare

### 4.1 Actualizare URL-uri

După ce ambele servicii sunt live, actualizează:

1. **În Render** (Environment Variables):
   - `AppSettings__FrontendUrl` = URL-ul real de la Vercel

2. **În Vercel** (Environment Variables):
   - `VITE_API_URL` = URL-ul real de la Render + `/api`

3. **În fișierul** `.env.production` (pentru build-uri viitoare):
   ```env
   VITE_API_URL=https://campus-api.onrender.com/api
   ```

### 4.2 Redeploy

După actualizarea variabilelor:

- **Render:** Redeploy automat sau click "Manual Deploy" → "Deploy latest commit"
- **Vercel:** Redeploy automat sau click "Redeploy" în dashboard

### 4.3 Testare End-to-End

Verifică următoarele funcționalități:

| Funcționalitate | Ce să testezi |
|-----------------|---------------|
| **Înregistrare** | Creează un cont nou, verifică email-ul de confirmare |
| **Login** | Autentifică-te cu contul creat |
| **API** | Verifică că datele se încarcă corect |
| **CORS** | Nu ar trebui să vezi erori CORS în consolă |
| **HTTPS** | Verifică că certificatul SSL e valid |

### 4.4 Monitorizare

- **Render:** Tab-ul "Logs" pentru erori backend
- **Vercel:** Tab-ul "Functions" → "Logs" (dacă folosești API routes)
- **Azure:** "Query editor" pentru verificare date în DB

---

## Troubleshooting

### Erori Comune

#### 1. CORS Error
```
Access to XMLHttpRequest has been blocked by CORS policy
```
**Soluție:** Verifică că `AppSettings__FrontendUrl` în Render conține URL-ul corect al frontend-ului (inclusiv `https://`).

#### 2. 500 Internal Server Error
**Soluție:**
- Verifică logurile în Render
- Asigură-te că connection string-ul e corect
- Verifică că migrațiile au fost rulate

#### 3. Database Connection Failed
```
A network-related or instance-specific error occurred
```
**Soluție:**
- Verifică firewall-ul Azure (permite Azure services)
- Verifică connection string-ul (parolă, server name)
- Verifică că database-ul există

#### 4. JWT Token Invalid
**Soluție:** Asigură-te că `JwtSettings__Secret` e identic în toate mediile sau folosește unul nou în production.

#### 5. Email-uri nu se trimit
**Soluție:**
- Verifică App Password-ul Gmail
- Asigură-te că 2FA e activată pe contul Gmail
- Verifică că username-ul și parola sunt corecte

#### 6. Build Failed pe Vercel
**Soluție:**
- Verifică că Root Directory e setat corect: `src/campusconnect-client`
- Verifică erorile TypeScript: `npm run build` local

#### 7. Render Deploy Slow/Fails
**Soluție:**
- Tier-ul Free pune serviciul în "sleep" după 15 min inactivitate
- Prima cerere după sleep durează ~30-60 secunde
- Upgrade la tier plătit pentru performance constantă

---

## Costuri Estimative

| Serviciu | Plan | Cost/Lună |
|----------|------|-----------|
| **Vercel** | Hobby (Free) | $0 |
| **Render** | Free | $0 (sleep după 15 min) |
| **Render** | Starter | $7 |
| **Azure SQL** | Basic (5 DTU) | ~$5 |
| **Azure SQL** | Serverless | ~$1-5 (pay-per-use) |

**Total minim:** $0-5/lună (cu limitări)
**Total recomandat:** ~$12/lună (pentru performanță acceptabilă)

---

## Comenzi Utile

### Development Local
```bash
# Start Backend
cd src/CampusConnect/CampusConnect.Api
dotnet run

# Start Frontend (alt terminal)
cd src/campusconnect-client
npm run dev
```

### Build Local
```bash
# Backend
dotnet publish -c Release

# Frontend
npm run build
```

### Verificare Environment
```bash
# Vezi ce environment variables sunt setate
echo $ASPNETCORE_ENVIRONMENT

# Test connection string (PowerShell)
$env:ConnectionStrings__DefaultConnection
```

---

## Resurse Utile

- [Documentație Render](https://render.com/docs)
- [Documentație Vercel](https://vercel.com/docs)
- [Azure SQL Quickstart](https://docs.microsoft.com/en-us/azure/azure-sql/database/single-database-create-quickstart)
- [Vite Environment Variables](https://vitejs.dev/guide/env-and-mode.html)
- [ASP.NET Core Configuration](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/)
